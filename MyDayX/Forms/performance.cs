using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using MyDayX.Database;

namespace MyDayX
{
    public partial class Performance : Form
    {
        private readonly ReportRepository _repo = new ReportRepository();
        private readonly BudgetRepository _budgetRepo = new BudgetRepository();
        private int _userId;

        public Performance(int userId)
        {
            InitializeComponent();
            this.Resize += Performance_Resize;
            _userId = userId;
            LoadPerformance();
        }


        private void Form7_Load(object sender, EventArgs e) { }
        private void Performance_Load(object sender, EventArgs e) { }
        private void lblStatus2_Click(object sender, EventArgs e) { }

        private void LoadPerformance()
        {
            double totalIncome = _budgetRepo.GetTotalIncome(_userId);
            double totalExpense = _repo.GetTotalExpense(_userId);
            double overallPct = totalIncome > 0 ? (totalExpense / totalIncome) * 100 : 0;

            var limits = _budgetRepo.GetBudgetLimits(_userId);
            DataTable catDt = _repo.GetExpenseByCategory(_userId);

            double GetSpent(string cat)
            {
                foreach (DataRow row in catDt.Rows)
                    if (row["Category"].ToString().Equals(cat,
                        StringComparison.OrdinalIgnoreCase))
                        return Convert.ToDouble(row["Total"]);
                return 0;
            }

            double foodSpent = GetSpent("Food");
            double travelSpent = GetSpent("Travel");
            double studySpent = GetSpent("Study");
            double shoppingSpent = GetSpent("Shopping");
            double healthSpent = GetSpent("Health");
            double othersSpent = GetSpent("Other");

            double pctFood = limits.Food > 0 ? (foodSpent / limits.Food) * 100 : 0;
            double pctTravel = limits.Travel > 0 ? (travelSpent / limits.Travel) * 100 : 0;
            double pctStudy = limits.Study > 0 ? (studySpent / limits.Study) * 100 : 0;
            double pctShopping = limits.Shopping > 0 ? (shoppingSpent / limits.Shopping) * 100 : 0;
            double pctHealth = limits.Health > 0 ? (healthSpent / limits.Health) * 100 : 0;
            double pctOthers = limits.Others > 0 ? (othersSpent / limits.Others) * 100 : 0;

            // ── LEFT PANEL ────────────────────────────────────────────
            lblCat1.Text = $"Food      {foodSpent:F0} / {limits.Food:F0}";
            progressBar1.Value = (int)Math.Min(pctFood, 100);
            SetProgressBarColor(progressBar1, pctFood);
            lblStatus1.Text = GetStatus(pctFood);
            lblStatus1.ForeColor = GetColor(pctFood);

            lblCat2.Text = $"Travel    {travelSpent:F0} / {limits.Travel:F0}";
            progressBar2.Value = (int)Math.Min(pctTravel, 100);
            SetProgressBarColor(progressBar2, pctTravel);
            lblStatus2.Text = GetStatus(pctTravel);
            lblStatus2.ForeColor = GetColor(pctTravel);

            lblCat3.Text = $"Study     {studySpent:F0} / {limits.Study:F0}";
            progressBar3.Value = (int)Math.Min(pctStudy, 100);
            SetProgressBarColor(progressBar3, pctStudy);
            lblStatus3.Text = GetStatus(pctStudy);
            lblStatus3.ForeColor = GetColor(pctStudy);

            lblCat4.Text = $"Shopping  {shoppingSpent:F0} / {limits.Shopping:F0}";
            progressBar4.Value = (int)Math.Min(pctShopping, 100);
            SetProgressBarColor(progressBar4, pctShopping);
            lblStatus4.Text = GetStatus(pctShopping);
            lblStatus4.ForeColor = GetColor(pctShopping);

            lblCat5.Text = $"Health    {healthSpent:F0} / {limits.Health:F0}";
            progressBar5.Value = (int)Math.Min(pctHealth, 100);
            SetProgressBarColor(progressBar5, pctHealth);
            lblStatus5.Text = GetStatus(pctHealth);
            lblStatus5.ForeColor = GetColor(pctHealth);

            lblCat6.Text = $"Others    {othersSpent:F0} / {limits.Others:F0}";
            progressBar6.Value = (int)Math.Min(pctOthers, 100);
            SetProgressBarColor(progressBar6, pctOthers);
            lblStatus6.Text = GetStatus(pctOthers);
            lblStatus6.ForeColor = GetColor(pctOthers);

            // ── RIGHT PANEL ───────────────────────────────────────────
            progressBar7.Value = (int)Math.Min(overallPct, 100);
            SetProgressBarColor(progressBar7, overallPct);
            lblPercent.Text = $"{overallPct:F0}%";
            lblPercent.ForeColor = GetColor(overallPct);
            lblPerformance11.Text = GetStatus(overallPct);
            lblPerformance11.ForeColor = GetColor(overallPct);
            lblStatus.Text = GetOverallMessage(overallPct);
        }
        private void Performance_Resize(object sender, EventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            panel1.Width = w;
            panel1.Left = 0;

            int contentTop = panel1.Bottom + 10;
            int contentH = h - contentTop - 10;
            int half = (w - 30) / 2;

            panel2.Left = 10;
            panel2.Top = contentTop;
            panel2.Width = half;
            panel2.Height = contentH;

            panel3.Left = panel2.Right + 10;
            panel3.Top = contentTop;
            panel3.Width = half;
            panel3.Height = contentH;
        }

        private Color GetColor(double pct)
        {
            if (pct <= 50) return Color.Green;
            if (pct <= 90) return Color.Orange;
            return Color.Red;
        }

        private string GetStatus(double pct)
        {
            if (pct <= 50) return "GOOD";
            if (pct <= 90) return "AVERAGE";
            return "BAD";
        }

        private string GetOverallMessage(double pct)
        {
            if (pct <= 50) return "You are managing your budget well!";
            if (pct <= 90) return "Be careful with spending!";
            return "Budget exceeded! Reduce expenses!";
        }


        private void SetProgressBarColor(ProgressBar pb, double pct)
        {
            pb.Style = ProgressBarStyle.Continuous;

            Color color = pct <= 50 ? Color.Green
                        : pct <= 90 ? Color.Orange
                        : Color.Red;

        }

        private void progressBar7_Click(object sender, EventArgs e)
        {

        }
    }
}