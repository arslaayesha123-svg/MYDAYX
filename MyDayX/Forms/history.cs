using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using MyDayX.Database;

namespace MyDayX
{
    public partial class history : Form
    {
        private readonly BudgetRepository _repo = new BudgetRepository();
        private int _userId;

        private int _currentPage = 1;
        private int _pageSize = 8;
        private int _totalRows = 0;
        private DataTable _fullData = new DataTable();

        public history(int userId)
        {
            InitializeComponent();
            this.Resize += History_Resize;
            _userId = userId;

            cmbType.Items.Clear();
            cmbType.Items.AddRange(new object[] { "All", "Income", "Expense" });
            cmbType.SelectedIndex = 0;

            cmbSearch.Items.Clear();
            cmbSearch.Items.AddRange(new object[]
                { "All", "Food", "Travel", "Study", "Shopping",
                  "Health", "Salary", "Freelance", "Business", "Other" });
            cmbSearch.SelectedIndex = 0;

            LoadHistory();
        }

        private void History_Load(object sender, EventArgs e) { }

        private void LoadHistory()
        {
            string typeFilter = cmbType.SelectedItem?.ToString() ?? "All";
            string catFilter = cmbSearch.SelectedItem?.ToString() ?? "All";

            using (var con = MyDatabase.GetConnection())
            {
                con.Open();
                string q = "";

                if (typeFilter == "All")
                    q = @"SELECT date(Date) AS Date, time(Date) AS Time,
                          'Income' AS Type, Category, Amount, '' AS Note
                          FROM Income WHERE UserId=@id
                          UNION ALL
                          SELECT date(Date) AS Date, time(Date) AS Time,
                          'Expense' AS Type, Category, Amount, '' AS Note
                          FROM Expenses WHERE UserId=@id
                          ORDER BY Date DESC, Time DESC";
                else if (typeFilter == "Income")
                    q = @"SELECT date(Date) AS Date, time(Date) AS Time,
                          'Income' AS Type, Category, Amount, '' AS Note
                          FROM Income WHERE UserId=@id
                          ORDER BY Date DESC, Time DESC";
                else
                    q = @"SELECT date(Date) AS Date, time(Date) AS Time,
                          'Expense' AS Type, Category, Amount, '' AS Note
                          FROM Expenses WHERE UserId=@id
                          ORDER BY Date DESC, Time DESC";

                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@id", _userId);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    _fullData = new DataTable();
                    da.Fill(_fullData);
                }
            }

            if (catFilter != "All")
            {
                DataView dv = _fullData.DefaultView;
                dv.RowFilter = $"Category = '{catFilter}'";
                _fullData = dv.ToTable();
            }

            _totalRows = _fullData.Rows.Count;
            _currentPage = 1;
            ShowPage();
            UpdatePagination();
        }

        private void ShowPage()
        {
            int start = (_currentPage - 1) * _pageSize;
            int end = Math.Min(start + _pageSize, _totalRows);

            DataTable pageData = _fullData.Clone();
            for (int i = start; i < end; i++)
                pageData.ImportRow(_fullData.Rows[i]);

            dgvHistory.AutoGenerateColumns = true;
            dgvHistory.DataSource = pageData;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            foreach (DataGridViewRow row in dgvHistory.Rows)
            {
                if (row.Cells["Type"]?.Value?.ToString() == "Income")
                    row.DefaultCellStyle.ForeColor = Color.Green;
                else
                    row.DefaultCellStyle.ForeColor = Color.Red;
            }

            lblStatus.Text = _totalRows == 0
                ? "No records found"
                : $"Showing {start + 1} to {end} of {_totalRows}";
        }

        private void UpdatePagination()
        {
            int totalPages = (int)Math.Ceiling((double)_totalRows / _pageSize);

            btn1.Visible = totalPages >= 1;
            btn2.Visible = totalPages >= 2;
            btn3.Visible = totalPages >= 3;
            btn4.Visible = totalPages > 1;

            btn1.BackColor = _currentPage == 1 ? Color.Teal : Color.White;
            btn1.ForeColor = _currentPage == 1 ? Color.White : Color.Black;
            btn2.BackColor = _currentPage == 2 ? Color.Teal : Color.White;
            btn2.ForeColor = _currentPage == 2 ? Color.White : Color.Black;
            btn3.BackColor = _currentPage == 3 ? Color.Teal : Color.White;
            btn3.ForeColor = _currentPage == 3 ? Color.White : Color.Black;
            btn4.BackColor = _currentPage < totalPages ? Color.Teal : Color.White;
            btn4.ForeColor = _currentPage < totalPages ? Color.White : Color.Black;
        }

       

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        { LoadHistory(); }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        { LoadHistory(); }

        private void History_Resize(object sender, EventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            panel1.Width = w;

            cmbType.Top = panel1.Top + (panel1.Height - cmbType.Height) / 2;
            cmbSearch.Top = cmbType.Bottom + 5;
            cmbType.Left = w - cmbType.Width - 20;
            cmbSearch.Left = w - cmbSearch.Width - 20;

            dgvHistory.Left = 10;
            dgvHistory.Top = panel1.Bottom + 10;
            dgvHistory.Width = w - 20;
            dgvHistory.Height = h - dgvHistory.Top - 60;

            btn1.Top = dgvHistory.Bottom + 10;
            btn2.Top = btn1.Top;
            btn3.Top = btn1.Top;
            btn4.Top = btn1.Top;

            btn4.Left = w - btn4.Width - 10;
            btn3.Left = btn4.Left - btn3.Width - 5;
            btn2.Left = btn3.Left - btn2.Width - 5;
            btn1.Left = btn2.Left - btn1.Width - 5;

            lblStatus.Top = btn1.Top + 5;
            lblStatus.Left = 10;
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {

            int totalPages = (int)Math.Ceiling((double)_totalRows / _pageSize);
            if (totalPages >= 2)
            { _currentPage = 2; ShowPage(); UpdatePagination(); }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_totalRows / _pageSize);
            if (totalPages >= 3)
            { _currentPage = 3; ShowPage(); UpdatePagination(); }
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_totalRows / _pageSize);
            if (_currentPage < totalPages)
            { _currentPage++; ShowPage(); UpdatePagination(); }
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            _currentPage = 1;
            ShowPage();
            UpdatePagination();
        }
    }

}