using System.ComponentModel.DataAnnotations;

namespace YoutubeOrb.Models
{
    public class UserLoginModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }       
        public string ProfilePicture { get; set; } 
        public string Email { get; set; }           
        public string PhoneNumber { get; set; }   
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
