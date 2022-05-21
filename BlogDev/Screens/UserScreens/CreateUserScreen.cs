using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Cadastrar usuário **\n");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Bio: ");
            string bio = Console.ReadLine();

            Console.Write("Slug: ");
            string slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                Bio = bio,
                Slug = slug
            });

            Console.ReadKey();
            UserScreen.Load();
        }

        private static void Create(User user)
        {
            bool checkIsNullOrEmpity =
                string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Bio) || string.IsNullOrEmpty(user.Slug);

            try
            {
                if (checkIsNullOrEmpity)
                {
                    throw new Exception("Não é possivel salvar valores nulos ou vazios.");
                }

                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);

                Console.WriteLine("\nUsuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }
    }
}