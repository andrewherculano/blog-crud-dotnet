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
            // ReadUser(sqlConnection);
            // CreateUser(sqlConnection);
            // UpdateUser();
            // DeleteUser();
            sqlConnection.Close();
        }

        static void ReadUsers(SqlConnection sqlConnection)
        {
            var userRepository = new UserRepository(sqlConnection);
            var users = userRepository.GetAll();

            foreach (var user in users)
                Console.WriteLine(user.Name);
        }

        static void ReadUser(SqlConnection sqlConnection)
        {
            var userRepository = new UserRepository(sqlConnection);
            var user = userRepository.Get(2);

            Console.WriteLine(user.Name);
        }

        static void CreateUser(SqlConnection sqlConnection)
        {
            var user = new User()
            {
                Name = "Ermione G.",
                Email = "de@senior.com.br",
                PasswordHash = "HASH",
                Bio = "Dev Senior",
                Image = "http://img.com",
                Slug = "dev-senior"
            };

            var userRepository = new UserRepository(sqlConnection);
            userRepository.Create(user);
            Console.WriteLine("Usuário cadastrado com sucesso.");
        }

        static void UpdateUser()
        {
            var userUpdate = new User()
            {
                Id = 1002,
                Name = "Hermione Granger",
                Email = "hermione@gg.com.br",
                PasswordHash = "HASH",
                Bio = "Dev Senior",
                Image = "http://img.com",
                Slug = "dev-senior"
            };

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Update<User>(userUpdate);
                Console.WriteLine($"Usuário atualizado com sucesso!");
            }
        }

        static void DeleteUser()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var user = connection.Get<User>(1002);
                connection.Delete<User>(user);

                Console.WriteLine($"Usuário {user.Name} deletedo com sucesso!");
            }
        }
    }
}
