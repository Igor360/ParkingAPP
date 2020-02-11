using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using MySql.Data.MySqlClient;
using WebApplication1.Models;

namespace WebApplication1.Repository.Base
{
    public abstract class AbstractRepositoryAdo<TEntity> : IRepositoryAdo<TEntity>
    {

        private readonly MySqlConnection _connection;

        public AbstractRepositoryAdo()
        {
//            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var _connectionString = "Server=database;Port=3306;Database=parking_db;User=root;Password=";
            _connection =  new MySqlConnection(_connectionString);
        }

        public int Insert(TEntity entity)
        {
            int i = 0;
            using (var cmd = _connection.CreateCommand())
            {
                InsertCommand(entity, cmd);
                _connection.Open();
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
                _connection.Open();
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
                _connection.Open();
                i = cmd.ExecuteNonQuery();
            }

            return i;
        }

        public IEnumerable<TEntity> All()
        {
            using (var cmd = _connection.CreateCommand())
            {
                _connection.Open();
                AllCommand(cmd);
                using (MySqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    return Maps(sqlDataReader);
                }
            }
        }
        
        public TEntity Get(int id)
        {
            using (var cmd = _connection.CreateCommand())
            {
                _connection.Open();
                GetCommand(id, cmd);
                using (MySqlDataReader sqlDataReader = cmd.ExecuteReader())
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

        protected abstract void InsertCommand(TEntity entity, MySqlCommand cmd);
        protected abstract void UpdateCommand(TEntity entity, MySqlCommand cmd);
        protected abstract void DeleteCommand(int id, MySqlCommand cmd);

        protected abstract void AllCommand(MySqlCommand cmd);
        
        protected abstract void GetCommand(int id, MySqlCommand cmd);
        
        protected abstract TEntity Map(MySqlDataReader reader);
        protected abstract List<TEntity> Maps(MySqlDataReader reader);
    }
}