using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ClientService : IClientService<Client>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public ClientService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerator<Client> all()
        {
            return this._repositoryWrapper.ClientsRepository.All().GetEnumerator();
        }

        public bool create(Client entity)
        {
            this._repositoryWrapper.ClientsRepository.Create(entity);
            return true;
        }

        public Client read(int id)
        {
            return this._repositoryWrapper.ClientsRepository.Get(id);
        }

        public bool update(Client entity)
        { 
            this._repositoryWrapper.ClientsRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.ClientsRepository.Delete(id);
            return true;
        }
    }
}