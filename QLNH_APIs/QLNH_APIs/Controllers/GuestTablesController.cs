using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuestTablesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GuestTablesController(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Lấy tất cả GuestTable
        /// </summary>
        /// <returns></returns>
        // GET: api/GuestTables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GuestTable>>> GetGuestTables()
        {
            return await _context.GuestTables.ToListAsync();
        }
        /// <summary>
        /// Lấy GuestTable theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/GuestTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GuestTable>> GetGuestTable(int id)
        {
            var guestTable = await _context.GuestTables.FindAsync(id);

            if (guestTable == null)
            {
                return NotFound();
            }

            return guestTable;
        }

        // PUT: api/GuestTables/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuestTable(int id, [FromQuery] GuestTable guestTable)
        {
            if (id != guestTable.Id)
            {
                return BadRequest();
            }

            _context.Entry(guestTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestTableExists(id))
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

        // POST: api/GuestTables
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GuestTable>> PostGuestTable([FromQuery] GuestTable guestTable)
        {
            _context.GuestTables.Add(guestTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGuestTable", new { id = guestTable.Id }, guestTable);
        }

        // DELETE: api/GuestTables/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GuestTable>> DeleteGuestTable(int id)
        {
            var guestTable = await _context.GuestTables.FindAsync(id);
            if (guestTable == null)
            {
                return NotFound();
            }

            _context.GuestTables.Remove(guestTable);
            await _context.SaveChangesAsync();

            return guestTable;
        }

        private bool GuestTableExists(int id)
        {
            return _context.GuestTables.Any(e => e.Id == id);
        }
    }
}
