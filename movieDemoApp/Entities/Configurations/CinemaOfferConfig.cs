using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace movieDemoApp.Entities.Configurations
{
    public class CinemaOfferConfig : IEntityTypeConfiguration<CinemaOffer>
    {
        public void Configure(EntityTypeBuilder<CinemaOffer> builder)
        {

            // CinemaOffer 
            // this table one to one relationship with the cinema table. 
            builder.Property(p => p.Begin).HasColumnType("Date");
            builder.Property(p => p.End).HasColumnType("Date");
            builder.Property(p => p.DiscountPercentage).HasPrecision(precision: 9, scale: 2);// decimal
        }
    }
}
