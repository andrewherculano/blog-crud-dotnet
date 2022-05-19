using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Incluir tag **\n");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var tag = new Tag(name, slug);
            Create(tag);

            Console.ReadKey();
            TagScreen.Load();
        }

        private static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("\nTag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível salvar os dados!");
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}