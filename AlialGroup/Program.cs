using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlialGroup
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        internal static string MSSQLRequest(string request)
        {
            string connStr = "server=GLADOSS;Integrated Security=true;database=TestTask;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand command = new SqlCommand(request, conn);
            SqlDataReader reader = command.ExecuteReader();
            string responce = string.Empty;
            while (reader.Read())
            {
                responce = responce + reader[0].ToString() + " " + reader[1].ToString() + System.Environment.NewLine;
             }
            reader.Close();
            conn.Close();
            return responce;
            
        }
    }
}
