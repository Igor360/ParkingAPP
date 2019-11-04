using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Contexts;
using WebApplication1.Services;

namespace WebApplication1.Models
{
    [Table("parking_pricing")]
    public class ParkingPricing : Model
    {
        [Column("type")]
        public string type { get; set; }
        
        [Column("price")]
        public double price { get; set; }

        public virtual ParkingPosition parkingPositions { get; set; }

        public virtual ICollection<ParkingTicket> parkingTickets { get; set; }
    }
    
}