using Microsoft.AspNetCore.Identity;

namespace OpenIddictWebServer.Models
{
    public class UserModel : IdentityUser
    {
        public string FirstName { get; set; }
    }
}
