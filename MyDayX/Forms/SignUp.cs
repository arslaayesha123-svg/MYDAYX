using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using MyDayX.Database;

namespace MyDayX
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.Resize += SignUp_Resize;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void SignUp_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }

        // ── ALREADY HAVE ACCOUNT → LOGIN ──────────────────────────────
        private void button1_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        // ── CREATE ACCOUNT ────────────────────────────────────────────
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // ── Validation ────────────────────────────────────────────
            if (email == "" || username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = MyDatabase.GetConnection())
                {
                    con.Open();

                    // ── Check duplicate ───────────────────────────────
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@u OR Email=@e";
                    using (var checkCmd = new SQLiteCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@u", username);
                        checkCmd.Parameters.AddWithValue("@e", email);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Username or Email already exists!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // ── Insert user ───────────────────────────────────
                    string insertQuery = @"INSERT INTO Users (Email, Username, Password)
                                          VALUES (@e, @u, @p)";
                    using (var cmd = new SQLiteCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.ExecuteNonQuery();
                    }

                    // ── Get new userId ────────────────────────────────
                    string idQuery = "SELECT Id FROM Users WHERE Username=@u";
                    using (var idCmd = new SQLiteCommand(idQuery, con))
                    {
                        idCmd.Parameters.AddWithValue("@u", username);
                        int userId = Convert.ToInt32(idCmd.ExecuteScalar());

                        MessageBox.Show("Account Created Successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dashboard db = new Dashboard(userId);
                        db.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } }
            private void SignUp_Resize(object sender, EventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            foreach (Control c in this.Controls)
            {
                c.Left = (w - c.Width) / 2;
            }
        }
      
    }
}