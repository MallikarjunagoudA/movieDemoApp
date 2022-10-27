using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieDemoApp.Entities;
using movieDemoApp.Utilites;

namespace movieDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public GenresController(MovieDbContext mdbcontext)
        {
            this._context = mdbcontext;
        } 

        public async Task<IEnumerable<Genre>> Get()
        {
            return await _context.genres.ToListAsync();
        }

        [Route("first")]
        public async Task<ActionResult<Genre>> GetFirst()
        {
            var firstGenre = await _context.genres.FirstOrDefaultAsync();
            if(firstGenre == null)
            {
                return NotFound();
            }
            return firstGenre;
        }

        [Route("firstContainsM")]
        public async Task<ActionResult<Genre>> GetFirstContainsM()
        {
            var firstGenre = await _context.genres.FirstOrDefaultAsync( m => m.Name.Contains("m"));
            if (firstGenre == null)
            {
                return NotFound();
            }
            return firstGenre;
        }


        [Route("filter")]
        public async Task<ActionResult<IEnumerable<Genre>>> GetName([FromQuery]string name)
        {
            var Genre = await _context.genres.Where(m => m.Name.StartsWith(name)).ToListAsync();
            if (Genre == null)
            {
                return NotFound();
            }
            return Genre;
        }


        [Route("paginate")]
        public async Task<ActionResult<IEnumerable<Genre>>> GetName([FromQuery] int page=1, int recordsTake = 2)
        {
            var Genre = await _context.genres
                .Paginate(page, recordsTake)
                .ToListAsync();

            if (Genre == null)
            {
                return NotFound();
            }
            return Genre;
        }
    }
}
