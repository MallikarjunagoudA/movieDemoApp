using Microsoft.EntityFrameworkCore;
using movieDemoApp.Entities;

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

        // Genre
        //modelBuilder.Entity<Genre>().ToTable(name: "tblGenre", schema: "movie");
        //modelBuilder.Entity<Genre>().HasKey(k => k.GenreIdentification);
        modelBuilder.Entity<Genre>()
            .Property(p => p.Name)
            //.HasColumnName("GenreName")
            .IsRequired();


        // Actor
        modelBuilder.Entity<Actor>().Property(p => p.Name).IsRequired();
        modelBuilder.Entity<Actor>().Property(p => p.DOB).HasColumnType("Date");
        modelBuilder.Entity<Actor>().Property(p => p.Biograpy).HasColumnType("nvarchar(max)");

        // Cinema
        modelBuilder.Entity<Cinema>().Property(p => p.Name).IsRequired();


        // Movie
        modelBuilder.Entity<Movie>().Property(p => p.Title).HasMaxLength(250).IsRequired();
        modelBuilder.Entity<Movie>().Property(p => p.RelaseDate).HasColumnType("Date");
        modelBuilder.Entity<Movie>().Property(p => p.PosterUrl).HasMaxLength(250).IsUnicode(false);


        // CinemaOffer 
        // this table one to one relationship with the cinema table. 
        modelBuilder.Entity<CinemaOffer>().Property(p => p.Begin).HasColumnType("Date");
        modelBuilder.Entity<CinemaOffer>().Property(p => p.End).HasColumnType("Date");
        modelBuilder.Entity<CinemaOffer>().Property(p => p.DiscountPercentage).HasPrecision(precision: 9, scale: 2);// decimal

        // CinemaHall
        modelBuilder.Entity<CinemaHall>().Property(p => p.cost).HasPrecision(precision: 9, scale: 2);


            // MovieActor
            modelBuilder.Entity<MovieActor>().Property(p => p.character);
            modelBuilder.Entity<MovieActor>().HasKey(p => new {p.movieid, p.actorid});
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
