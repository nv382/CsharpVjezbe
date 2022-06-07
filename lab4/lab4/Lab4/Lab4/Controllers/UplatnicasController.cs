using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab4.Models;

namespace Lab4.Controllers
{
    [Route("api/Uplatnicas")]
    [ApiController]
    public class UplatnicasController : ControllerBase
    {
        private readonly UplatnicaContext _context;
        static HttpClient client = new HttpClient();

        public UplatnicasController(UplatnicaContext context)
        {
            _context = context;
        }

        // GET: api/Uplatnicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Uplatnica>>> GetUplatnicas()
        {
          if (_context.Uplatnicas == null)
          {
              return NotFound();
          }
            return await _context.Uplatnicas.ToListAsync();
        }

        // GET: api/Uplatnicas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Uplatnica>> GetUplatnica(int id)
        {
          if (_context.Uplatnicas == null)
          {
              return NotFound();
          }
            var uplatnica = await _context.Uplatnicas.FindAsync(id);

            if (uplatnica == null)
            {
                return NotFound();
            }

            return uplatnica;
        }

        // PUT: api/Uplatnicas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUplatnica(int id, Uplatnica uplatnica)
        {
            if (id != uplatnica.Id)
            {
                return BadRequest();
            }

            _context.Entry(uplatnica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UplatnicaExists(id))
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

        // POST: api/Uplatnicas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Uplatnica>> PostUplatnica(Uplatnica uplatnica)
        {
          if (_context.Uplatnicas == null)
          {
              return Problem("Entity set 'UplatnicaContext.Uplatnicas'  is null.");
          }
            _context.Uplatnicas.Add(uplatnica);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetUplatnica", new { id = uplatnica.Id }, uplatnica);
            return CreatedAtAction(nameof(GetUplatnica), new {id=uplatnica.Id}, uplatnica);
        }

        // DELETE: api/Uplatnicas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUplatnica(int id)
        {
            if (_context.Uplatnicas == null)
            {
                return NotFound();
            }
            var uplatnica = await _context.Uplatnicas.FindAsync(id);
            if (uplatnica == null)
            {
                return NotFound();
            }

            _context.Uplatnicas.Remove(uplatnica);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UplatnicaExists(int id)
        {
            return (_context.Uplatnicas?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public static async Task<ActionResult<Uplatnica>> GetAPIAsync(string path)

        {

            Uplatnica? uplatnica = null;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)

            {

                uplatnica = await response.Content.ReadAsStringAsync();

            }

            return uplatnica;

        }
    }
}
