using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MyDayX.Database;

namespace MyDayX
{
    public partial class charts : Form
    {
        BudgetRepository repo = new BudgetRepository();
        int _userId;

        public charts(int userId)
        {
            InitializeComponent();
            this.Resize += Charts_Resize;
            _userId = userId;

            cmbSortBy.Items.Clear();
            cmbSortBy.Items.AddRange(new object[]
                { "Daily", "Weekly", "Monthly", "Yearly" });
            cmbSortBy.SelectedIndex = 2;

            LoadCharts();
        }

        private void LoadCharts()
        {
            LoadBarChart();
            LoadPieChart();
        }

        // ── BAR CHART ─────────────────────────────────────────────────
        private void LoadBarChart()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].BackColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.LineColor = Color.Gray;

            string filter = GetDateFilter();

            double income = 0, expense = 0;

            DataTable incDt = repo.GetIncomeHistory(_userId);
            DataTable expDt = repo.GetExpenseHistory(_userId);

            foreach (DataRow row in incDt.Rows)
                if (IsInFilter(row["Date"].ToString(), filter))
                    income += Convert.ToDouble(row["Amount"]);

            foreach (DataRow row in expDt.Rows)
                if (IsInFilter(row["Date"].ToString(), filter))
                    expense += Convert.ToDouble(row["Amount"]);

            // ── Income series ─────────────────────────────────────────
            Series incSeries = new Series("Income")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Teal,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ChartArea = chart1.ChartAreas[0].Name
            };
            incSeries["PointWidth"] = "0.5";
            incSeries.Points.AddXY("Income", income);
            chart1.Series.Add(incSeries);

            // ── Expenses series ───────────────────────────────────────
            Series expSeries = new Series("Expenses")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.MediumAquamarine,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ChartArea = chart1.ChartAreas[0].Name
            };
            expSeries["PointWidth"] = "0.5";
            expSeries.Points.AddXY("Expenses", expense);
            chart1.Series.Add(expSeries);

            chart1.Titles.Add("Income vs Expenses");
        }

        // ── PIE CHART ─────────────────────────────────────────────────
        private void LoadPieChart()
        {
            chart2.Series.Clear();
            chart2.Titles.Clear();

            string filter = GetDateFilter();
            DataTable expDt = repo.GetExpenseHistory(_userId);

            var categories = new Dictionary<string, double>();

            foreach (DataRow row in expDt.Rows)
            {
                if (!IsInFilter(row["Date"].ToString(), filter)) continue;
                string cat = row["Category"]?.ToString() ?? "Other";
                double amount = Convert.ToDouble(row["Amount"]);
                if (categories.ContainsKey(cat))
                    categories[cat] += amount;
                else
                    categories[cat] = amount;
            }

            Series pieSeries = new Series("Expenses by Category")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#VALX\n#PERCENT{P0}",
                Font = new Font("Segoe UI", 8F),
                ChartArea = chart2.ChartAreas[0].Name
            };

            if (categories.Count == 0)
            {
                chart2.Titles.Add("No expense data found!");
                chart2.Series.Add(pieSeries);
                return;
            }

            Color[] colors = new Color[]
            {
                Color.Teal, Color.MediumAquamarine, Color.DarkCyan,
                Color.CadetBlue, Color.LightSeaGreen, Color.MediumTurquoise
            };

            int i = 0;
            foreach (var kvp in categories)
            {
                int idx = pieSeries.Points.AddXY(kvp.Key, kvp.Value);
                pieSeries.Points[idx].Color = colors[i % colors.Length];
                i++;
            }

            chart2.Series.Add(pieSeries);
            chart2.Titles.Add("Expenses by Category");
        }

        // ── HELPERS ───────────────────────────────────────────────────
        private string GetDateFilter()
        {
            return cmbSortBy.SelectedItem?.ToString() ?? "Monthly";
        }

        private bool IsInFilter(string dateStr, string filter)
        {
            if (!DateTime.TryParse(dateStr, out DateTime date)) return false;
            switch (filter)
            {
                case "Daily": return date.Date == DateTime.Today;
                case "Weekly": return date >= DateTime.Today.AddDays(-7);
                case "Monthly": return date >= DateTime.Today.AddDays(-30);
                case "Yearly": return date >= DateTime.Today.AddDays(-365);
                default: return true;
            }
        }

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCharts();
        }

        // ── RESIZE ────────────────────────────────────────────────────
        private void Charts_Resize(object sender, EventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            // Header
            panel1.Width = w;
            panel1.Left = 0;

            // ComboBox
            cmbSortBy.Left = w - cmbSortBy.Width - 20;
            cmbSortBy.Top = (panel1.Height - cmbSortBy.Height) / 2;

            // Charts
            int chartW = (w - 30) / 2;
            int chartH = h - panel1.Bottom - 20;

            chart1.Left = 10;
            chart1.Top = panel1.Bottom + 10;
            chart1.Width = chartW;
            chart1.Height = chartH;

            chart2.Left = chart1.Right + 10;
            chart2.Top = panel1.Bottom + 10;
            chart2.Width = chartW;
            chart2.Height = chartH;
        }
    }
}