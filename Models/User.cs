using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PetClinic
{
    public class User : IdentityUser
    {
        [MinLength(2)]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}