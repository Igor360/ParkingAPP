using System.Data.Entity;
using System.Linq;
using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public class UserRepository : AbstractRepository<User>, IUserRepository
    {
        public UserRepository(ParkingContext baseContext) : base(baseContext)
        {
        }

        public User findByEmailAndPassword(string email, byte[] PasswordHash, byte[] PasswordSalt)
        {
            return this.DbContext.Set<User>().Where(x =>
                (x.Email == email || x.Name == email) && x.PasswordHash == PasswordHash &&
                x.PasswordSalt == PasswordSalt).FirstAsync().Result;
        }

        public User findByName(string name)
        {
            return this.DbContext.Set<User>().Where(x => x.Name == name).FirstAsync().Result;
        }
    }
}