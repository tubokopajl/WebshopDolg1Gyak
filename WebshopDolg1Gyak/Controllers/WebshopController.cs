using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebshopDolg1Gyak.Modells;

namespace WebshopDolg1Gyak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebshopController : ControllerBase
    {
        private readonly VasarlasContext _context;

        public WebshopController(VasarlasContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet("/mindenvasarloadat")]
        public async Task<ActionResult<IEnumerable<Vasarlo>>> GetVasarlok()
        {
            return await _context.Vasarlok.ToListAsync();
        }

        [HttpGet("/mindenvasarloadatbyid")]
        public async Task<ActionResult<Vasarlo>> GetVasarlokById(int id)
        {
            var vasarlo = await _context.Vasarlok.FindAsync(id);

            if (vasarlo == null)
            {
                return NotFound();
            }

            return vasarlo;
        }

        [HttpGet("/mindentermekadat")]
        public async Task<ActionResult<IEnumerable<Termekek>>> GetTermekek()
        {
            return await _context.Termekek.ToListAsync();
        }

        [HttpGet("/mindentermekadatbyid")]
        public async Task<ActionResult<Termekek>> GetTermekekById(int id)
        {
            var termek = await _context.Termekek.FindAsync(id);

            if (termek == null)
            {
                return NotFound();
            }

            return termek;
        }

        [HttpPost("/ujtermek")]
        public async Task<ActionResult<Termekek>> PostTermekek(Termekek termek)
        {
            _context.Termekek.Add(termek);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTermekek", new { id = termek.Id }, termek);
        }

        [HttpPost("/ujvasarlo")]
        public async Task<ActionResult<Vasarlo>> PostVasarlo(Vasarlo vasarlo)
        {
            _context.Vasarlok.Add(vasarlo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVasarlok", new { id = vasarlo.Id }, vasarlo);
        }

        [HttpPost("/ujvasarlas")]
        public async Task<ActionResult<Vasarlasok>> PostVasarlas(Vasarlasok vasarlas)
        {
            _context.Vasarlasok.Add(vasarlas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVasarlasok", new { id = vasarlas.Id }, vasarlas);
        }

        [HttpGet("/getvasarlasok/{id}")]
        public async Task<ActionResult<Vasarlasok>> GetVasarlasok(int id)
        {
            var vasarlas = await _context.Vasarlasok.FindAsync(id);

            if (vasarlas == null)
            {
                return NotFound();
            }

            return vasarlas;
        }

        //e.	Egy vásárló minden vásárlásának adatai (korábbi vásárlások)
        [HttpGet("/getvasarlasokbyvasarlo/{id}")]
        public async Task<ActionResult<IEnumerable<Vasarlasok>>> GetVasarlasokByVasarlo(int id)
        {
            return await _context.Vasarlasok.Where(v => v.VasarloId == id).ToListAsync();
        }
    }
}
