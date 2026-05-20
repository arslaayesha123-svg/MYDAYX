using System;
using System.Data;
using System.Data.SQLite;

namespace MyDayX.Database
{
    public class BaseRepository
    {
        protected int Execute(string query, Action<SQLiteCommand> param = null)
        {
            using (var con = MyDatabase.GetConnection())
            {
                con.Open();

                using (var cmd = new SQLiteCommand(query, con))
                {
                    param?.Invoke(cmd);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        protected object Scalar(string query, Action<SQLiteCommand> param = null)
        {
            using (var con = MyDatabase.GetConnection())
            {
                con.Open();

                using (var cmd = new SQLiteCommand(query, con))
                {
                    param?.Invoke(cmd);
                    return cmd.ExecuteScalar();
                }
            }
        }

        protected DataTable GetData(string query, Action<SQLiteCommand> param = null)
        {
            using (var con = MyDatabase.GetConnection())
            {
                con.Open();

                using (var cmd = new SQLiteCommand(query, con))
                {
                    param?.Invoke(cmd);

                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }
    }
}