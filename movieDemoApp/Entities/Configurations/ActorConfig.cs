using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace movieDemoApp.Entities.Configurations
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            // Actor
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.DOB).HasColumnType("Date");
            builder.Property(p => p.Biograpy).HasColumnType("nvarchar(max)");
        }
    }
}
