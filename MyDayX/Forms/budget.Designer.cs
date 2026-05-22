namespace MyDayX
{
    partial class Budget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget));
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblFood = new Label();
            lblTravel = new Label();
            lblStudy = new Label();
            btnBudget = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            btnExpenses = new Button();
            txtAmount = new TextBox();
            txtExpensesAmount = new TextBox();
            txtTotalSavings = new TextBox();
            txtTotalExpenses = new TextBox();
            txtTotalIncome = new TextBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            txt3 = new TextBox();
            lblBudgetLimit = new Label();
            grpExpenses = new GroupBox();
            dateTimePicker = new DateTimePicker();
            cmbCategory = new ComboBox();
            grpIncome = new GroupBox();
            cmbSource = new ComboBox();
            grpBudgetlimit = new GroupBox();
            lblOther = new Label();
            lblHealth = new Label();
            lblShopping = new Label();
            txt6 = new TextBox();
            txt5 = new TextBox();
            txt4 = new TextBox();
            grpSummary = new GroupBox();
            progressBar1 = new ProgressBar();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnAddIncome = new Button();
            grpExpenses.SuspendLayout();
            grpIncome.SuspendLayout();
            grpBudgetlimit.SuspendLayout();
            grpSummary.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Amount ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 72);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 44);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 5;
            label6.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 85);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 6;
            label7.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 130);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 7;
            label8.Text = "Date";
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Location = new Point(39, 35);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(59, 25);
            lblFood.TabIndex = 9;
            lblFood.Text = "Food ";
            lblFood.Click += label9_Click;
            // 
            // lblTravel
            // 
            lblTravel.AutoSize = true;
            lblTravel.Location = new Point(41, 68);
            lblTravel.Name = "lblTravel";
            lblTravel.Size = new Size(61, 25);
            lblTravel.TabIndex = 10;
            lblTravel.Text = "Travel ";
            // 
            // lblStudy
            // 
            lblStudy.AutoSize = true;
            lblStudy.Location = new Point(41, 103);
            lblStudy.Name = "lblStudy";
            lblStudy.Size = new Size(56, 25);
            lblStudy.TabIndex = 11;
            lblStudy.Text = "study";
            // 
            // btnBudget
            // 
            btnBudget.BackColor = Color.LightSkyBlue;
            btnBudget.FlatStyle = FlatStyle.Flat;
            btnBudget.Location = new Point(52, 244);
            btnBudget.Name = "btnBudget";
            btnBudget.Size = new Size(141, 40);
            btnBudget.TabIndex = 12;
            btnBudget.Text = "+ Save Budget";
            btnBudget.UseVisualStyleBackColor = false;
            btnBudget.Click += btnBudget_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 36);
            label12.Name = "label12";
            label12.Size = new Size(113, 25);
            label12.TabIndex = 13;
            label12.Text = "Total Income";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(366, 251);
            label13.Name = "label13";
            label13.Size = new Size(0, 25);
            label13.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 78);
            label14.Name = "label14";
            label14.Size = new Size(126, 25);
            label14.TabIndex = 15;
            label14.Text = "Total Expenses";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 116);
            label15.Name = "label15";
            label15.Size = new Size(115, 25);
            label15.TabIndex = 16;
            label15.Text = "Total Savings";
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.DarkSeaGreen;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpenses.ForeColor = SystemColors.ButtonFace;
            btnExpenses.Location = new Point(80, 161);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(141, 40);
            btnExpenses.TabIndex = 17;
            btnExpenses.Text = "+ Add Expenses ";
            btnExpenses.TextAlign = ContentAlignment.MiddleLeft;
            btnExpenses.UseVisualStyleBackColor = false;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(97, 30);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(166, 31);
            txtAmount.TabIndex = 18;
            // 
            // txtExpensesAmount
            // 
            txtExpensesAmount.Location = new Point(121, 44);
            txtExpensesAmount.Name = "txtExpensesAmount";
            txtExpensesAmount.Size = new Size(150, 31);
            txtExpensesAmount.TabIndex = 22;
            // 
            // txtTotalSavings
            // 
            txtTotalSavings.Location = new Point(141, 112);
            txtTotalSavings.Name = "txtTotalSavings";
            txtTotalSavings.Size = new Size(150, 31);
            txtTotalSavings.TabIndex = 23;
            // 
            // txtTotalExpenses
            // 
            txtTotalExpenses.Location = new Point(138, 73);
            txtTotalExpenses.Name = "txtTotalExpenses";
            txtTotalExpenses.Size = new Size(150, 31);
            txtTotalExpenses.TabIndex = 24;
            // 
            // txtTotalIncome
            // 
            txtTotalIncome.Location = new Point(136, 35);
            txtTotalIncome.Name = "txtTotalIncome";
            txtTotalIncome.Size = new Size(150, 31);
            txtTotalIncome.TabIndex = 25;
            // 
            // txt2
            // 
            txt2.Location = new Point(122, 68);
            txt2.Name = "txt2";
            txt2.Size = new Size(150, 31);
            txt2.TabIndex = 26;
            // 
            // txt1
            // 
            txt1.Location = new Point(121, 32);
            txt1.Name = "txt1";
            txt1.Size = new Size(150, 31);
            txt1.TabIndex = 27;
            // 
            // txt3
            // 
            txt3.Location = new Point(123, 103);
            txt3.Name = "txt3";
            txt3.Size = new Size(150, 31);
            txt3.TabIndex = 28;
            // 
            // lblBudgetLimit
            // 
            lblBudgetLimit.AutoSize = true;
            lblBudgetLimit.Location = new Point(9, 157);
            lblBudgetLimit.Name = "lblBudgetLimit";
            lblBudgetLimit.Size = new Size(112, 25);
            lblBudgetLimit.TabIndex = 29;
            lblBudgetLimit.Text = "Budget used";
            // 
            // grpExpenses
            // 
            grpExpenses.BackColor = Color.Honeydew;
            grpExpenses.Controls.Add(dateTimePicker);
            grpExpenses.Controls.Add(cmbCategory);
            grpExpenses.Controls.Add(txtExpensesAmount);
            grpExpenses.Controls.Add(label6);
            grpExpenses.Controls.Add(label7);
            grpExpenses.Controls.Add(label8);
            grpExpenses.Controls.Add(btnExpenses);
            grpExpenses.Location = new Point(405, 107);
            grpExpenses.Name = "grpExpenses";
            grpExpenses.Size = new Size(290, 216);
            grpExpenses.TabIndex = 30;
            grpExpenses.TabStop = false;
            grpExpenses.Text = "Add Expenses";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(121, 124);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(150, 31);
            dateTimePicker.TabIndex = 24;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteCustomSource.AddRange(new string[] { "Food", "Groceries", "Travel", "Fuel", "Shopping", "Clothes", "Accessories", "Bills", "Rent", "Utilities", "Study", "Medicine", "Gym", "Entertainment", "Charity" });
            cmbCategory.DropDownWidth = 148;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(123, 83);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(148, 33);
            cmbCategory.TabIndex = 23;
            // 
            // grpIncome
            // 
            grpIncome.BackColor = Color.SeaShell;
            grpIncome.Controls.Add(btnAddIncome);
            grpIncome.Controls.Add(cmbSource);
            grpIncome.Controls.Add(txtAmount);
            grpIncome.Controls.Add(label1);
            grpIncome.Controls.Add(label2);
            grpIncome.Location = new Point(43, 107);
            grpIncome.Name = "grpIncome";
            grpIncome.Size = new Size(278, 169);
            grpIncome.TabIndex = 23;
            grpIncome.TabStop = false;
            grpIncome.Text = "Add Income";
            // 
            // cmbSource
            // 
            cmbSource.AutoCompleteCustomSource.AddRange(new string[] { "Salary", "Pocket money ", "Gift ", "Others" });
            cmbSource.FormattingEnabled = true;
            cmbSource.Location = new Point(97, 70);
            cmbSource.Name = "cmbSource";
            cmbSource.Size = new Size(166, 33);
            cmbSource.TabIndex = 19;
            // 
            // grpBudgetlimit
            // 
            grpBudgetlimit.BackColor = Color.Azure;
            grpBudgetlimit.Controls.Add(lblOther);
            grpBudgetlimit.Controls.Add(lblHealth);
            grpBudgetlimit.Controls.Add(lblShopping);
            grpBudgetlimit.Controls.Add(txt6);
            grpBudgetlimit.Controls.Add(txt5);
            grpBudgetlimit.Controls.Add(txt4);
            grpBudgetlimit.Controls.Add(txt1);
            grpBudgetlimit.Controls.Add(txt2);
            grpBudgetlimit.Controls.Add(txt3);
            grpBudgetlimit.Controls.Add(btnBudget);
            grpBudgetlimit.Controls.Add(lblFood);
            grpBudgetlimit.Controls.Add(lblTravel);
            grpBudgetlimit.Controls.Add(lblStudy);
            grpBudgetlimit.Location = new Point(43, 282);
            grpBudgetlimit.Name = "grpBudgetlimit";
            grpBudgetlimit.Size = new Size(278, 290);
            grpBudgetlimit.TabIndex = 31;
            grpBudgetlimit.TabStop = false;
            grpBudgetlimit.Text = "Set Budget Limit";
            grpBudgetlimit.Enter += grpBudgetlimit_Enter;
            // 
            // lblOther
            // 
            lblOther.AutoSize = true;
            lblOther.Location = new Point(31, 214);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(62, 25);
            lblOther.TabIndex = 34;
            lblOther.Text = "others";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(39, 175);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(60, 25);
            lblHealth.TabIndex = 33;
            lblHealth.Text = "health";
            // 
            // lblShopping
            // 
            lblShopping.AutoSize = true;
            lblShopping.Location = new Point(39, 139);
            lblShopping.Name = "lblShopping";
            lblShopping.Size = new Size(88, 25);
            lblShopping.TabIndex = 32;
            lblShopping.Text = "shopping";
            // 
            // txt6
            // 
            txt6.Location = new Point(121, 211);
            txt6.Name = "txt6";
            txt6.Size = new Size(150, 31);
            txt6.TabIndex = 31;
            // 
            // txt5
            // 
            txt5.Location = new Point(122, 175);
            txt5.Name = "txt5";
            txt5.Size = new Size(150, 31);
            txt5.TabIndex = 30;
            // 
            // txt4
            // 
            txt4.Location = new Point(121, 139);
            txt4.Name = "txt4";
            txt4.Size = new Size(150, 31);
            txt4.TabIndex = 29;
            // 
            // grpSummary
            // 
            grpSummary.BackColor = Color.GhostWhite;
            grpSummary.Controls.Add(progressBar1);
            grpSummary.Controls.Add(label12);
            grpSummary.Controls.Add(label14);
            grpSummary.Controls.Add(label15);
            grpSummary.Controls.Add(lblBudgetLimit);
            grpSummary.Controls.Add(txtTotalSavings);
            grpSummary.Controls.Add(txtTotalExpenses);
            grpSummary.Controls.Add(txtTotalIncome);
            grpSummary.Location = new Point(405, 329);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(290, 231);
            grpSummary.TabIndex = 32;
            grpSummary.TabStop = false;
            grpSummary.Text = "Summary";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.SaddleBrown;
            progressBar1.Location = new Point(80, 191);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(194, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 82);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Teal;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Teal;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Sitka Banner", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 36);
            label4.Name = "label4";
            label4.Size = new Size(270, 23);
            label4.TabIndex = 11;
            label4.Text = "Manage your income, expenses and budget";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 8);
            label3.Name = "label3";
            label3.Size = new Size(89, 29);
            label3.TabIndex = 10;
            label3.Text = "Budget";
            // 
            // btnAddIncome
            // 
            btnAddIncome.BackColor = Color.LightCoral;
            btnAddIncome.FlatAppearance.BorderSize = 0;
            btnAddIncome.FlatStyle = FlatStyle.Flat;
            btnAddIncome.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddIncome.ForeColor = SystemColors.ActiveCaptionText;
            btnAddIncome.Location = new Point(66, 115);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(127, 40);
            btnAddIncome.TabIndex = 20;
            btnAddIncome.Text = "+ Add Income ";
            btnAddIncome.TextAlign = ContentAlignment.MiddleLeft;
            btnAddIncome.UseVisualStyleBackColor = false;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // Budget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 572);
            Controls.Add(panel1);
            Controls.Add(grpSummary);
            Controls.Add(grpBudgetlimit);
            Controls.Add(grpIncome);
            Controls.Add(grpExpenses);
            Controls.Add(label13);
            Name = "Budget";
            Text = "Budget";
            TransparencyKey = Color.WhiteSmoke;
            grpExpenses.ResumeLayout(false);
            grpExpenses.PerformLayout();
            grpIncome.ResumeLayout(false);
            grpIncome.PerformLayout();
            grpBudgetlimit.ResumeLayout(false);
            grpBudgetlimit.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnIncome;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnBudget;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button btnExpenses;
        private TextBox txtAmount;
        private TextBox txtExpensesAmount;
        private TextBox txtTotalSavings;
        private TextBox txtTotalExpenses;
        private TextBox txtTotalIncome;
        private TextBox txt2;
        private TextBox txt1;
        private TextBox txt3;
        private Label lblBudgetLimit;
        private GroupBox grpExpenses;
        private GroupBox grpIncome;
        private GroupBox grpBudgetlimit;
        private GroupBox grpSummary;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private ComboBox cmbSource;
        private ComboBox cmbCategory;
        private DateTimePicker dateTimePicker;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Label lblFood;
        private Label lblTravel;
        private Label lblStudy;
        private Label lblOther;
        private Label lblHealth;
        private Label lblShopping;
        private TextBox txt6;
        private TextBox txt5;
        private TextBox txt4;
        private Button btnAddIncome;
    }
}