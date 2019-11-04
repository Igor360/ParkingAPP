using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class ParkingRepository : AbstractRepository<Parking>, IParkingRepository
    {
        public ParkingRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}