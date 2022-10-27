using EFCoreMovies.Entities.Seeding;
using Microsoft.EntityFrameworkCore;
using movieDemoApp.Entities;
using System.Reflection;

namespace movieDemoApp
{
public class MovieDbContext : DbContext
{

public MovieDbContext(DbContextOptions options): base(options)
{

}

protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
{
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<string>().HaveMaxLength(150);
}
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
        base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            Module3Seeding.Seed(modelBuilder);


        }


        public DbSet<Genre> genres { get; set; }
        public DbSet<Actor> actors { get; set; }
        public DbSet<Cinema> cinemas { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<CinemaOffer> cinemaOffers { get; set; }
        public DbSet<CinemaHall> cinemaHalls { get; set; }
        public DbSet<MovieActor> movieActors { get; set; }



}
}
