using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Categorias **\n");
            ReadAll();
            Console.ReadKey();
            CategoryScreen.Load();
        }

        private static void ReadAll()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.GetAll();

            foreach (var category in categories)
                Console.WriteLine($"{category.Id} - {category.Name}");
        }
    }
}