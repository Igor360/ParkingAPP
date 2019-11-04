using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Services
{
    public class CompanyParkingService : ICompanyParkingService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CompanyParkingService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<CompanyParking> all()
        {
            return this._repositoryWrapper.CompanyParkingRepository.All().AsEnumerable();
        }

        public bool create(CompanyParking entity)
        {
            this._repositoryWrapper.CompanyParkingRepository.Create(entity);
            return true;
        }

        public CompanyParking read(int id)
        {
            return this._repositoryWrapper.CompanyParkingRepository.Get(id);
        }

        public bool update(CompanyParking entity)
        {
            this._repositoryWrapper.CompanyParkingRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.CompanyParkingRepository.Delete(id);
            return true;
        }
    }
}