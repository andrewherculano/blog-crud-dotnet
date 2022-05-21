using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Incluir Categoria **\n");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            CategoryScreen.Load();
        }

        private static void Create(Category category)
        {
            try
            {
                if (string.IsNullOrEmpty(category.Name) || string.IsNullOrEmpty(category.Slug))
                {
                    throw new Exception("Não é possivel salvar valores nulos ou vazios.");
                }

                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                Console.WriteLine("\nCategoria cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }
    }
}