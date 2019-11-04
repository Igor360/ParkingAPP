using WebApplication1.Repository;

namespace WebApplication1.Services
{
    public interface IRepositoryWrapper
    {
        IClientRepository ClientsRepository { get; }

        ICarRepository CarRepository { get; }

        ICarsRepository CarsRepository { get; }

        ICompanyRepository CompanyRepository { get; }

        ICompanyParkingRepository CompanyParkingRepository { get; }

        IParkingPositionRepository ParkingPositionRepository { get; }

        IParkingRepository ParkingRepository { get; }

        IParkingTicketsRepository ParkingTicketsRepository { get; }

        IUserRepository UserRepository { get; }

        void Save();
    }
}