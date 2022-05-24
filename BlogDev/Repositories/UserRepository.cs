using System.Collections.Generic;
using System.Data;
using System.Linq;
using BlogDev.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BlogDev.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _sqlConnection;

        public UserRepository(SqlConnection sqlConnection)
            : base(sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void CreateWithRole(int userId, int roleId)
        {
            var user = new User();
            var role = new Role();

            user.Id = userId;
            role.Id = roleId;

            var query = @"INSERT INTO [UserRole] VALUES(@UserId, @RoleId)";

            var parameters = new DynamicParameters();
            parameters.Add("UserId", user.Id, DbType.Int32);
            parameters.Add("RoleId", role.Id, DbType.Int32);

            _sqlConnection.Execute(query, parameters);
        }

        public List<User> GetWithRoles()
        {
            var query = @"
                SELECT [User].*, [Role].*
                FROM [User]
                    INNER JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                    INNER JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";

            var users = new List<User>();

            var items = _sqlConnection.Query<User, Role, User>(
                query,
                (user, role) =>
                {
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if (usr == null)
                    {
                        usr = user;

                        if (role != null)
                            usr.Roles.Add(role);

                        users.Add(usr);
                    }
                    else
                    {
                        usr.Roles.Add(role);
                    }

                    return user;
                }, splitOn: "Id"
            );

            return users;
        }
    }
}