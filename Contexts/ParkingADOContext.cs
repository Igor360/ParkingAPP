using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace WebApplication1.Contexts
{
    public class ParkingADOContext
    {
        private readonly IConfiguration _configuration;

        private MySqlConnection _connection;

        public ParkingADOContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private void Connect()
        {
            _connection = new MySqlConnection(_configuration.GetSection("ConnectionStrings")
                .GetSection("DefaultConnection").Value);
        }


        public JsonResult findAllUsers()
        {
            return ExecSql("SELECT * FROM user");
        }

        private JsonResult ExecSql(String query, params KeyValuePair<string, object>[] vars)
        {
            MySqlCommand mySqlQuery = _connection.CreateCommand();
            mySqlQuery.CommandText = query;
            foreach (var param in vars)
            {
                var parameter = mySqlQuery.CreateParameter();
                parameter.ParameterName = param.Key;
                parameter.Value = param.Value;
                mySqlQuery.Parameters.Add(parameter);
            }

            this._connection.Open();
            
            using (var reader = mySqlQuery.ExecuteReader())
            {
                if (reader.Read())
                {
                    var objValue = reader.GetValue(0);
                    return new JsonResult(objValue as string);
                }
                else
                {
                    return  new JsonResult(null);
                }
            }
        }
    }
}