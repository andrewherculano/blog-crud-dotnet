using System;
using BlogDev.Screens.CategoryScreens;
using BlogDev.Screens.PostScreens;
using BlogDev.Screens.RoleScreens;
using BlogDev.Screens.TagScreens;
using BlogDev.Screens.UserScreens;

namespace BlogDev.Screens
{
    public static class MenuScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("** Blog **");

            Console.WriteLine("O que deseja fazer?\n");

            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Gestão de post");

            Console.Write("\nEscolha a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UserScreen.Load();
                    break;
                case 2:
                    RoleScreen.Load();
                    break;
                case 3:
                    CategoryScreen.Load();
                    break;
                case 4:
                    TagScreen.Load();
                    break;
                case 5:
                    PostScreen.Load();
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
        }
    }
}