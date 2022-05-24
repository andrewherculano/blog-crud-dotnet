using System;

namespace BlogDev.Screens.PostScreens
{
    public static class PostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("** Gestão de Post **\n");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Listar posts");
            Console.WriteLine("2 - Cadastrar um post");
            Console.WriteLine("3 - Editar um post");
            Console.WriteLine("4 - Excluir um post");
            Console.WriteLine("0 - Voltar para o menu principal\n");

            Console.Write("Escolha a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListPostScreen.Load();
                    break;
                case 2:
                    CreatePostScreen.Load();
                    break;
                case 3:
                    EditPostScreen.Load();
                    break;
                case 4:
                    DeletePostScreen.Load();
                    break;
                case 0:
                    MenuScreen.Load();
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
        }
    }
}