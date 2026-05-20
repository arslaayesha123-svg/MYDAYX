using System;

namespace MyDayX.Database
{
    public class UserRepository : BaseRepository
    {
        public bool Register(string email, string username, string password)
        {
            string q = "INSERT INTO Users (Email, Username, Password) VALUES (@e, @u, @p)";
            return Execute(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
            }) > 0;
        }

        public bool Login(string username, string password)
        {
            string q = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p";
            int count = Convert.ToInt32(Scalar(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
            }));
            return count > 0;
        }

        public int GetUserId(string username)
        {
            string q = "SELECT Id FROM Users WHERE Username=@u";
            return Convert.ToInt32(Scalar(q, cmd =>
            {
                cmd.Parameters.AddWithValue("@u", username);
            }));
        }
    }
}