using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.PostScreens
{
    public static class EditPostScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Editar Post **\n");

            Console.Write("Id post: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Titulo: ");
            string title = Console.ReadLine();

            Console.Write("Slug: ");
            string slug = Console.ReadLine();

            Console.Write("Id da categoria: ");
            int categoryId = int.Parse(Console.ReadLine());

            Console.Write("Id do autor: ");
            int authorId = int.Parse(Console.ReadLine());

            Edit(new Post
            {
                Id = id,
                Title = title,
                Slug = slug,
                CategoryId = categoryId,
                AuthorId = authorId
            });

            Console.ReadKey();
            PostScreen.Load();
        }

        private static void Edit(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine("\nPost atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }
    }
}