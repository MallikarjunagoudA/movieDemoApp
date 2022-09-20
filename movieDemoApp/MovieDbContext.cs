using Microsoft.EntityFrameworkCore;

namespace movieDemoApp
{
    public class MovieDbContext : DbContext
    {

        public MovieDbContext(DbContextOptions options): base(options)
        {

        }



    }
}
