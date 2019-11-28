using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class ParkingPricingRepository : AbstractRepository<ParkingPricing>, IParkingPricingRepository
    {
        public ParkingPricingRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}