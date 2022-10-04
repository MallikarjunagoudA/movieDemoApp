namespace movieDemoApp.Entities
{

    //this is created to make the custom many to many relationship with that we can add the desired columns too.
    public class MovieActor
    {
        public int movieid { get; set; }
        public int actorid { get; set; }
        public string character { get; set; }
        public int order { get; set; }
        public Movie movie { get; set; }
        public Actor actor { get; set; }
    }
}
