using System;

namespace movieDemoApp.Entities
{
    public class CinemaOffer
    {
        public int Id { get; set; }
        public Nullable<DateTime> Begin { get; set; }
        public Nullable<DateTime> End { get; set; }
        public Decimal DiscountPercentage { get; set; }
        public int CinemaId { get; set; }


    }
}
