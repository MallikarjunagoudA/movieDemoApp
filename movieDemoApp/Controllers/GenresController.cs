using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieDemoApp.Entities;

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
    }
}
