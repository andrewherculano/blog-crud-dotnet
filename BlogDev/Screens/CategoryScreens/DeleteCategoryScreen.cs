using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Excluir Categoria **\n");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            CategoryScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("\nCategoria exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}