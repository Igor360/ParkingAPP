using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication1.Contexts;

namespace WebApplication1.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private DbConnection _connection;

        private ParkingADOContext _parkingAdoContext;

        public ValuesController(DbConnection connection, IConfiguration _configuration)
        {
            _connection = connection;
            _parkingAdoContext = new ParkingADOContext(_configuration);
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM users";
                using (var reader = cmd.ExecuteReader())
                {
                    var result = new List<string>();
                    while (reader.Read())
                    {
                        var objValue = reader.GetValue(0);
                        result.Add(objValue as string);
                    }

                    return result;
                }
            }
        }

        [HttpGet("/test")]
        public ActionResult<string> GetUsers()
        {
            return _parkingAdoContext.findAllUsers();
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM users WHERE id = @id";
                var idParam = cmd.CreateParameter();
                idParam.ParameterName = "id";
                idParam.Value = id;

                cmd.Parameters.Add(idParam);
                
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var objValue = reader.GetValue(0);
                        return new JsonResult(objValue as string);
                    }
                    else // zero rows
                    {
                        return  new JsonResult(null);
                    }
                }
            }
        }

        // POST api/values
        [HttpPost]
        public async Task<int> Post([FromBody] string value)
        {
            using (DbCommand cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO users (name) VALUES (@p) RETURNING id";
                var parameter = cmd.CreateParameter();
                parameter.ParameterName = "p";
                parameter.Value = value;

                cmd.Parameters.Add(parameter);
                using (var reader = cmd.ExecuteReader())
                {
                    await reader.ReadAsync();
                    return reader.GetInt32(0);
                }
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            using (DbCommand cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "UPDATE users set name=@p WHERE id=@id";
                var parameter = cmd.CreateParameter();
                parameter.ParameterName = "p";
                parameter.Value = value;
                
                var idParam = cmd.CreateParameter();
                idParam.ParameterName = "id";
                idParam.Value = id;

                cmd.Parameters.Add(idParam);

                cmd.Parameters.Add(parameter);


                cmd.ExecuteNonQuery();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (DbCommand cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "DELETE from users WHERE id=@id";
                
                var idParam = cmd.CreateParameter();
                idParam.ParameterName = "id";
                idParam.Value = id;

                cmd.Parameters.Add(idParam);

                cmd.ExecuteNonQuery();
            }
        }
    }
}