namespace MyDayX
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnDashboard = new Button();
            btnBudget = new Button();
            btnCharts = new Button();
            btnHistory = new Button();
            lblDashboard = new Label();
            pnlDashboard = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnPerformance = new Button();
            label2 = new Label();
            dgvTable = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            pnlIncome = new Panel();
            pictureBox2 = new PictureBox();
            lblIncome3 = new Label();
            lblIncome2 = new Label();
            label1 = new Label();
            pnlExpenses = new Panel();
            pictureBox3 = new PictureBox();
            lblExpenses3 = new Label();
            lblExpenses2 = new Label();
            label3 = new Label();
            pnlSavings = new Panel();
            pictureBox4 = new PictureBox();
            lblSavings3 = new Label();
            lblSavings2 = new Label();
            label4 = new Label();
            pnlStatus = new Panel();
            pictureBox5 = new PictureBox();
            lblStatus3 = new Label();
            lblStatus2 = new Label();
            label5 = new Label();
            lblStatus = new Label();
            pnlDateDay = new Panel();
            lblDate = new Label();
            lblDay = new Label();
            cmbSortBy = new ComboBox();
            lblUser = new Label();
            lblShow = new Label();
            btn1 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            pnlIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlSavings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlDateDay.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Teal;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 100, 100);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 100);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(19, 91);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(135, 34);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnBudget
            // 
            btnBudget.BackColor = Color.Teal;
            btnBudget.FlatAppearance.BorderSize = 0;
            btnBudget.FlatStyle = FlatStyle.Flat;
            btnBudget.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBudget.ForeColor = Color.White;
            btnBudget.Location = new Point(26, 131);
            btnBudget.Name = "btnBudget";
            btnBudget.Size = new Size(112, 34);
            btnBudget.TabIndex = 1;
            btnBudget.Text = "Budget";
            btnBudget.UseVisualStyleBackColor = false;
            btnBudget.Click += btnBudget_Click1;
            // 
            // btnCharts
            // 
            btnCharts.BackColor = Color.Teal;
            btnCharts.FlatAppearance.BorderSize = 0;
            btnCharts.FlatStyle = FlatStyle.Flat;
            btnCharts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCharts.ForeColor = Color.White;
            btnCharts.Location = new Point(19, 171);
            btnCharts.Name = "btnCharts";
            btnCharts.Size = new Size(112, 34);
            btnCharts.TabIndex = 2;
            btnCharts.Text = "Charts";
            btnCharts.UseVisualStyleBackColor = false;
            btnCharts.Click += btnCharts_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Teal;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(26, 210);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(112, 34);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(194, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(120, 25);
            lblDashboard.TabIndex = 4;
            lblDashboard.Text = "DASHBOARD";
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.Teal;
            pnlDashboard.Controls.Add(pictureBox1);
            pnlDashboard.Controls.Add(btnLogout);
            pnlDashboard.Controls.Add(btnPerformance);
            pnlDashboard.Controls.Add(label2);
            pnlDashboard.Controls.Add(btnBudget);
            pnlDashboard.Controls.Add(btnHistory);
            pnlDashboard.Controls.Add(btnDashboard);
            pnlDashboard.Controls.Add(btnCharts);
            pnlDashboard.ForeColor = Color.White;
            pnlDashboard.Location = new Point(0, 1);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(176, 622);
            pnlDashboard.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Teal;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Teal;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(26, 577);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnPerformance
            // 
            btnPerformance.BackColor = Color.Teal;
            btnPerformance.FlatAppearance.BorderSize = 0;
            btnPerformance.FlatStyle = FlatStyle.Flat;
            btnPerformance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPerformance.ForeColor = Color.White;
            btnPerformance.Location = new Point(19, 250);
            btnPerformance.Name = "btnPerformance";
            btnPerformance.Size = new Size(133, 34);
            btnPerformance.TabIndex = 7;
            btnPerformance.Text = "Performance";
            btnPerformance.UseVisualStyleBackColor = false;
            btnPerformance.Click += btnPerformance_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 24);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 6;
            label2.Text = "MyDayX";
            // 
            // dgvTable
            // 
            dgvTable.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(218, 375);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersVisible = false;
            dgvTable.RowHeadersWidth = 62;
            dgvTable.Size = new Size(571, 173);
            dgvTable.TabIndex = 10;
            dgvTable.CellContentClick += dgvTable_CellContentClick;
            // 
            // pnlIncome
            // 
            pnlIncome.BackColor = Color.Honeydew;
            pnlIncome.BackgroundImageLayout = ImageLayout.None;
            pnlIncome.Controls.Add(pictureBox2);
            pnlIncome.Controls.Add(lblIncome3);
            pnlIncome.Controls.Add(lblIncome2);
            pnlIncome.Controls.Add(label1);
            pnlIncome.Location = new Point(246, 83);
            pnlIncome.Name = "pnlIncome";
            pnlIncome.Size = new Size(230, 120);
            pnlIncome.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // lblIncome3
            // 
            lblIncome3.AutoSize = true;
            lblIncome3.Location = new Point(52, 78);
            lblIncome3.Name = "lblIncome3";
            lblIncome3.Size = new Size(138, 25);
            lblIncome3.TabIndex = 14;
            lblIncome3.Text = "lblIncomeStatus";
            // 
            // lblIncome2
            // 
            lblIncome2.AutoSize = true;
            lblIncome2.Location = new Point(66, 46);
            lblIncome2.Name = "lblIncome2";
            lblIncome2.Size = new Size(100, 25);
            lblIncome2.TabIndex = 13;
            lblIncome2.Text = "lblIncome2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 12;
            label1.Text = "Total Income";
            // 
            // pnlExpenses
            // 
            pnlExpenses.BackColor = Color.MistyRose;
            pnlExpenses.Controls.Add(pictureBox3);
            pnlExpenses.Controls.Add(lblExpenses3);
            pnlExpenses.Controls.Add(lblExpenses2);
            pnlExpenses.Controls.Add(label3);
            pnlExpenses.Location = new Point(559, 83);
            pnlExpenses.Name = "pnlExpenses";
            pnlExpenses.Size = new Size(230, 120);
            pnlExpenses.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // lblExpenses3
            // 
            lblExpenses3.AutoSize = true;
            lblExpenses3.Location = new Point(52, 78);
            lblExpenses3.Name = "lblExpenses3";
            lblExpenses3.Size = new Size(151, 25);
            lblExpenses3.TabIndex = 15;
            lblExpenses3.Text = "lblExpensesStatus";
            // 
            // lblExpenses2
            // 
            lblExpenses2.AutoSize = true;
            lblExpenses2.Location = new Point(63, 48);
            lblExpenses2.Name = "lblExpenses2";
            lblExpenses2.Size = new Size(113, 25);
            lblExpenses2.TabIndex = 14;
            lblExpenses2.Text = "lblExpenses2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 13;
            label3.Text = "Total Expenses";
            // 
            // pnlSavings
            // 
            pnlSavings.BackColor = Color.Cornsilk;
            pnlSavings.Controls.Add(pictureBox4);
            pnlSavings.Controls.Add(lblSavings3);
            pnlSavings.Controls.Add(lblSavings2);
            pnlSavings.Controls.Add(label4);
            pnlSavings.Location = new Point(246, 222);
            pnlSavings.Name = "pnlSavings";
            pnlSavings.Size = new Size(230, 125);
            pnlSavings.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 45);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // lblSavings3
            // 
            lblSavings3.AutoSize = true;
            lblSavings3.Location = new Point(66, 83);
            lblSavings3.Name = "lblSavings3";
            lblSavings3.Size = new Size(140, 25);
            lblSavings3.TabIndex = 16;
            lblSavings3.Text = "lblSavingsStatus";
            // 
            // lblSavings2
            // 
            lblSavings2.AutoSize = true;
            lblSavings2.Location = new Point(66, 52);
            lblSavings2.Name = "lblSavings2";
            lblSavings2.Size = new Size(102, 25);
            lblSavings2.TabIndex = 15;
            lblSavings2.Text = "lblSavings2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 14;
            label4.Text = "Total Savings";
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.Lavender;
            pnlStatus.Controls.Add(pictureBox5);
            pnlStatus.Controls.Add(lblStatus3);
            pnlStatus.Controls.Add(lblStatus2);
            pnlStatus.Controls.Add(label5);
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Location = new Point(562, 227);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(227, 120);
            pnlStatus.TabIndex = 11;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(8, 40);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // lblStatus3
            // 
            lblStatus3.AutoSize = true;
            lblStatus3.Location = new Point(72, 79);
            lblStatus3.Name = "lblStatus3";
            lblStatus3.Size = new Size(0, 25);
            lblStatus3.TabIndex = 17;
            // 
            // lblStatus2
            // 
            lblStatus2.AutoSize = true;
            lblStatus2.Location = new Point(69, 48);
            lblStatus2.Name = "lblStatus2";
            lblStatus2.Size = new Size(89, 25);
            lblStatus2.TabIndex = 16;
            lblStatus2.Text = "lblStatus2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 12);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 15;
            label5.Text = "Overall Status";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8F);
            lblStatus.Location = new Point(39, 79);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 21);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "Status:";
            // 
            // pnlDateDay
            // 
            pnlDateDay.BackColor = Color.Azure;
            pnlDateDay.Controls.Add(lblDate);
            pnlDateDay.Controls.Add(lblDay);
            pnlDateDay.Location = new Point(619, 9);
            pnlDateDay.Name = "pnlDateDay";
            pnlDateDay.Size = new Size(170, 68);
            pnlDateDay.TabIndex = 16;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(23, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 25);
            lblDate.TabIndex = 18;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(23, 39);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(0, 25);
            lblDay.TabIndex = 17;
            // 
            // cmbSortBy
            // 
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly" });
            cmbSortBy.Location = new Point(490, 15);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(123, 33);
            cmbSortBy.TabIndex = 9;
            cmbSortBy.Text = "sort by";
            cmbSortBy.SelectedIndexChanged += cmbSortBy_SelectedIndexChanged;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(194, 44);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 25);
            lblUser.TabIndex = 18;
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.Font = new Font("Sitka Banner", 8F, FontStyle.Italic);
            lblShow.ForeColor = Color.Black;
            lblShow.Location = new Point(194, 600);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(147, 23);
            lblShow.TabIndex = 21;
            lblShow.Text = "Showing 1 to 5 of total";
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn1.Location = new Point(631, 589);
            btn1.Name = "btn1";
            btn1.Size = new Size(40, 34);
            btn1.TabIndex = 22;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn4.Location = new Point(772, 589);
            btn4.Name = "btn4";
            btn4.Size = new Size(40, 34);
            btn4.TabIndex = 23;
            btn4.Text = ">";
            btn4.TextAlign = ContentAlignment.TopCenter;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn3.Location = new Point(726, 589);
            btn3.Name = "btn3";
            btn3.Size = new Size(40, 34);
            btn3.TabIndex = 24;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn2.Location = new Point(680, 589);
            btn2.Name = "btn2";
            btn2.Size = new Size(40, 34);
            btn2.TabIndex = 25;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(841, 626);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(lblShow);
            Controls.Add(lblUser);
            Controls.Add(cmbSortBy);
            Controls.Add(pnlDateDay);
            Controls.Add(pnlStatus);
            Controls.Add(pnlSavings);
            Controls.Add(pnlExpenses);
            Controls.Add(pnlIncome);
            Controls.Add(dgvTable);
            Controls.Add(pnlDashboard);
            Controls.Add(lblDashboard);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load_1;
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            pnlIncome.ResumeLayout(false);
            pnlIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlExpenses.ResumeLayout(false);
            pnlExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlSavings.ResumeLayout(false);
            pnlSavings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlDateDay.ResumeLayout(false);
            pnlDateDay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDashboard;
        private Button btnBudget;
        private Button btnCharts;
        private Button btnHistory;
        private Label lblDashboard;
        private Panel pnlDashboard;
        private Label label2;
        private Button btnLogout;
        private Button btnPerformance;
        private DataGridView dgvTable;
        private SaveFileDialog saveFileDialog1;
        private Panel pnlIncome;
        private Panel pnlExpenses;
        private Panel pnlSavings;
        private Panel pnlStatus;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel pnlDateDay;
       
        private Label lblDay;
        private Label lblDate;
        private ComboBox cmbSortBy;
        private PictureBox pictureBox1;
        private Label lblStatus;
        private Label lblUser;
        private Label lblIncome3;
        private Label lblIncome2;
        private Label lblExpenses3;
        private Label lblExpenses2;
        private Label lblSavings3;
        private Label lblSavings2;
        private Label lblStatus3;
        private Label lblStatus2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblShow;
        private Button btn1;
        private Button btn4;
        private Button btn3;
        private Button btn2;
    }
}