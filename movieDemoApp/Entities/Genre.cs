using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movieDemoApp.Entities
{
    
    //[Table(name:"tblGenre", Schema="movie")]
    public class Genre
    { 
        //[Key]
        public int Id { get; set; }
        //[StringLength(maximumLength:150)]
        //[Required]
        //[Column("GenreName")]
        public string Name { get; set; }

        public HashSet<Movie> cinemas { get; set; }
    }
}
