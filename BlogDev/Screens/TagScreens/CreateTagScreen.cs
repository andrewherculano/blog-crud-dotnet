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

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            TagScreen.Load();
        }

        private static void Create(Tag tag)
        {
            try
            {
                if (string.IsNullOrEmpty(tag.Name) || string.IsNullOrEmpty(tag.Slug))
                {
                    throw new Exception("Não é possivel salvar valores nulos ou vazios.");
                }

                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("\nTag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }
    }
}