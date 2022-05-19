using System;

namespace BlogDev.Screens.TagScreens
{
    public static class TagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("** Gestão de Tags **\n");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Cadastrar uma tag");
            Console.WriteLine("3 - Editar uma tag");
            Console.WriteLine("4 - Excluir uma tag");
            Console.WriteLine("0 - Voltar para o menu principal\n");

            Console.Write("Escolha a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    EditTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;
                case 0:
                    Program.Load();
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
        }
    }
}