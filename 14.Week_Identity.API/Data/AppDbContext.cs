using _14.Week_Identity.API.Model;
using Microsoft.EntityFrameworkCore;

namespace _14.Week_Identity.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Email)
                .IsUnique();//Email alanı benzersiz olmalıdır.
        }
    }
}
