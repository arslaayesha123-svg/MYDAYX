using System;
using System.Windows.Forms;
using MyDayX.Database;

namespace MyDayX
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            MyDatabase.InitializeDatabase();
            Application.Run(new Login());
        }
    }
}