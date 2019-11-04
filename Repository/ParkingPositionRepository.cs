using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class ParkingPositionRepository : AbstractRepository<ParkingPosition>, IParkingPositionRepository
    {
        public ParkingPositionRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}