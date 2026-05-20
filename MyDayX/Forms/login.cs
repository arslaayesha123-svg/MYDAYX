using System;
using System.Data.SQLite;
using System.Windows.Forms;
using MyDayX.Database;

namespace MyDayX
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Resize += Login_Resize;
        }






        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter username & password");
                return;
            }

            using (var conn = MyDatabase.GetConnection())
            {
                conn.Open();

                string query = "SELECT Id FROM Users WHERE Username=@u AND Password=@p";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    MessageBox.Show("Login Successful!");

                    Dashboard db = new Dashboard(userId); // user session
                    db.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
        }
        private void Login_Resize(object sender, EventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            // Center all controls
            foreach (Control c in this.Controls)
            {
                c.Left = (w - c.Width) / 2;
            }
        }

    }
}