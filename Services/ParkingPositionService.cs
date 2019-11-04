using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Services
{
    public class ParkingPositionService : IParkingPositionService<ParkingPosition>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public ParkingPositionService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public bool create(ParkingPosition entity)
        {
            this._repositoryWrapper.ParkingPositionRepository.Create(entity);
            return true;
        }

        public ParkingPosition read(int id)
        {
            return this._repositoryWrapper.ParkingPositionRepository.Get(id);
        }

        public bool update(ParkingPosition entity)
        {
            this._repositoryWrapper.ParkingPositionRepository.Update(entity);
            return true;
        }

        public bool delete(int id)
        {
            this._repositoryWrapper.ParkingPositionRepository.Delete(id);
            return true;
        }
    }
}