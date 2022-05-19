using System;
using BlogDev.Screens.TagScreens;
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

            Load();

            Database.Connection.Close();
        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("** Blog **");

            Console.WriteLine("O que deseja fazer?\n");

            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de Perfil");
            Console.WriteLine("3 - Gestão de Categoria");
            Console.WriteLine("4 - Gestão de Tag");

            Console.Write("\nEscolha a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    TagScreen.Load();
                    break;
                case 4:
                    TagScreen.Load();
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
        }
    }
}
