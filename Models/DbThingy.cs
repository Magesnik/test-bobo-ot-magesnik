using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PetClinic
{
    public class DbThingy : IdentityDbContext<User>
    {
        public DbThingy(DbContextOptions options)
            : base(options) { }
        public DbSet<Animal> Animal { get; set; }
    }
}