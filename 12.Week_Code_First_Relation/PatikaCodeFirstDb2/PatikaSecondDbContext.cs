using Microsoft.EntityFrameworkCore;

namespace _12.Week_Code_First_Relation.PatikaCodeFirstDb2
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=PatikaCodeFirstDb2");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posts>()
                .HasOne(p => p.Users) // Bir gönderinin yalnızca bir yazarı olabilir
                .WithMany(u => u.Posts) // Bir kullanıcı birden fazla gönderi yazabilir
                .HasForeignKey(p => p.UserId); // Foreign Key'i belirtiyoruz
        }

    }
}

