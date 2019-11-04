using System.Collections.Generic;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Services
{
    public class CompanyParkingService : ICompanyParkingService<CompanyParking>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CompanyParkingService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerator<CompanyParking> all()
        {
            return this._repositoryWrapper.CompanyParkingRepository.All().GetEnumerator();
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