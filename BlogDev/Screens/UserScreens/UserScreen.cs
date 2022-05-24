using System;

namespace BlogDev.Screens.UserScreens
{
    public static class UserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("** Gestão de Usuários **\n");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Cadastrar um usuário");
            Console.WriteLine("3 - Editar um usuário");
            Console.WriteLine("4 - Excluir um usuário");
            Console.WriteLine("5 - Perfil de usuário");
            Console.WriteLine("0 - Voltar para o menu principal\n");

            Console.Write("Escolha a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    EditUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                case 5:
                    CreateUserRole.Load();
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