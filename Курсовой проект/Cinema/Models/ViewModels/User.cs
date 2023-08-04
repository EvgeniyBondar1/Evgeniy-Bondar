using Microsoft.AspNetCore.Identity;

namespace Cinema.Models.ViewModels
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
