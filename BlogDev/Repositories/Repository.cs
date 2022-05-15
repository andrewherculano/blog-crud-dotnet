using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogDev.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        private readonly SqlConnection _sqlConnection;

        public Repository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public IEnumerable<TModel> GetAll()
        {
            return _sqlConnection.GetAll<TModel>();
        }
    }
}