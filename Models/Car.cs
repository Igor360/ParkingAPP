using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    [Table("car")]
    public class Car : Model
    {
        [Column("name")]
        public string name { get; set; }

        [Column("type")]
        public CarTypes carType { get; set; }

        [Column("code")]
        public string code { get; set; }
        
        public virtual ICollection<Cars> cars { get; set; }

    }
}