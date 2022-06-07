using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab5_1.Data;
using Lab5_1.Models;

namespace Lab5_1.Controllers
{
    [ApiController]
    [Route("api/Uplatnicas")]

    public class UplatnicasController : Controller
    {
        private readonly UplatniceContext _context;

        public UplatnicasController(UplatniceContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Uplatnica>>> GetUplatnices()
        {
            if (_context.Uplatnicas == null)
            {
                return NotFound();
            }
            return await _context.Uplatnicas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Uplatnica>> GetTUplatnica(long id)
        {
            if (_context.Uplatnicas == null)
            {
                return NotFound();
            }
            var uplatnice = await _context.Uplatnicas.FindAsync(id);

            if (uplatnice == null)
            {
                return NotFound();
            }

            return uplatnice;
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> PutUplatnica(long id, Uplatnica uplatnice)
        {
            if (id != uplatnice.Id)
            {
                return BadRequest();
            }

            _context.Entry(uplatnice).State = EntityState.Modified;

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



        [HttpPost]
        public async Task<ActionResult<Uplatnica>> PostUplatnica(Uplatnica uplatnica)
        {
            if (_context.Uplatnicas == null)
            {
                return Problem("Entity set 'TransakcijeContext.Uplatnicas'  is null.");
            }
            _context.Uplatnicas.Add(uplatnica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUplatnicas", new { id = uplatnica.Id }, uplatnica);
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUplatnica(long id)
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




        private bool UplatnicaExists(long id)
        {
            return (_context.Uplatnicas?.Any(e => e.Id == id)).GetValueOrDefault();
        }



    }
}
