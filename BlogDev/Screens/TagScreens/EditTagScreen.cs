using System;
using BlogDev.Models;
using BlogDev.Repositories;

namespace BlogDev.Screens.TagScreens
{
    public static class EditTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Editar tag **\n");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Edit(new Tag
            {
                Id = id,
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            TagScreen.Load();
        }

        private static void Edit(Tag tag)
        {
            try
            {
                if (string.IsNullOrEmpty(tag.Name) || string.IsNullOrEmpty(tag.Slug))
                {
                    throw new Exception("Não é possivel salvar valores nulos ou vazios.");
                }

                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("\nTag atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}