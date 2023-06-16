using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ElectionService.Model;

namespace ElectionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectionsController : ControllerBase
    {
        private readonly ElectionContext _context;

        public ElectionsController(ElectionContext context)
        {
            _context = context;
        }

        // GET: api/Elections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Election>>> GetElections()
        {
          if (_context.Elections == null)
          {
              return NotFound();
          }
            return await _context.Elections.ToListAsync();
        }

        // GET: api/Elections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Election>> GetElection(int id)
        {
          if (_context.Elections == null)
          {
              return NotFound();
          }
            var election = await _context.Elections.FindAsync(id);

            if (election == null)
            {
                return NotFound();
            }

            return election;
        }

        // PUT: api/Elections/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElection(int id, Election election)
        {
            if (id != election.ElectionId)
            {
                return BadRequest();
            }

            _context.Entry(election).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElectionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Elections
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Election>> PostElection(Election election)
        {
          if (_context.Elections == null)
          {
              return Problem("Entity set 'ElectionContext.Elections'  is null.");
          }
            _context.Elections.Add(election);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElection", new { id = election.ElectionId }, election);
        }

        // DELETE: api/Elections/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElection(int id)
        {
            if (_context.Elections == null)
            {
                return NotFound();
            }
            var election = await _context.Elections.FindAsync(id);
            if (election == null)
            {
                return NotFound();
            }

            _context.Elections.Remove(election);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElectionExists(int id)
        {
            return (_context.Elections?.Any(e => e.ElectionId == id)).GetValueOrDefault();
        }
    }
}
