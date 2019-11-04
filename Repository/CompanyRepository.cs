using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class CompanyRepository : AbstractRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}