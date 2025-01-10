using _14.Week_JWT__Uygulama.Model;
using Microsoft.EntityFrameworkCore;

namespace _14.Week_JWT__Uygulama.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Email alanını benzersiz yapıyoruz.
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        }
    }
}
