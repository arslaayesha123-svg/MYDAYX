namespace MyDayX
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            lblEmail = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            btnCreateAccount = new Button();
            label1 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            lblEmail.Click += label1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 185);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(12, 281);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(160, 25);
            lblConfirmPassword.TabIndex = 3;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(199, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(199, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(198, 31);
            txtUsername.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(199, 281);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(198, 31);
            txtConfirmPassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(199, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.MediumSeaGreen;
            btnCreateAccount.BackgroundImageLayout = ImageLayout.None;
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Location = new Point(118, 346);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(168, 47);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 417);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 9;
            label1.Text = "Already have an account?";
            label1.Click += label1_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MintCream;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.RoyalBlue;
            btnLogin.Location = new Point(266, 411);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(72, 36);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(118, 35);
            label2.Name = "label2";
            label2.Size = new Size(254, 32);
            label2.TabIndex = 11;
            label2.Text = "Create New Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 67);
            label3.Name = "label3";
            label3.Size = new Size(164, 22);
            label3.TabIndex = 12;
            label3.Text = "SignUp to get Started";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MintCream;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(441, 510);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblEmail);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Button btnCreateAccount;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}