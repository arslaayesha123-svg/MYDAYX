using System;
using System.Data;
using System.Data.SQLite;

namespace MyDayX.Database
{
    public class BudgetRepository : BaseRepository
    {
        // ================= ADD INCOME =================
        public void AddIncome(int userId, double amount, string category)
        {
            string q = @"INSERT INTO Income (UserId, Amount, Category, Date)
                         VALUES (@u, @a, @c, @d)";
            Execute(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@a", amount);
                cmd.Parameters.AddWithValue("@c", category);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);
            });
        }

        // ================= ADD EXPENSE =================
        public void AddExpense(int userId, double amount, string category)
        {
            string q = @"INSERT INTO Expenses (UserId, Amount, Category, Date)
                         VALUES (@u, @a, @c, @d)";
            Execute(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@a", amount);
                cmd.Parameters.AddWithValue("@c", category);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);
            });
        }

        // ================= TOTAL INCOME =================
        public double GetTotalIncome(int userId)
        {
            object r = Scalar("SELECT SUM(Amount) FROM Income WHERE UserId=@u",
                cmd => cmd.Parameters.AddWithValue("@u", userId));
            return (r == DBNull.Value || r == null) ? 0 : Convert.ToDouble(r);
        }

        // ================= TOTAL EXPENSE =================
        public double GetTotalExpense(int userId)
        {
            object r = Scalar("SELECT SUM(Amount) FROM Expenses WHERE UserId=@u",
                cmd => cmd.Parameters.AddWithValue("@u", userId));
            return (r == DBNull.Value || r == null) ? 0 : Convert.ToDouble(r);
        }

        // ================= SAVE BUDGET =================
        public void SetBudget(int userId, double food, double travel, double study,
                               double shopping, double health, double others)
        {
            double total = food + travel + study + shopping + health + others;

            Execute("DELETE FROM Budget WHERE UserId=@u", cmd =>
                cmd.Parameters.AddWithValue("@u", userId));

            Execute(@"INSERT INTO Budget (UserId, LimitAmount, Food, Travel, Study, Shopping, Health, Others)
                      VALUES (@u, @l, @f, @t, @s, @sh, @h, @o)", cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@l", total);
                cmd.Parameters.AddWithValue("@f", food);
                cmd.Parameters.AddWithValue("@t", travel);
                cmd.Parameters.AddWithValue("@s", study);
                cmd.Parameters.AddWithValue("@sh", shopping);
                cmd.Parameters.AddWithValue("@h", health);
                cmd.Parameters.AddWithValue("@o", others);
            });
        }

        // ================= GET BUDGET =================
        public double GetBudget(int userId)
        {
            object r = Scalar("SELECT LimitAmount FROM Budget WHERE UserId=@u",
                cmd => cmd.Parameters.AddWithValue("@u", userId));
            return r == null ? 0 : Convert.ToDouble(r);
        }

        // ================= GET BUDGET LIMITS =================
        public (double Food, double Travel, double Study,
                double Shopping, double Health, double Others) GetBudgetLimits(int userId)
        {
            using (var con = MyDatabase.GetConnection())
            {
                con.Open();
                string q = "SELECT Food, Travel, Study, Shopping, Health, Others FROM Budget WHERE UserId=@u LIMIT 1";
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@u", userId);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                            return (
                                Convert.ToDouble(r["Food"]),
                                Convert.ToDouble(r["Travel"]),
                                Convert.ToDouble(r["Study"]),
                                Convert.ToDouble(r["Shopping"]),
                                Convert.ToDouble(r["Health"]),
                                Convert.ToDouble(r["Others"])
                            );
                    }
                }
            }
            return (0, 0, 0, 0, 0, 0);
        }

        // ================= HISTORY =================
        public DataTable GetExpenseHistory(int userId)
        {
            string q = "SELECT * FROM Expenses WHERE UserId=@u ORDER BY Date DESC";
            return GetData(q, cmd =>
                cmd.Parameters.AddWithValue("@u", userId));
        }

        public DataTable GetIncomeHistory(int userId)
        {
            string q = "SELECT * FROM Income WHERE UserId=@u ORDER BY Date DESC";
            return GetData(q, cmd =>
                cmd.Parameters.AddWithValue("@u", userId));
        }

        // ================= CHART DATA =================
        public DataTable GetExpenseByCategory(int userId)
        {
            string q = @"SELECT Category, SUM(Amount) as Total
                         FROM Expenses
                         WHERE UserId=@u
                         GROUP BY Category";
            return GetData(q, cmd =>
                cmd.Parameters.AddWithValue("@u", userId));
        }
    }
}