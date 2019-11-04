using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("parking_position")]
    public class ParkingPosition : Model
    {
        [Column("name")] 
        public string name { get; set; }
        
        public virtual CompanyParking companyParkings { get; set; }

        public virtual ICollection<ParkingPricing> parkingPricings { get; set; }

        public virtual ICollection<ParkingTicket> parkingTickets { get; set; }
        
    }
}