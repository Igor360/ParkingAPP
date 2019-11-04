using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CarService : ICarService
    {

        private readonly IRepositoryWrapper _repositoryWrapper;

        public CarService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<Car> all()
        {
            return this._repositoryWrapper.CarRepository.All().AsEnumerable();
        }

        public bool create(Car entity)
        {
            this._repositoryWrapper.CarRepository.Create(entity);
            return true;
        }

        public Car read(int id)
        {
            return this._repositoryWrapper.CarRepository.Get(id);
        }

        public bool update(Car entity)
        {
            this._repositoryWrapper.CarRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.CarRepository.Delete(id);
            return true;
        }
    }
}