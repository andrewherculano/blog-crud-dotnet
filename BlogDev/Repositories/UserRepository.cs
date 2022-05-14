using System;
using System.Collections.Generic;
using BlogDev.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogDev.Repositories
{
    public class UserRepository
    {
        private readonly SqlConnection _sqlConnection;

        public UserRepository(SqlConnection sqlConnetion)
        {
            _sqlConnection = sqlConnetion;
        }

        public IEnumerable<User> GetAll()
        {
            return _sqlConnection.GetAll<User>();
        }

        public User Get(int id)
        {
            return _sqlConnection.Get<User>(id);
        }

        public void Create(User user)
        {
            _sqlConnection.Insert<User>(user);
        }
    }
}