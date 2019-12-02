using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplication1.Models;
using WebApplication1.Models.Enums;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository.ADO
{
    public class CarRepository : AbstractRepositoryAdo<Car>, ICarRepository
    {
        protected override void InsertCommand(Car entity, SqlCommand cmd)
        {
            cmd.CommandText = "insert into car (name, type, code) values (@name, @type, @code) RETURNING id";
            SqlParameter[] parameterCollections =
            {
                new SqlParameter("name", entity.name),
                new SqlParameter("code", entity.code),
                new SqlParameter("type", entity.carType),
            };
            cmd.Parameters.Add(parameterCollections);
        }

        protected override void UpdateCommand(Car entity, SqlCommand cmd)
        {
            cmd.CommandText = "update users set name = @Name, code = @Code, type = @Type  where id = @Id RETURNING id";
            SqlParameter[] parameterCollections =
            {
                new SqlParameter("Name", entity.name),
                new SqlParameter("Code", entity.code),
                new SqlParameter("Type", entity.carType),
                new SqlParameter("Id", entity.id)
            };
            addParametersToCollection(parameterCollections, cmd);
        }

        protected override void DeleteCommand(int id, SqlCommand cmd)
        {
            cmd.CommandText = "delete from users where id = @id RETURNING id";
            SqlParameter parameterCollections = new SqlParameter("id", id);
            cmd.Parameters.Add(parameterCollections);
        }

        protected override Car Map(SqlDataReader reader)
        {
            if (reader.HasRows)
            {
                reader.Read();
                Car car = new Car();
                car.id = (int) reader.GetValue(0);
                car.name = (string) reader.GetValue(1);
                car.code = (string) reader.GetValue(2);
                car.carType = Enum.Parse<CarTypes>((string) reader.GetValue(3), true);
                return car;
            }
            reader.Close();
            return null;
        }

        protected override List<Car> Maps(SqlDataReader reader)
        {
            List<Car> cars = new List<Car>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Car car = new Car();
                    car.id = (int) reader.GetValue(0);
                    car.name = (string) reader.GetValue(1);
                    car.code = (string) reader.GetValue(2);
                    car.carType = Enum.Parse<CarTypes>((string) reader.GetValue(3), true);
                    cars.Add(car);
                }
            }

            reader.Close();
            return cars;
        }

        protected override void AllCommand(SqlCommand cmd)
        {
            cmd.CommandText = "SELECT id, name, code, type FROM car";
        }

        protected override void GetCommand(int id, SqlCommand cmd)
        {
            cmd.CommandText = "SELECT id, name, code, type FROM car where  id = @Id";
            cmd.Parameters.Add(new SqlParameter("Id", id));
        }

        private void addParametersToCollection(SqlParameter[] parameters, SqlCommand cmd)
        {
            foreach (SqlParameter p in parameters)
            {
                cmd.Parameters.Add(p);
            }
        }
    }
}