using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication1.Models
{
    [Table("parking")]
    public class Parking : Model
    {
        [Column("name")]
        public string name { get; set; }
    }
}