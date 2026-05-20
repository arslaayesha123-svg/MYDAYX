namespace MyDayX
{
    partial class charts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(charts));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cmbSortBy = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblIncomeExpenses = new Label();
            lblCatagory = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cmbSortBy);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 123);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Teal;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // cmbSortBy
            // 
            cmbSortBy.AutoCompleteCustomSource.AddRange(new string[] { "Daily", "Weekly", "Monthly" });
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Location = new Point(628, 40);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(144, 33);
            cmbSortBy.TabIndex = 2;
            cmbSortBy.Text = "Sort by";
            cmbSortBy.SelectedIndexChanged += cmbSortBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 8F, FontStyle.Italic);
            label2.Location = new Point(91, 47);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 1;
            label2.Text = "Visualize your financial data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(77, 23);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Charts and Analysis";
            // 
            // chart1
            // 
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chart1.BackgroundImageLayout = ImageLayout.None;
            chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(26, 182);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Teal;
            series1.Legend = "Legend1";
            series1.Name = "Income";
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.MediumAquamarine;
            series2.Legend = "Legend1";
            series2.Name = "Expenses";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(386, 290);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(448, 129);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chart2.RightToLeft = RightToLeft.Yes;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series6";
            chart2.Series.Add(series3);
            chart2.Size = new Size(365, 353);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            title1.DockingOffset = 1;
            title1.Name = "Food";
            title2.DockingOffset = 2;
            title2.Name = "Travel ";
            title3.Name = "Study";
            title4.Name = "shoping";
            title5.Name = "Others";
            chart2.Titles.Add(title1);
            chart2.Titles.Add(title2);
            chart2.Titles.Add(title3);
            chart2.Titles.Add(title4);
            chart2.Titles.Add(title5);
            // 
            // lblIncomeExpenses
            // 
            lblIncomeExpenses.AutoSize = true;
            lblIncomeExpenses.Location = new Point(44, 145);
            lblIncomeExpenses.Name = "lblIncomeExpenses";
            lblIncomeExpenses.Size = new Size(170, 25);
            lblIncomeExpenses.TabIndex = 3;
            lblIncomeExpenses.Text = "Income vs Expenses";
            // 
            // lblCatagory
            // 
            lblCatagory.AutoSize = true;
            lblCatagory.Location = new Point(474, 129);
            lblCatagory.Name = "lblCatagory";
            lblCatagory.Size = new Size(183, 25);
            lblCatagory.TabIndex = 4;
            lblCatagory.Text = "Expenses by catagory";
            // 
            // charts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(878, 494);
            Controls.Add(lblCatagory);
            Controls.Add(lblIncomeExpenses);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(panel1);
            Name = "charts";
            Text = "Charts and Analysis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private ComboBox cmbSortBy;
        private PictureBox pictureBox1;
        private Label lblIncomeExpenses;
        private Label lblCatagory;
    }
}