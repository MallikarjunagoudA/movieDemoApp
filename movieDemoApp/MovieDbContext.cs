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

    //genre
    //modelBuilder.Entity<Genre>().ToTable(name: "tblGenre", schema: "movie");
    //modelBuilder.Entity<Genre>().HasKey(k => k.GenreIdentification);
    modelBuilder.Entity<Genre>()
        .Property(p => p.Name)
        //.HasColumnName("GenreName")
        .HasMaxLength(150).IsRequired();


    //actor
    modelBuilder.Entity<Actor>().Property(p => p.Name).HasMaxLength(150).IsRequired();
    modelBuilder.Entity<Actor>().Property(p => p.DOB).HasColumnType("Date");

    //cinema
    modelBuilder.Entity<Cinema>().Property(p => p.Name).HasMaxLength(150).IsRequired();
    modelBuilder.Entity<Cinema>().Property(p => p.price).HasPrecision(precision:9, scale:2);


        //movie
    modelBuilder.Entity<Movie>().Property(p => p.Title).HasMaxLength(250).IsRequired();
    modelBuilder.Entity<Movie>().Property(p => p.RelaseDate).HasColumnType("Date");
    modelBuilder.Entity<Movie>().Property(p => p.PosterUrl).HasMaxLength(250).IsUnicode(false);
}


public DbSet<Genre> genres { get; set; }
public DbSet<Actor> actors { get; set; }
public DbSet<Cinema> cinemas { get; set; }
public DbSet<Movie> movies { get; set; }



}
}
