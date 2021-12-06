using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)
           : base(options)
        { }

         public DbSet<Game> Games { get; set; }
         public DbSet<Genre> Genres { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new GameConfig());
            

            modelBuilder.Entity<Genre>().HasMany(g => g.Games).WithOne(m => m.Genre);
        }

    }
}
