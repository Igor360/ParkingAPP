using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table(name: "users")]
    public class User : Model
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, ErrorMessage = "Email cannot be loner then 100 characters")]
        public String Email { get; set; }
        
        public byte[] PasswordHash { get; set; }
        
        public byte[] PasswordSalt { get; set; }
         
        [DefaultValue(false)]
        [Column("email_confirmed")]
        public bool EmailConfirmed { get; set; }
        
        [DefaultValue(null)]
        public String Token { get; set; }
        
        public virtual Client Client { get; set; }
    }
}