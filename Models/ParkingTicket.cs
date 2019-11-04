using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("parking_ticket")]
    public class ParkingTicket : Model
    {
        [Column("name")]
        public string name { get; set; }

        [Column("price")]
        public double price { get; set; }

        [Column("purchased_time")]
        public int purchasedTime { get; set; }

        [Column("spend_time")] 
        public int spendTime { get; set; }

        public virtual Car car { get; set; }

        public virtual ParkingPricing pricing { get; set; }

        public virtual ParkingPosition parkingPosition { get; set; }
    }
}