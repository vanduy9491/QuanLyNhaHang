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
    public class UnitTypesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UnitTypesController(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Lấy tất cả UnitType
        /// </summary>
        /// <returns></returns>
        // GET: api/UnitTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnitType>>> GetUnitTypes()
        {
            return await _context.UnitTypes.ToListAsync();
        }
        /// <summary>
        /// Lấy UnitType theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/UnitTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UnitType>> GetUnitType(int id)
        {
            var unitType = await _context.UnitTypes.FindAsync(id);

            if (unitType == null)
            {
                return NotFound();
            }

            return unitType;
        }

        // PUT: api/UnitTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnitType([FromQuery] int id, UnitType unitType)
        {
            if (id != unitType.Id)
            {
                return BadRequest();
            }

            _context.Entry(unitType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitTypeExists(id))
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

        // POST: api/UnitTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UnitType>> PostUnitType([FromQuery] UnitType unitType)
        {
            _context.UnitTypes.Add(unitType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnitType", new { id = unitType.Id }, unitType);
        }

        // DELETE: api/UnitTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UnitType>> DeleteUnitType(int id)
        {
            var unitType = await _context.UnitTypes.FindAsync(id);
            if (unitType == null)
            {
                return NotFound();
            }

            _context.UnitTypes.Remove(unitType);
            await _context.SaveChangesAsync();

            return unitType;
        }

        private bool UnitTypeExists(int id)
        {
            return _context.UnitTypes.Any(e => e.Id == id);
        }
    }
}
