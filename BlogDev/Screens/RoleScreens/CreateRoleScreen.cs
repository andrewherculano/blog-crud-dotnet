using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Incluir Perfil **\n");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role
            {
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            RoleScreen.Load();
        }

        private static void Create(Role role)
        {
            try
            {
                if (string.IsNullOrEmpty(role.Name) || string.IsNullOrEmpty(role.Slug))
                {
                    throw new Exception("Não é possivel salvar valores nulos ou vazios.");
                }

                var repository = new Repository<Role>(Database.Connection);
                repository.Create(role);
                Console.WriteLine("\nPerfil cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }
    }
}