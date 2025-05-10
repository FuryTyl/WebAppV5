using Microsoft.AspNetCore.Identity;

namespace WebAppV5.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}