using System;

namespace BlogDev.Screens.CategoryScreens
{
    public static class CategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("** Gestão de Categorias **\n");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Cadastrar uma categoria");
            Console.WriteLine("3 - Editar uma categoria");
            Console.WriteLine("4 - Excluir uma categoria");
            Console.WriteLine("0 - Voltar para o menu principal\n");

            Console.Write("Escolha a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    EditCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
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