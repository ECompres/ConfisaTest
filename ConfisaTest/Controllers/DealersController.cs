using ConfisaTest.Context;
using Microsoft.AspNetCore.Mvc;
using ConfisaTest.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConfisaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealersController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DealersController(ApplicationDbContext _context)
        {
            context = _context;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Dealers>> GetAllDealers() {
            return context.Dealers.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Dealers> GetDealer(int id)
        {
            var dealer = context.Dealers.FirstOrDefault(x => x.id == id);
            
            if(dealer != null)
            {
                return Ok(dealer);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult CreateDealer([FromBody] Dealers dealer)
        {
            if (ModelState.IsValid)
            {
                context.Dealers.Add(dealer);
                context.SaveChanges();
                return Ok(dealer);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDealer([FromBody] Dealers dealer, int id)
        {
            if(dealer.id == id)
            {
                context.Entry(dealer).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(dealer);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDealer(int id)
        {
            var dealer = context.Dealers.FirstOrDefault(x => x.id == id);
            if(dealer != null) {
                context.Dealers.Remove(dealer);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
