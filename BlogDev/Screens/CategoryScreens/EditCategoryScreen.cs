using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.CategoryScreens
{
    public static class EditCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Editar Categoria **\n");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Edit(new Category
            {
                Id = id,
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            CategoryScreen.Load();
        }

        private static void Edit(Category category)
        {
            try
            {
                if (string.IsNullOrEmpty(category.Name) || string.IsNullOrEmpty(category.Slug))
                {
                    throw new Exception("Não é possivel salvar valores nulos ou vazios.");
                }

                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine("\nCategoria atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}