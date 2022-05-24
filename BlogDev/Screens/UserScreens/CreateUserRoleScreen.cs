using System;
using BlogDev.Repositories;

namespace BlogDev.Screens.UserScreens
{
    public static class CreateUserRole
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("** Perfil do usuário **\n");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Listar usuários e perfis");
            Console.WriteLine("2 - Vincular um usuário à um perfil");
            Console.WriteLine("0 - Voltar para gestão de usuários\n");

            Console.Write("Escolha a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUsersWithRoles();
                    break;
                case 2:
                    LinkUserRole();
                    break;
                case 0:
                    UserScreen.Load();
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }

            Console.ReadKey();
            UserScreen.Load();
        }

        private static void LinkUserRole()
        {
            Console.Clear();

            Console.WriteLine("** Vincular perfil usuário **\n");

            Console.Write("Id usuário: ");
            int userId = int.Parse(Console.ReadLine());

            Console.Write("Id perfil: ");
            int roleId = int.Parse(Console.ReadLine());

            CreateUserWithRole(userId, roleId);
            Console.ReadKey();
            UserScreen.Load();
        }

        private static void CreateUserWithRole(int userId, int roleId)
        {
            try
            {
                var repository = new UserRepository(Database.Connection);
                repository.CreateWithRole(userId, roleId);

                Console.WriteLine("Usuário vinculado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ListUsersWithRoles()
        {
            Console.Clear();

            try
            {
                var repository = new UserRepository(Database.Connection);
                var usersWithRoles = repository.GetWithRoles();

                foreach (var user in usersWithRoles)
                {
                    Console.WriteLine($"{user.Name}");
                    foreach (var role in user.Roles)
                    {
                        Console.WriteLine($"    -{role.Name}");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}