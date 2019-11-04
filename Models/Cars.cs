using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    [Table("cars")]
    public class Cars : Model
    {
        [Column("group")] 
        public CarGroups group { get; set; }

        public virtual Client client { get; set; }
        
        public virtual Car car { get; set; }
    }
}