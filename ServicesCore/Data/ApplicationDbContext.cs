using EnergonSoftware.Services.Models;

using Microsoft.EntityFrameworkCore;

namespace EnergonSoftware.Services.Data
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }
    }
}
