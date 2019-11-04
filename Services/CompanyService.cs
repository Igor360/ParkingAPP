using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Services
{
    public class CompanyService : ICompanyService<Company>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CompanyService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public bool create(Company entity)
        {
            this._repositoryWrapper.CompanyRepository.Create(entity);
            return true;
        }

        public Company read(int id)
        {
            return this._repositoryWrapper.CompanyRepository.Get(id);
        }

        public bool update(Company entity)
        {
            this._repositoryWrapper.CompanyRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.CompanyRepository.Delete(id);
            return true;
        }
    }
}