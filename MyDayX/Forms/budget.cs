using System;
using System.Drawing;
using System.Windows.Forms;
using MyDayX.Database;

namespace MyDayX
{
    public partial class Budget : Form
    {
        private readonly BudgetRepository _repo = new BudgetRepository();
        private int _userId;

        public Budget(int userId)
        {
            InitializeComponent();
            this.Resize += Budget_Resize;
            _userId = userId;

            cmbSource.Items.Clear();
            cmbSource.Items.AddRange(new object[]
                { "Salary", "Freelance", "Business", "Investment", "Other" });

            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new object[]
                { "Food", "Travel", "Study", "Shopping", "Health", "Other" });

            LoadSummary();
            LoadBudgetLimit();
        }

        private void LoadSummary()
        {
            double income = _repo.GetTotalIncome(_userId);
            double expenses = _repo.GetTotalExpense(_userId);
            double savings = income - expenses;
            double used = income > 0 ? (expenses / income) * 100 : 0;

            txtTotalIncome.Text = income.ToString("F2");
            txtTotalExpenses.Text = expenses.ToString("F2");
            txtTotalSavings.Text = savings.ToString("F2");

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = (int)Math.Min(used, 100);
            progressBar1.ForeColor = used <= 50 ? Color.Green
                                   : used <= 90 ? Color.Orange
                                   : Color.Red;
        }

        private void LoadBudgetLimit()
        {
            var limits = _repo.GetBudgetLimits(_userId);
            txt1.Text = limits.Food.ToString();
            txt2.Text = limits.Travel.ToString();
            txt3.Text = limits.Study.ToString();
            txt4.Text = limits.Shopping.ToString();
            txt5.Text = limits.Health.ToString();
            txt6.Text = limits.Others.ToString();
        }

        private void CheckBudgetWarning()
        {
            double limit = _repo.GetBudget(_userId);
            double expense = _repo.GetTotalExpense(_userId);

            if (limit <= 0) return;

            double used = (expense / limit) * 100;

            if (used >= 100)
                MessageBox.Show(
                    $"⚠️ Budget limit exceeded!\nLimit: {limit:F2} | Spent: {expense:F2}",
                    "Budget Exceeded!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (used >= 90)
                MessageBox.Show(
                    $"⚠️ Budget almost full! ({used:F0}% used)\nLimit: {limit:F2} | Spent: {expense:F2}",
                    "Budget Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RefreshDashboard()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Dashboard dashboard)
                {
                    dashboard.RefreshData();
                    break;
                }
            }
        }

       

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtExpensesAmount.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbCategory.Text))
            {
                MessageBox.Show("Please select a category!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _repo.AddExpense(_userId, amount, cmbCategory.Text);
            LoadSummary();
            CheckBudgetWarning();
            RefreshDashboard();

            MessageBox.Show("Expense added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtExpensesAmount.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            double food = double.TryParse(txt1.Text, out double f) ? f : 0;
            double travel = double.TryParse(txt2.Text, out double t) ? t : 0;
            double study = double.TryParse(txt3.Text, out double s) ? s : 0;
            double shopping = double.TryParse(txt4.Text, out double sh) ? sh : 0;
            double health = double.TryParse(txt5.Text, out double h) ? h : 0;
            double others = double.TryParse(txt6.Text, out double o) ? o : 0;
            double total = food + travel + study + shopping + health + others;

            if (total <= 0)
            {
                MessageBox.Show("Please enter at least one limit!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _repo.SetBudget(_userId, food, travel, study, shopping, health, others);
            LoadSummary();
            LoadBudgetLimit();
            RefreshDashboard();

            MessageBox.Show("Budget saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Budget_Resize(object sender, EventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            panel1.Width = w;
            panel1.Left = 0;

            int half = (w - 30) / 2;

            grpIncome.Left = 10;
            grpIncome.Width = half;
            grpBudgetlimit.Left = 10;
            grpBudgetlimit.Width = half;

            grpExpenses.Width = half;
            grpSummary.Width = half;
            grpExpenses.Left = grpIncome.Right + 10;
            grpSummary.Left = grpBudgetlimit.Right + 10;

            grpIncome.Top = panel1.Bottom + 10;
            grpExpenses.Top = panel1.Bottom + 10;
            grpBudgetlimit.Top = grpIncome.Bottom + 10;
            grpSummary.Top = grpExpenses.Bottom + 10;

            int grpH = (h - panel1.Bottom - 40) / 2;
            grpIncome.Height = grpH;
            grpExpenses.Height = grpH;
            grpBudgetlimit.Height = grpH;
            grpSummary.Height = grpH;
        }

        private void label9_Click(object sender, EventArgs e) { }
        private void grpBudgetlimit_Enter(object sender, EventArgs e) { }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAmount.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbSource.Text))
            {
                MessageBox.Show("Please select a source!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _repo.AddIncome(_userId, amount, cmbSource.Text);
            LoadSummary();
            RefreshDashboard();

            MessageBox.Show("Income added!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAmount.Clear();
            cmbSource.SelectedIndex = -1;
        }
    }
}