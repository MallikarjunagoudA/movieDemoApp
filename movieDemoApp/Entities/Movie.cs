namespace movieDemoApp.Entities
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public bool InCinemas { get; set; }
        public DateTime RelaseDate { get; set; }
        public string PosterUrl { get; set; }
        public HashSet<CinemaHall> cinemaHalls { get; set; }
        public HashSet<Genre> genres { get; set; }
        public HashSet<MovieActor> movieActors { get; set; }



    }
}
