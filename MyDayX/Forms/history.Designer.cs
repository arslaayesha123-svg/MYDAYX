namespace MyDayX
{
    partial class history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cmbSearch = new ComboBox();
            cmbType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dgvHistory = new DataGridView();
            lblStatus = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cmbSearch);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 101);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Teal;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Location = new Point(586, 66);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(159, 33);
            cmbSearch.TabIndex = 3;
            cmbSearch.Text = "search";
            cmbSearch.SelectedIndexChanged += cmbSearch_SelectedIndexChanged;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(586, 17);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(159, 33);
            cmbType.TabIndex = 2;
            cmbType.Text = "types";
            cmbType.SelectedIndexChanged += cmbSearch_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 8F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 45);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 1;
            label2.Text = "View all your transactions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 17);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 0;
            label1.Text = "Transaction History";
            // 
            // dgvHistory
            // 
            dgvHistory.BackgroundColor = SystemColors.ButtonFace;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(21, 105);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.Size = new Size(752, 308);
            dgvHistory.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Sitka Banner", 8F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(12, 440);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(147, 23);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Showing 1 to 5 of total";
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn1.Location = new Point(572, 433);
            btn1.Name = "btn1";
            btn1.Size = new Size(40, 34);
            btn1.TabIndex = 21;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click_1;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn2.Location = new Point(618, 433);
            btn2.Name = "btn2";
            btn2.Size = new Size(40, 34);
            btn2.TabIndex = 22;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click_1;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn3.Location = new Point(664, 433);
            btn3.Name = "btn3";
            btn3.Size = new Size(40, 34);
            btn3.TabIndex = 23;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click_1;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn4.Location = new Point(722, 433);
            btn4.Name = "btn4";
            btn4.Size = new Size(40, 34);
            btn4.TabIndex = 24;
            btn4.Text = ">";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click_1;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 487);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblStatus);
            Controls.Add(dgvHistory);
            Controls.Add(panel1);
            Name = "history";
            Text = "History";
            Click += History_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox2;
        private ComboBox cmbtype;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Catagory;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Note;
        private PictureBox pictureBox1;
        private ComboBox cmbSearch;
        private ComboBox cmbType;
        private DataGridView dgvHistory;
        private Label lblStatus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
    }
}