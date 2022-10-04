using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace movieDemoApp.Entities.Configurations
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {

            // Movie
            builder.Property(p => p.Title).HasMaxLength(250).IsRequired();
            builder.Property(p => p.RelaseDate).HasColumnType("Date");
            builder.Property(p => p.PosterUrl).HasMaxLength(250).IsUnicode(false);
        }
    }
}
