using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Perfis **\n");
            ReadAll();
            Console.ReadKey();
            RoleScreen.Load();
        }

        private static void ReadAll()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.GetAll();

            foreach (var role in roles)
                Console.WriteLine($"{role.Id} - {role.Name}");
        }
    }
}