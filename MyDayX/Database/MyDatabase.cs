using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace MyDayX.Database
{
    public class MyDatabase
    {
        private static string dbPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "MyDatabase.db");
        private static string connectionString =
            $"Data Source={dbPath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                new SQLiteCommand("PRAGMA foreign_keys = ON;", conn).ExecuteNonQuery();

                string users = @"CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Email TEXT NOT NULL UNIQUE,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL
                );";

                string tasks = @"CREATE TABLE IF NOT EXISTS Tasks (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Title TEXT NOT NULL,
                    IsDone INTEGER DEFAULT 0,
                    Date TEXT,
                    FOREIGN KEY (UserId) REFERENCES Users(Id)
                );";

                string income = @"CREATE TABLE IF NOT EXISTS Income (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Amount REAL NOT NULL,
                    Category TEXT,
                    Date TEXT
                );";

                string expenses = @"CREATE TABLE IF NOT EXISTS Expenses (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Amount REAL NOT NULL,
                    Category TEXT,
                    Date TEXT
                );";

                string budget = @"CREATE TABLE IF NOT EXISTS Budget (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER,
                    LimitAmount REAL
                );";

                new SQLiteCommand(users, conn).ExecuteNonQuery();
                new SQLiteCommand(tasks, conn).ExecuteNonQuery();
                new SQLiteCommand(income, conn).ExecuteNonQuery();
                new SQLiteCommand(expenses, conn).ExecuteNonQuery();
                new SQLiteCommand(budget, conn).ExecuteNonQuery();

                // Budget columns add karo automatically
                TryAlter(conn, "ALTER TABLE Budget ADD COLUMN Food REAL DEFAULT 0");
                TryAlter(conn, "ALTER TABLE Budget ADD COLUMN Travel REAL DEFAULT 0");
                TryAlter(conn, "ALTER TABLE Budget ADD COLUMN Study REAL DEFAULT 0");
                TryAlter(conn, "ALTER TABLE Budget ADD COLUMN Shopping REAL DEFAULT 0");
                TryAlter(conn, "ALTER TABLE Budget ADD COLUMN Health REAL DEFAULT 0");
                TryAlter(conn, "ALTER TABLE Budget ADD COLUMN Others REAL DEFAULT 0");

                TryAlter(conn, "ALTER TABLE Income ADD COLUMN Category TEXT;");
                TryAlter(conn, "ALTER TABLE Expenses ADD COLUMN Category TEXT;");
            }
        }

        private static void TryAlter(SQLiteConnection conn, string query)
        {
            try { new SQLiteCommand(query, conn).ExecuteNonQuery(); }
            catch { }
        }
    }
}