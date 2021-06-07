using ConfisaTest.Context;
using ConfisaTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfisaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OficialesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public OficialesController(ApplicationDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Oficiales>> GetAllOficiales()
        {
            return context.Oficiales.Include(x=>x.Dealers).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Oficiales> GetOficial(int id)
        {
            var oficial = context.Oficiales.FirstOrDefault(x => x.id == id);

            if (oficial != null)
            {
                return Ok(oficial);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult CreateOficial([FromBody] Oficiales oficial)
        {
            if (ModelState.IsValid)
            {
                context.Oficiales.Add(oficial);
                context.SaveChanges();
                return Ok(oficial);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOficial([FromBody] Oficiales oficial, int id)
        {
            if (oficial.id == id)
            {
                context.Entry(oficial).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(oficial);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOficial(int id)
        {
            var oficial = context.Oficiales.FirstOrDefault(x => x.id == id);
            if (oficial != null)
            {
                context.Oficiales.Remove(oficial);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
