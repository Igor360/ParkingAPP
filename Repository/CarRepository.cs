using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class CarRepository : AbstractRepository<Car>, ICarRepository
    {
        public CarRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}