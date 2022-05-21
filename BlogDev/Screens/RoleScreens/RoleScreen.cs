using System;

namespace BlogDev.Screens.RoleScreens
{
    public static class RoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("** Gestão de Perfil **\n");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Listar perfis");
            Console.WriteLine("2 - Cadastrar uma perfil");
            Console.WriteLine("3 - Editar uma perfil");
            Console.WriteLine("4 - Excluir uma perfil");
            Console.WriteLine("0 - Voltar para o menu principal\n");

            Console.Write("Escolha a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListRoleScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    EditRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
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