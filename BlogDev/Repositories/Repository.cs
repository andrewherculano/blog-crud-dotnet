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

        public TModel Get(int id)
        {
            return _sqlConnection.Get<TModel>(id);
        }

        public void Create(TModel model)
        {
            _sqlConnection.Insert<TModel>(model);
        }

        public void Update(TModel model)
        {
            _sqlConnection.Update<TModel>(model);
        }

        public void Delete(TModel model)
        {
            _sqlConnection.Delete<TModel>(model);
        }

        public void Delete(int id)
        {
            var model = _sqlConnection.Get<TModel>(id);
            _sqlConnection.Delete<TModel>(model);
        }
    }
}