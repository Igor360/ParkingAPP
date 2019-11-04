using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MySqlX.XDevAPI;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Services
{
    public class ParkingService : IParkingService
    {

        private readonly IRepositoryWrapper _repositoryWrapper;

        public ParkingService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<Parking> all()
        {
            return this._repositoryWrapper.ParkingRepository.All().AsEnumerable();
        }

        public bool create(Parking entity)
        {
            this._repositoryWrapper.ParkingRepository.Create(entity);
            return true;
        }

        public Parking read(int id)
        {
            return this._repositoryWrapper.ParkingRepository.Get(id);
        }

        public bool update(Parking entity)
        {
            this._repositoryWrapper.ParkingRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.ParkingRepository.Delete(id);
            return true;
        }
    }
}