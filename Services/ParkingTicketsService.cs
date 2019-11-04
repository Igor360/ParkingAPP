using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ParkingTicketsService : IParkingTicketsService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public ParkingTicketsService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<ParkingTicket> all()
        {
            return this._repositoryWrapper.ParkingTicketsRepository.All().AsEnumerable();
        }

        public bool create(ParkingTicket entity)
        {
            this._repositoryWrapper.ParkingTicketsRepository.Create(entity);
            return true;
        }

        public ParkingTicket read(int id)
        {
            return this._repositoryWrapper.ParkingTicketsRepository.Get(id);
        }

        public bool update(ParkingTicket entity)
        {
            this._repositoryWrapper.ParkingTicketsRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.ParkingTicketsRepository.Delete(id);
            return true;
        }
    }
}