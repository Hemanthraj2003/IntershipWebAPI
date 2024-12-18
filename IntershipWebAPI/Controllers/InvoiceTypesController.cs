using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IntershipWebAPI.DBContext;
using IntershipWebAPI.Model;

namespace IntershipWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceTypesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public InvoiceTypesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceType>>> GetInvoiceType()
        {
            return await _context.InvoiceType.ToListAsync();
        }

        // GET: api/InvoiceTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceType>> GetInvoiceType(int id)
        {
            var invoiceType = await _context.InvoiceType.FindAsync(id);

            if (invoiceType == null)
            {
                return NotFound();
            }

            return invoiceType;
        }

        // PUT: api/InvoiceTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceType(int id, InvoiceType invoiceType)
        {
            if (id != invoiceType.Id)
            {
                return BadRequest();
            }

            _context.Entry(invoiceType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceTypeExists(id))
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

        // POST: api/InvoiceTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InvoiceType>> PostInvoiceType(InvoiceType invoiceType)
        {
            _context.InvoiceType.Add(invoiceType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoiceType", new { id = invoiceType.Id }, invoiceType);
        }

        // DELETE: api/InvoiceTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoiceType(int id)
        {
            var invoiceType = await _context.InvoiceType.FindAsync(id);
            if (invoiceType == null)
            {
                return NotFound();
            }

            _context.InvoiceType.Remove(invoiceType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoiceTypeExists(int id)
        {
            return _context.InvoiceType.Any(e => e.Id == id);
        }
    }
}
