using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.UserScreens
{
    public static class EditUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Editar usuário **\n");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Bio: ");
            string bio = Console.ReadLine();

            Console.Write("Slug: ");
            string slug = Console.ReadLine();

            Edit(new User
            {
                Id = id,
                Name = name,
                Email = email,
                Bio = bio,
                Slug = slug
            });

            Console.ReadKey();
            UserScreen.Load();
        }

        private static void Edit(User user)
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
                repository.Update(user);
                Console.WriteLine("\nUsuário atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}