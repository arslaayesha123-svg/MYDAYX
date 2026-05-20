using System;
using System.Data;

namespace MyDayX.Database
{
    public class ReportRepository : BaseRepository
    {
        public double GetTotalExpense(int userId)
        {
            string q = "SELECT IFNULL(SUM(Amount),0) FROM Expenses WHERE UserId=@u";

            return Convert.ToDouble(Scalar(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
            }));
        }

        public double GetTotalIncome(int userId)
        {
            string q = "SELECT IFNULL(SUM(Amount),0) FROM Income WHERE UserId=@u";

            return Convert.ToDouble(Scalar(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
            }));
        }

        public int GetCompletedTasks(int userId)
        {
            string q = "SELECT COUNT(*) FROM Tasks WHERE UserId=@u AND IsDone=1";

            return Convert.ToInt32(Scalar(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
            }));
        }
        public DataTable GetExpenseByCategory(int userId)
        {
            string q = @"SELECT Category, SUM(Amount) as Total
                 FROM Expenses
                 WHERE UserId=@u
                 GROUP BY Category";

            return GetData(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
            });
        }

        public int GetTotalTasks(int userId)
        {
            string q = "SELECT COUNT(*) FROM Tasks WHERE UserId=@u";

            return Convert.ToInt32(Scalar(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
            }));
        }

        public DataTable GetHistory(int userId)
        {
            string q = @"SELECT 'Expense' AS Type, Amount, Date FROM Expenses WHERE UserId=@u
                         UNION ALL
                         SELECT 'Income', Amount, Date FROM Income WHERE UserId=@u
                         ORDER BY Date DESC";

            return GetData(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
            });
        }
    }
}