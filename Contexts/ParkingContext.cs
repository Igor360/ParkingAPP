using DbConfigurationType = System.Data.Entity.DbConfigurationTypeAttribute;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace WebApplication1.Contexts
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ParkingContext : DbContext
    {
        public DbSet<Parking> parking { get; set; }

        public DbSet<Client> client { get; set; }

        public DbSet<Car> car { get; set; }

        public DbSet<Cars> cars { get; set; }

        public DbSet<ParkingPosition> parkingPosition { get; set; }

        public DbSet<ParkingTicket> parkingTicket { get; set; }

        public DbSet<User> user { get; set; }

        public DbSet<ParkingPricing> parkingPricings { get; set; }
        
        public ParkingContext(DbContextOptions<ParkingContext> options) : base(options)
        {
        }
    }
}