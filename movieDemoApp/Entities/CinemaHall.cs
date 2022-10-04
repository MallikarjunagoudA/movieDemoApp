using movieDemoApp.Enums;

namespace movieDemoApp.Entities
{
    public class CinemaHall
    {

        public int Id { get; set; }

        public CinemaHallType CinemaHallTypes { get; set; }

        //[Precision(precision:9, scale:2)]
        public decimal cost { get; set; }
        public int cinemaid { get; set; }
        public Cinema cinema { get; set; }
        public HashSet<Movie> cinemas { get; set; }
    }
}
