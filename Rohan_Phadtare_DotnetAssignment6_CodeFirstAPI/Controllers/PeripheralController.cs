using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rohan_Phadtare_DotnetAssignment6_CodeFirstAPI.Models;
using System;

namespace Rohan_Phadtare_DotnetAssignment6_CodeFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeripheralController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PeripheralController(ApplicationDbContext context)
        {
            _context = context;
        }



        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Peripheral>>> GetPeripherals()
        {
            return await _context.Peripherals.ToListAsync();
        }

    
        [HttpGet("{id}")]
        public async Task<ActionResult<Peripheral>> GetPeripheral(int id)
        {
            var peripheral = await _context.Peripherals.FindAsync(id);

            if (peripheral == null)
            {
                return NotFound();
            }

            return peripheral;
        }

        
        [HttpPost]
        public async Task<ActionResult<Peripheral>> PostPeripheral(Peripheral peripheral)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            peripheral.AddedDate = DateTime.UtcNow;
            _context.Peripherals.Add(peripheral);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPeripheral), new { id = peripheral.Id }, peripheral);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeripheral(int id, Peripheral peripheral)
        {
            if (id != peripheral.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingPeripheral = await _context.Peripherals.FindAsync(id);
            if (existingPeripheral == null)
            {
                return NotFound();
            }

        
            peripheral.AddedDate = existingPeripheral.AddedDate;

            _context.Entry(existingPeripheral).CurrentValues.SetValues(peripheral);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeripheralExists(id))
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

      
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeripheral(int id)
        {
            var peripheral = await _context.Peripherals.FindAsync(id);
            if (peripheral == null)
            {
                return NotFound();
            }

            _context.Peripherals.Remove(peripheral);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PeripheralExists(int id)
        {
            return _context.Peripherals.Any(e => e.Id == id);
        }
    }
}
