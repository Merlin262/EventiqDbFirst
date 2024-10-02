using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventiqDBFirst.Models;

namespace EventiqDBFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInsController : ControllerBase
    {
        private readonly EventiqContext _context;

        public CheckInsController(EventiqContext context)
        {
            _context = context;
        }

        // GET: api/CheckIns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CheckIn>>> GetCheckIns()
        {
            return await _context.CheckIns.ToListAsync();
        }

        // GET: api/CheckIns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CheckIn>> GetCheckIn(int id)
        {
            var checkIn = await _context.CheckIns.FindAsync(id);

            if (checkIn == null)
            {
                return NotFound();
            }

            return checkIn;
        }

        // PUT: api/CheckIns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheckIn(int id, CheckIn checkIn)
        {
            if (id != checkIn.Id)
            {
                return BadRequest();
            }

            _context.Entry(checkIn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckInExists(id))
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

        // POST: api/CheckIns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CheckIn>> PostCheckIn(CheckIn checkIn)
        {
            _context.CheckIns.Add(checkIn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCheckIn", new { id = checkIn.Id }, checkIn);
        }

        // DELETE: api/CheckIns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCheckIn(int id)
        {
            var checkIn = await _context.CheckIns.FindAsync(id);
            if (checkIn == null)
            {
                return NotFound();
            }

            _context.CheckIns.Remove(checkIn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CheckInExists(int id)
        {
            return _context.CheckIns.Any(e => e.Id == id);
        }
    }
}
