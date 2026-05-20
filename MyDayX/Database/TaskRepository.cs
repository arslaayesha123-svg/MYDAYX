using System;
using System.Data;

namespace MyDayX.Database
{
    public class TaskRepository : BaseRepository
    {
        public void AddTask(int userId, string title)
        {
            string q = @"INSERT INTO Tasks 
                        (UserId, Title, IsDone, Date)
                        VALUES (@u,@t,0,@d)";

            Execute(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@t", title);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);
            });
        }

        public void MarkDone(int taskId)
        {
            string q = "UPDATE Tasks SET IsDone=1 WHERE Id=@id";

            Execute(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@id", taskId);
            });
        }

        public DataTable GetTasks(int userId)
        {
            string q = "SELECT * FROM Tasks WHERE UserId=@u ORDER BY Date DESC";

            return GetData(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", userId);
            });
        }
    }
}