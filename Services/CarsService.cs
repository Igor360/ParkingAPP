using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CarsService : ICarsService<Cars>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CarsService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerator<Cars> all()
        {
            return this._repositoryWrapper.CarsRepository.All().GetEnumerator();
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