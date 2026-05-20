using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using MyDayX.Database;

namespace MyDayX
{
    public partial class Dashboard : Form
    {
        private readonly BudgetRepository _repo = new BudgetRepository();
        int _userId;

        private int _currentPage = 1;
        private int _pageSize = 5;
        private int _totalRows = 0;
        private DataTable _fullData = new DataTable();

        public Dashboard(int userId)
        {
            InitializeComponent();
            this.Resize += Dashboard_Resize;
            _userId = userId;

            cmbSortBy.Items.Clear();
            cmbSortBy.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            cmbSortBy.SelectedIndex = 2;

            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");

            LoadUser();
            LoadStats();
            LoadHistory();
        }

        // ── PUBLIC REFRESH — other forms call karein ──────────────────
        public void RefreshData()
        {
            LoadStats();
            LoadHistory();
        }

       

        // ── LOAD USER ─────────────────────────────────────────────────
        private void LoadUser()
        {
            using (var con = MyDatabase.GetConnection())
            {
                con.Open();
                string q = "SELECT Username FROM Users WHERE Id=@id";
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@id", _userId);
                    var name = cmd.ExecuteScalar();
                    lblUser.Text = " Welcome " + name?.ToString();
                }
            }
        }

        // ── DATE FILTER ───────────────────────────────────────────────
        private string GetFilter()
        {
            switch (cmbSortBy.Text)
            {
                case "Daily": return "date(Date) = date('now')";
                case "Weekly": return "date(Date) >= date('now','-7 day')";
                case "Monthly": return "date(Date) >= date('now','-30 day')";
                default: return "1=1";
            }
        }

        private string GetPrevFilter()
        {
            switch (cmbSortBy.Text)
            {
                case "Daily":
                    return "date(Date) = date('now', '-1 day')";
                case "Weekly":
                    return "date(Date) BETWEEN date('now','-14 day') AND date('now','-7 day')";
                case "Monthly":
                    return "date(Date) BETWEEN date('now','-60 day') AND date('now','-30 day')";
                default:
                    return "1=0";
            }
        }

        // ── LOAD STATS ────────────────────────────────────────────────
        private void LoadStats()
        {
            try
            {
                string filter = GetFilter();
                string prevFilter = GetPrevFilter();

                using (var con = MyDatabase.GetConnection())
                {
                    con.Open();

                    double income = GetAmount(con, "Income", filter);
                    double expense = GetAmount(con, "Expenses", filter);
                    double savings = income - expense;
                    double prevIncome = GetAmount(con, "Income", prevFilter);
                    double prevExpense = GetAmount(con, "Expenses", prevFilter);

                    lblIncome2.Text = income.ToString("F0");
                    lblIncome2.ForeColor = Color.Green;
                    lblIncome3.Text = GetChangeText(income, prevIncome);
                    lblIncome3.ForeColor = income >= prevIncome ? Color.Green : Color.Red;

                    lblExpenses2.Text = expense.ToString("F0");
                    lblExpenses2.ForeColor = Color.Red;
                    lblExpenses3.Text = GetChangeText(expense, prevExpense);
                    lblExpenses3.ForeColor = expense <= prevExpense ? Color.Green : Color.Red;

                    lblSavings2.Text = savings.ToString("F0");
                    lblSavings2.ForeColor = savings >= 0 ? Color.Green : Color.Red;
                    lblSavings3.Text = savings >= 0 ? "↑ Saving Well 👍" : "↓ Overspending ⚠️";
                    lblSavings3.ForeColor = savings >= 0 ? Color.Green : Color.Red;

                    double usedPct = income > 0 ? (expense / income) * 100 : 0;

                    lblStatus2.Text = GetOverallStatus(usedPct);
                    lblStatus2.ForeColor = GetStatusColor(usedPct);
                    lblStatus2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                    lblStatus.Text = GetOverallMessage(usedPct);
                    lblStatus.ForeColor = GetStatusColor(usedPct);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stats error: " + ex.Message);
            }
        }

        // ── HELPERS ───────────────────────────────────────────────────
        private double GetAmount(SQLiteConnection con, string table, string filter)
        {
            string q = $"SELECT IFNULL(SUM(Amount),0) FROM {table} WHERE UserId=@id AND {filter}";
            using (var cmd = new SQLiteCommand(q, con))
            {
                cmd.Parameters.AddWithValue("@id", _userId);
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
        }

        private string GetChangeText(double current, double previous)
        {
            if (previous == 0) return current > 0 ? "↑ New entry" : "No data";
            double change = ((current - previous) / previous) * 100;
            string arrow = change >= 0 ? "↑" : "↓";
            return $"{arrow} {Math.Abs(change):F0}% from last period";
        }

        private string GetOverallStatus(double usedPct)
        {
            if (usedPct <= 50) return "GOOD";
            if (usedPct <= 80) return "AVERAGE";
            if (usedPct <= 100) return "WARNING";
            return "EXCEEDED";
        }

        private Color GetStatusColor(double usedPct)
        {
            if (usedPct <= 50) return Color.Green;
            if (usedPct <= 80) return Color.Orange;
            return Color.Red;
        }

        private string GetOverallMessage(double usedPct)
        {
            if (usedPct <= 50) return "You are doing great!";
            if (usedPct <= 80) return "Be careful with spending!";
            if (usedPct <= 100) return "Almost at budget limit!";
            return "Budget exceeded! Reduce expenses!";
        }

        // ── LOAD HISTORY ──────────────────────────────────────────────
        private void LoadHistory()
        {
            try
            {
                string filter = GetFilter();

                using (var con = MyDatabase.GetConnection())
                {
                    con.Open();
                    string q = $@"
                SELECT 
                    date(Date) AS Date,
                    time(Date) AS Time,
                    'Income' AS Type,
                    Category,
                    Amount
                FROM Income WHERE UserId=@id AND {filter}
                UNION ALL
                SELECT 
                    date(Date) AS Date,
                    time(Date) AS Time,
                    'Expense' AS Type,
                    Category,
                    Amount
                FROM Expenses WHERE UserId=@id AND {filter}
                ORDER BY Date DESC, Time DESC";

                    using (var cmd = new SQLiteCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@id", _userId);
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        _fullData = new DataTable();
                        da.Fill(_fullData);
                    }
                }

                _totalRows = _fullData.Rows.Count;
                _currentPage = 1;
                ShowPage();
                UpdatePagination();
            }
            catch (Exception ex)
            {
                MessageBox.Show("History error: " + ex.Message);
            }
        }

        // ── SHOW PAGE ─────────────────────────────────────────────────
        private void ShowPage()
        {
            int start = (_currentPage - 1) * _pageSize;
            int end = Math.Min(start + _pageSize, _totalRows);

            DataTable pageData = _fullData.Clone();
            for (int i = start; i < end; i++)
                pageData.ImportRow(_fullData.Rows[i]);

            dgvTable.AutoGenerateColumns = true;
            dgvTable.DataSource = pageData;
            dgvTable.BackgroundColor = Color.White;
            dgvTable.BorderStyle = BorderStyle.None;
            dgvTable.RowHeadersVisible = false;
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow row in dgvTable.Rows)
            {
                if (row.Cells["Type"]?.Value?.ToString() == "Income")
                    row.DefaultCellStyle.ForeColor = Color.Green;
                else
                    row.DefaultCellStyle.ForeColor = Color.Red;
            }

            lblShow.Text = _totalRows == 0
                ? "No records found"
                : $"Showing {start + 1} to {end} of {_totalRows}";
        }

        // ── PAGINATION ────────────────────────────────────────────────
        private void UpdatePagination()
        {
            int totalPages = (int)Math.Ceiling((double)_totalRows / _pageSize);

            btn1.Enabled = totalPages >= 1;
            btn2.Enabled = totalPages >= 2;
            btn3.Enabled = totalPages >= 3;
            btn4.Enabled = _currentPage < totalPages;

            btn1.BackColor = _currentPage == 1 ? Color.Teal : Color.White;
            btn1.ForeColor = _currentPage == 1 ? Color.White : Color.Black;
            btn2.BackColor = _currentPage == 2 ? Color.Teal : Color.White;
            btn2.ForeColor = _currentPage == 2 ? Color.White : Color.Black;
            btn3.BackColor = _currentPage == 3 ? Color.Teal : Color.White;
            btn3.ForeColor = _currentPage == 3 ? Color.White : Color.Black;
            btn4.BackColor = Color.White;
            btn4.ForeColor = Color.Black;
        }

        private void btn1_Click(object sender, EventArgs e)
        { _currentPage = 1; ShowPage(); UpdatePagination(); }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((int)Math.Ceiling((double)_totalRows / _pageSize) >= 2)
            { _currentPage = 2; ShowPage(); UpdatePagination(); }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((int)Math.Ceiling((double)_totalRows / _pageSize) >= 3)
            { _currentPage = 3; ShowPage(); UpdatePagination(); }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_totalRows / _pageSize);
            if (_currentPage < totalPages)
            { _currentPage++; ShowPage(); UpdatePagination(); }
        }

        // ── NAVIGATION ────────────────────────────────────────────────
        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStats();
            LoadHistory();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadStats();
            LoadHistory();
        }

        private void btnBudget_Click1(object sender, EventArgs e)
        {
            Budget b = new Budget(_userId);
            b.FormClosed += (s, args) => { LoadStats(); LoadHistory(); };
            b.Show();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            charts c = new charts(_userId);
            c.FormClosed += (s, args) => { LoadStats(); };
            c.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            history h = new history(_userId);
            h.FormClosed += (s, args) => { LoadStats(); LoadHistory(); };
            h.Show();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            Performance p = new Performance(_userId);
            p.FormClosed += (s, args) => { LoadStats(); };
            p.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void Dashboard_Load_1(object sender, EventArgs e) { }
        private void Dashboard_Resize(object sender, EventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            // Left panel height
            pnlDashboard.Height = h;

            // Content area width
            int contentX = pnlDashboard.Right + 10;
            int contentW = w - contentX - 10;

            // Top 4 panels
            int panelW = (contentW - 20) / 2;
            pnlIncome.Width = panelW;
            pnlExpenses.Width = panelW;
            pnlSavings.Width = panelW;
            pnlStatus.Width = panelW;

            pnlExpenses.Left = pnlIncome.Right + 20;
            pnlSavings.Left = pnlIncome.Left;
            pnlStatus.Left = pnlExpenses.Left;

            // DataGridView
            dgvTable.Width = contentW;
            dgvTable.Left = contentX;
            dgvTable.Height = h - dgvTable.Top - 80;

            // Pagination buttons bottom
            btn1.Top = dgvTable.Bottom + 10;
            btn2.Top = btn1.Top;
            btn3.Top = btn1.Top;
            btn4.Top = btn1.Top;

            btn4.Left = dgvTable.Right - btn4.Width;
            btn3.Left = btn4.Left - btn3.Width - 5;
            btn2.Left = btn3.Left - btn2.Width - 5;
            btn1.Left = btn2.Left - btn1.Width - 5;

            lblShow.Top = btn1.Top + 5;
        }

    }
}
