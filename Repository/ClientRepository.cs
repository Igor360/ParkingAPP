using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class ClientRepository : AbstractRepository<Client>, IClientRepository
    {
        public ClientRepository(ParkingContext baseContext) : base(baseContext)
        {
        }
    }
}