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

            Console.WriteLine("** Excluir tag **\n");

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
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("\nTag atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível atualizar os dados!");
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}