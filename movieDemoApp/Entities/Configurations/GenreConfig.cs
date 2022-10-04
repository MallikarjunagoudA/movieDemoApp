using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace movieDemoApp.Entities.Configurations
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {

            // Genre
            //modelBuilder.Entity<Genre>().ToTable(name: "tblGenre", schema: "movie");
            //modelBuilder.Entity<Genre>().HasKey(k => k.GenreIdentification);
            builder.Property(p => p.Name)
                //.HasColumnName("GenreName")
                .IsRequired();
        }
    }
}
