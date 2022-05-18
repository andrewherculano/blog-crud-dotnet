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

            ReadUsersWithRoles(sqlConnection);

            sqlConnection.Close();
        }

        static void ReadUsersWithRoles(SqlConnection sqlConnection)
        {
            var userRepository = new UserRepository(sqlConnection);
            var users = userRepository.GetWithRoles();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
                foreach (var role in user.Roles)
                {
                    Console.WriteLine($" -{role.Name}");
                }
            }
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

        static void ReadTag(SqlConnection sqlConnection)
        {
            var tagRepository = new Repository<Tag>(sqlConnection);
            var tag = tagRepository.Get(1);

            Console.WriteLine($"{tag.Name} - {tag.Slug}");
        }
    }
}
