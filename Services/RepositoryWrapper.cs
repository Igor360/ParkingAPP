using System.Threading.Channels;
using WebApplication1.Contexts;
using WebApplication1.Repository;

namespace WebApplication1.Services
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ParkingContext _parkingContext;
        private IClientRepository _clientRepository;
        private ICarRepository _carRepository;
        private ICarsRepository _carsRepository;
        private ICompanyRepository _companyRepository;
        private ICompanyParkingRepository _companyParkingRepository;
        private IParkingPositionRepository _parkingPositionRepository;
        private IParkingRepository _parkingRepository;
        private IParkingTicketsRepository _parkingTicketsRepository;
        private IUserRepository _userRepository;
        private IParkingPricingRepository _parkingPricingRepository;

        public RepositoryWrapper(ParkingContext parkingContext)
        {
            this._parkingContext = parkingContext;
        }

        public IClientRepository ClientsRepository
        {
            get { return _clientRepository ?? (_clientRepository = new ClientRepository(this._parkingContext)); }
        }

        public ICarRepository CarRepository
        {
            get { return _carRepository ?? (_carRepository = new CarRepository(this._parkingContext)); }
        }

        public ICarsRepository CarsRepository
        {
            get { return _carsRepository ?? (_carsRepository = new CarsRepository(this._parkingContext)); }
        }

        public ICompanyRepository CompanyRepository
        {
            get { return _companyRepository ?? (_companyRepository = new CompanyRepository(this._parkingContext)); }
        }

        public ICompanyParkingRepository CompanyParkingRepository
        {
            get
            {
                return _companyParkingRepository ??
                       (_companyParkingRepository = new CompanyParkingRepository(this._parkingContext));
            }
        }

        public IParkingPositionRepository ParkingPositionRepository
        {
            get
            {
                return _parkingPositionRepository ??
                       (_parkingPositionRepository = new ParkingPositionRepository(this._parkingContext));
            }
        }

        public IParkingRepository ParkingRepository
        {
            get { return _parkingRepository ?? (_parkingRepository = new ParkingRepository(this._parkingContext)); }
        }

        public IParkingTicketsRepository ParkingTicketsRepository
        {
            get
            {
                return _parkingTicketsRepository ??
                       (_parkingTicketsRepository = new ParkingTicketsRepository(this._parkingContext));
            }
        }

        public IUserRepository UserRepository {
            get { return _userRepository ?? (_userRepository = new UserRepository(this._parkingContext)); }
        }

        public IParkingPricingRepository ParkingPricingRepository
        {
            get
            {
                return _parkingPricingRepository ??
                       (_parkingPricingRepository = new ParkingPricingRepository(this._parkingContext));
            }
        }

        public void Save()
        {
            this._parkingContext.SaveChanges();
        }
    }
}