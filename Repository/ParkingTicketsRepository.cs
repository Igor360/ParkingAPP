using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class ParkingTicketsRepository : AbstractRepository<ParkingTicket>, IParkingTicketsRepository
    {
        public ParkingTicketsRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}