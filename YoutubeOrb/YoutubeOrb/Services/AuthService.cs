using YoutubeOrb.Data;
using YoutubeOrb.Models;
using YoutubeOrb.Helpers;
namespace YoutubeOrb.Services
{
    public class AuthService
    {
        private readonly YoutubeorbContext _context;
        public AuthService(YoutubeorbContext context)
        {
            _context = context;
        }

        public string Login(User usermodel)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == usermodel.Username && u.Password == usermodel.Password);
            if (user == null)
            {
                return null;
            }
            return JwtHelper.GenerateToken(user.Username);
        }
    }
}
