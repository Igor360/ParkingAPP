using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests
{
    public class AuthenticateRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }
    }
}