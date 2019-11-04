using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("client")]
    public class Client : Model
    {
        [Column("firstName")]
        public string firstName { get; set; }
        
        [Column("lastName")]
        public string lastName { get; set; }
        
        [Column("idNumber")]
        public string idNumber { get; set; }

        public virtual ICollection<Cars> cars { get; set; }
        
        public virtual ICollection<Company> companies { get; set; }

    }
}