using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace WebApplication1.Contexts
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ParkingContext : DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Parking> parkings { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Client> clients { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Car> cars { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Cars> carses { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<ParkingPosition> parkingPositions { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<ParkingTicket> parkingTickets { get; set; }


        public ParkingContext(DbContextOptions<ParkingContext> options) : base(options) { }
    }
}