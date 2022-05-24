using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Incluir Post **\n");

            Console.Write("Titulo: ");
            string title = Console.ReadLine();

            Console.Write("Slug: ");
            string slug = Console.ReadLine();

            Console.Write("Id da categoria: ");
            int categoryId = int.Parse(Console.ReadLine());

            Console.Write("Id do autor: ");
            int authorId = int.Parse(Console.ReadLine());

            Create(new Post
            {
                Title = title,
                Slug = slug,
                CategoryId = categoryId,
                AuthorId = authorId
            });

            Console.ReadKey();
            PostScreen.Load();
        }

        private static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("\nPost cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }
    }
}