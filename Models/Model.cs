using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Model
    {
        [Required]
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("created_at")]
        public DateTime? createdAt { get; set; } 
        
        [Column("updated_at")]
        public DateTime? updatedAt { get; set; }
    }
}