using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CarsService : ICarsService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CarsService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<Cars> all()
        {
            return this._repositoryWrapper.CarsRepository.All().AsEnumerable();
        }

        public bool create(Cars entity)
        {
            this._repositoryWrapper.CarsRepository.Create(entity);
            return true;
        }

        public Cars read(int id)
        {
            return this._repositoryWrapper.CarsRepository.Get(id);
        }

        public bool update(Cars entity)
        {
            this._repositoryWrapper.CarsRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.CarsRepository.Delete(id);
            return true;
        }
    }
}