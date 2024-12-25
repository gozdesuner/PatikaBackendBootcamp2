using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Data;
using Survivor.Models;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorController(SurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var competitors = await _context.Competitors.ToListAsync();
            return Ok(competitors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null) return NotFound();
            return Ok(competitor);
        }

        [HttpGet("categories/{categoryId}")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var competitors = await _context.Competitors
                                             .Where(c => c.CategoryId == categoryId)
                                             .ToListAsync();
            return Ok(competitors);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Competitor competitor)
        {
            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = competitor.Id }, competitor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Competitor competitor)
        {
            var existingCompetitor = await _context.Competitors.FindAsync(id);
            if (existingCompetitor == null) return NotFound();

            existingCompetitor.FirstName = competitor.FirstName;
            existingCompetitor.LastName = competitor.LastName;
            existingCompetitor.CategoryId = competitor.CategoryId;
            existingCompetitor.ModifiedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null) return NotFound();

            competitor.IsDeleted = true;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
