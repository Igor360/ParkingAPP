using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("company")]
    public class Company : Model
    {
        [Column("name")]
        public string name { get; set; }
        
        [Column("description")] 
        public  string description { get; set; }

        public virtual Client client { get; set; }

        public virtual ICollection<CompanyParking> companyParkings { get; set; }
       
        
    }
    
}