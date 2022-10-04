using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace movieDemoApp.Entities.Configurations
{
    public class MovieActorConfig : IEntityTypeConfiguration<MovieActor>
    {
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {

            // MovieActor
            builder.Property(p => p.character);
            builder.HasKey(p => new { p.movieid, p.actorid });
        }
    }
}
