using System;
using System.IO;
using System.Windows.Forms;

namespace HR_Management
{
    internal static class Program
    {
        public static string pathUsers = Path.Combine(Environment.CurrentDirectory, "Users");
        public static string pathEmployes = Path.Combine(Environment.CurrentDirectory, "Employes");
        public static string passwordHashKey = "modestprogrammer";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindowForm());
        }
    }
}
