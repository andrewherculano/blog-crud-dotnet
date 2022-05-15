using System;
using BlogDev.Models;
using BlogDev.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogDev
{
    class Program
    {
        private const string _connectionString = "Server=localhost,1433;Database=BlogDev;User ID=sa;Password=a1s2d3@!;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("** Blog **\n");

            var sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            ReadUsers(sqlConnection);
            Console.WriteLine();
            ReadRoles(sqlConnection);
            sqlConnection.Close();
        }

        static void ReadUsers(SqlConnection sqlConnection)
        {
            var userRepository = new Repository<User>(sqlConnection);
            var users = userRepository.GetAll();

            foreach (var user in users)
                Console.WriteLine(user.Name);
        }

        static void ReadRoles(SqlConnection sqlConnection)
        {
            var roleRepository = new Repository<Role>(sqlConnection);
            var roles = roleRepository.GetAll();

            foreach (var role in roles)
                Console.WriteLine($"{role.Id} - {role.Name}");
        }
    }
}
