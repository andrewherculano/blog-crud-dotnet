using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.PostScreens
{
    public static class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Posts **\n");
            ReadAll();
            Console.ReadKey();
            PostScreen.Load();
        }

        private static void ReadAll()
        {
            var repository = new Repository<Post>(Database.Connection);
            var posts = repository.GetAll();

            foreach (var post in posts)
                Console.WriteLine($"{post.Id} - {post.Title}");
        }
    }
}