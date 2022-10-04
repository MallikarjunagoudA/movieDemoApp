using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace movieDemoApp.Entities
{
    public class Cinema
    {
       
        public int Id { get; set; }
        public string Name { get; set; }

        public Point location { get; set; }

        public CinemaOffer cinemaOffer { get; set; }

        public HashSet<CinemaHall> cinemaHalls { get; set; }
        //public ICollection<CinemaHall> cinemaHalls { get; set; }
        //public IList<CinemaHall> cinemaHalls { get; set; }


    }
}
