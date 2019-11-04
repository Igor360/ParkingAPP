using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class CompanyParkingRepository : AbstractRepository<CompanyParking>, ICompanyParkingRepository
    {
        public CompanyParkingRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}