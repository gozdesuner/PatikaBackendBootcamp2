using Microsoft.EntityFrameworkCore;

namespace _12.Week_Code_First_1.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=PatikaCodeFirstDb1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Games");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100);
                entity.Property(x => x.Platform).IsRequired().HasMaxLength(100);
                entity.Property(x => x.Rating).IsRequired().HasColumnType("decimal(20,2)");
            });
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movies");
                entity.Property(x => x.Title).IsRequired().HasMaxLength(100);
                entity.Property(x => x.ReleaseYear).IsRequired();
            });

            modelBuilder.Entity<Game>().HasData
                (
                new Game() { Id = 1, Name = "Elden Ring", Platform = "PC" },
                new Game() { Id = 2, Name = "God of War: Ragnarok", Platform = "PlayStation" },
                new Game() { Id = 3, Name = "Forza Horizon 5", Platform = "Xbox" },
                new Game() { Id = 4, Name = "The Legend of Zelda: Breath of the Wild", Platform = "Nintendo Switch" },
                new Game() { Id = 5, Name = "Hogwarts Legacy", Platform = "PC" }
                );

            modelBuilder.Entity<Movie>().HasData
                (
                new Movie() { Id = 1, Title = "Interstellar", Genre = "Science Fiction", ReleaseYear = 2014 },
                new Movie() { Id = 2, Title = "Parasite", Genre = "Thriller", ReleaseYear = 2019 },
                new Movie() { Id = 3, Title = "Mad Max: Fury Road", Genre = "Action", ReleaseYear = 2015 },
                new Movie() { Id = 4, Title = "The Shawshank Redemption", Genre = "Drama", ReleaseYear = 1994 },
                new Movie() { Id = 5, Title = "Spirited Away", Genre = "Animation", ReleaseYear = 2001 }

                );

        }
    }
}

