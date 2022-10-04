using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace movieDemoApp.Entities.Configurations
{
    public class CinemaHallConfig : IEntityTypeConfiguration<CinemaHall>
    {
        public void Configure(EntityTypeBuilder<CinemaHall> builder)
        {

            // CinemaHall
            builder.Property(p => p.cost).HasPrecision(precision: 9, scale: 2);
        }
    }
}
