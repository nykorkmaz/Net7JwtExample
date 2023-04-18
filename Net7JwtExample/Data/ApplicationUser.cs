using Microsoft.AspNetCore.Identity;

namespace Net7JwtExample.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
