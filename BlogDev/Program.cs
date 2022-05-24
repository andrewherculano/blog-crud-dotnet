using BlogDev.Screens;
using Microsoft.Data.SqlClient;

namespace BlogDev
{
    class Program
    {
        private const string _connectionString = "Server=localhost,1433;Database=BlogDev;User ID=sa;Password=a1s2d3@!;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(_connectionString);
            Database.Connection.Open();

            MenuScreen.Load();

            Database.Connection.Close();
        }
    }
} 
