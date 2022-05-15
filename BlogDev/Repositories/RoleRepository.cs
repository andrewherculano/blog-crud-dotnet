using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogDev.Repositories
{
    public class RoleRepository
    {
        private readonly SqlConnection _sqlConnection;

        public RoleRepository(SqlConnection sqlConnetion)
        {
            _sqlConnection = sqlConnetion;
        }

        public IEnumerable<Role> GetAll()
        {
            return _sqlConnection.GetAll<Role>();
        }

        public Role Get(int id)
        {
            return _sqlConnection.Get<Role>(id);
        }

        public void Create(Role role)
        {
            role.Id = 0;
            _sqlConnection.Insert<Role>(role);
        }

        public void Update(Role role)
        {
            if (role.Id != 0)
            {
                _sqlConnection.Update<Role>(role);
            }
        }

        public void Delete(Role role)
        {
            if (role.Id != 0)
            {
                _sqlConnection.Delete<Role>(role);
            }
        }

        public void Delete(int id)
        {
            if (id != 0)
                return;

            var role = _sqlConnection.Get<Role>(id);
            _sqlConnection.Delete<Role>(role);
        }
    }
}