using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MySqlX.XDevAPI;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Services
{
    public class ParkingPricingService : IParkingPricingService
    {

        private readonly IRepositoryWrapper _repositoryWrapper;

        public ParkingPricingService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<ParkingPricing> all()
        {
            return this._repositoryWrapper.ParkingPricingRepository.All().AsEnumerable();
        }

        public bool create(ParkingPricing entity)
        {
            this._repositoryWrapper.ParkingPricingRepository.Create(entity);
            return true;
        }

        public ParkingPricing read(int id)
        {
            return this._repositoryWrapper.ParkingPricingRepository.Get(id);
        }

        public bool update(ParkingPricing entity)
        {
            this._repositoryWrapper.ParkingPricingRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.ParkingPricingRepository.Delete(id);
            return true;
        }
    }
}