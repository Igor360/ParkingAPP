using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Repository.Base
{
    public abstract class AbstractRepositoryAdo<TEntity> : IRepositoryAdo<TEntity>
    {

        private readonly SqlConnection _connection;

        public AbstractRepositoryAdo()
        {
            var _connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            _connection =  new SqlConnection(_connectionString);
        }

        public int Insert(TEntity entity)
        {
            int i = 0;

            using (var cmd = _connection.CreateCommand())
            {
                InsertCommand(entity, cmd);
                i = cmd.ExecuteNonQuery();
            }

            return i; 
        }

        public int Update(TEntity entity)
        {
            int i = 0;

            using (var cmd = _connection.CreateCommand())
            {
                UpdateCommand(entity, cmd);
                i = cmd.ExecuteNonQuery();
            }

            return i;
        }

        public int Delete(int id)
        {
            int i = 0;
            using (var cmd = _connection.CreateCommand())
            {
                DeleteCommand(id, cmd);
                i = cmd.ExecuteNonQuery();
            }

            return i;
        }

        public IEnumerable<TEntity> All()
        {
            using (var cmd = _connection.CreateCommand())
            {
                AllCommand(cmd);
                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    return Maps(sqlDataReader);
                }
            }
        }
        
        public TEntity Get(int id)
        {
            using (var cmd = _connection.CreateCommand())
            {
                GetCommand(id, cmd);
                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    return Map(sqlDataReader);
                }
            }
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        protected abstract void InsertCommand(TEntity entity, SqlCommand cmd);
        protected abstract void UpdateCommand(TEntity entity, SqlCommand cmd);
        protected abstract void DeleteCommand(int id, SqlCommand cmd);

        protected abstract void AllCommand(SqlCommand cmd);
        
        protected abstract void GetCommand(int id, SqlCommand cmd);
        
        protected abstract TEntity Map(SqlDataReader reader);
        protected abstract List<TEntity> Maps(SqlDataReader reader);
    }
}