using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieDemoApp.Entities;
using movieDemoApp.Utilites;

namespace movieDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public ActorController(MovieDbContext mdbcontext)
        {
            this._context = mdbcontext;
        } 

        public async Task<IEnumerable<Actor>> Get()
        {
            return await _context.actors.ToListAsync();
        }

        [Route("first")]
        public async Task<ActionResult<Actor>> GetFirst()
        {
            var firstActor = await _context.actors.FirstOrDefaultAsync();
            if(firstActor == null)
            {
                return NotFound();
            }
            return firstActor;
        }

        [Route("firstContainsM")]
        public async Task<ActionResult<Actor>> GetFirstContainsM()
        {
            var firstActor = await _context.actors.FirstOrDefaultAsync( m => m.Name.Contains("m"));
            if (firstActor == null)
            {
                return NotFound();
            }
            return firstActor;
        }


        [Route("filter")]
        public async Task<ActionResult<IEnumerable<Actor>>> GetName([FromQuery]string name)
        {
            var Actor = await _context.actors.Where(m => m.Name.StartsWith(name)).ToListAsync();
            if (Actor == null)
            {
                return NotFound();
            }
            return Actor;
        }


        [Route("paginate")]
        public async Task<ActionResult<IEnumerable<Actor>>> GetName([FromQuery] int page=1, int recordsTake = 2)
        {
            var Actors = await _context.actors
                .Paginate(page, recordsTake)
                .ToListAsync();

            if (Actors == null)
            {
                return NotFound();
            }
            return Actors;
        }
    }
}
