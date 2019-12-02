using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.Repository.ADO;

namespace WebApplication1.Services
{
    public class CarService : ICarService
    {

        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Car> all()
        {
            return _repository.All();
        }

        public bool create(Car entity)
        {
            _repository.Insert(entity);
            return true;
        }

        public Car read(int id)
        {
            return _repository.Get(id);
        }

        public bool update(Car entity)
        {
            _repository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            _repository.Delete(id);
            return true;
        }
    }
}