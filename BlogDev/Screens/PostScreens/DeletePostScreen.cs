using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.PostScreens
{
    public static class DeletePostScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Excluir Post **\n");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            PostScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("\nPost exluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}