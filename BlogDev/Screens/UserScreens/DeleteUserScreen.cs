using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Excluir usuário **\n");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.ReadKey();
            UserScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("\nUsuário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}