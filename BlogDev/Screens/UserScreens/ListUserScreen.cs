using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Usuários **\n");
            ReadAll();
            Console.ReadKey();
            UserScreen.Load();
        }

        private static void ReadAll()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.GetAll();

            foreach (var user in users)
                Console.WriteLine($"{user.Id} - {user.Name}");
        }
    }
}