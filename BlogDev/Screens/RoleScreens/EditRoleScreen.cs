using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.RoleScreens
{
    public static class EditRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Editar Perfil **\n");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Edit(new Role
            {
                Id = id,
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            RoleScreen.Load();
        }

        private static void Edit(Role role)
        {
            try
            {
                if (string.IsNullOrEmpty(role.Name) || string.IsNullOrEmpty(role.Slug))
                {
                    throw new Exception("Não é possivel salvar valores nulos ou vazios.");
                }

                var repository = new Repository<Role>(Database.Connection);
                repository.Update(role);
                Console.WriteLine("\nPerfil atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}