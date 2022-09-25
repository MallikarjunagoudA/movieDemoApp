using Microsoft.EntityFrameworkCore;
using movieDemoApp.Entities;

namespace movieDemoApp
{
    public class MovieDbContext : DbContext
    {

        public MovieDbContext(DbContextOptions options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasKey(k => k.GenreIdentification);
        }


        public DbSet<Genre> genres { get; set; }


    }
}
