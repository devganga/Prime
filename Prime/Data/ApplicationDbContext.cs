using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prime.Entities;

namespace Prime.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Prime.Entities.Cards> Cards { get; set; } = default!;
        public DbSet<Prime.Entities.Quotes> Quotes { get; set; } = default!;
    }
}
