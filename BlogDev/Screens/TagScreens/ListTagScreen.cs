using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Tags **\n");
            ReadAll();
            Console.ReadKey();
            TagScreen.Load();
        }

        private static void ReadAll()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.GetAll();

            foreach (var tag in tags)
                Console.WriteLine($"{tag.Id} - {tag.Name}");
        }
    }
}