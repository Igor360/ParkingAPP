using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class CarsRepository : AbstractRepository<Cars>, ICarsRepository
    {
        public CarsRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}