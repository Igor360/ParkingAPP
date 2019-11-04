using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("company_parking")]
    public class CompanyParking : Model
    {
        [Column("name")]
        public string name { get; set; }
        
        [Column("city")]
        public string city { get; set; }
        
        [Column("street")]
        public string street {  get; set; } 
        
        [Column("description")]
        public string description { get; set; }

        public virtual Company companies { get; set; }

        public virtual ICollection<ParkingPosition> parkingPositions { get; set; }
    }
    
    
}