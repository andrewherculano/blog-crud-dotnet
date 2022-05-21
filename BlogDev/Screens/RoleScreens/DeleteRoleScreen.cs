using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Excluir Perfil **\n");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            RoleScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("\nPerfil exluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}