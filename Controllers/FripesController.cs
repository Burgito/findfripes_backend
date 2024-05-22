using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using findfripes_dotnet.Database;
using findfripes_dotnet.Models;
using findfripes_dotnet.Services;
using Microsoft.IdentityModel.Tokens;

namespace findfripes_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FripesController(IFripesService fripesService) : ControllerBase
    {
        private readonly IFripesService _fripesService = fripesService;

        // GET: api/Fripes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fripe>>> GetFripes(string? city)
        {
            return Ok(await _fripesService.GetFripesByCityAsync(city ?? ""));
        }

        // GET: api/Fripes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fripe>> GetFripe(int id)
        {
            var fripe = await _fripesService.GetByIdAsync(id);
            return fripe == null ? NotFound() : Ok(fripe);
        }

        // POST: api/Fripes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fripe>> PostFripe(Fripe fripe)
        {
            await _fripesService.CreateAsync(fripe);
            return CreatedAtAction("GetFripe", new { id = fripe.Id }, fripe);
        }
    }
}
