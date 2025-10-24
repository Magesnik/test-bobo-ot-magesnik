using Microsoft.AspNetCore.Identity;

namespace PetShoop
{
    public class Potrebitel : IdentityUser
    {
        public string Purvoime { get; set; }
        public string LastName { get; set; }
    }
}