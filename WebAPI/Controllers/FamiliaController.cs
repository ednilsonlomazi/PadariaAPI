using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entity;
using WebAPI.Persistence;

namespace WebAPI.Controllers
{
    [Route("api/padaria/familia")]
    [ApiController]
    public class FamiliaController : ControllerBase
    {

        private readonly PadariaDbContext padariaDbContext;

        public FamiliaController(PadariaDbContext padariaDbContext)
        {
            this.padariaDbContext = padariaDbContext;
        }

        [HttpGet]
        public IActionResult GetAll ()
        {
            return Ok(padariaDbContext.TabFamilia);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tabFamilia = padariaDbContext.TabFamilia.SingleOrDefault(d => d.Id == id);
            if(tabFamilia != null)
            {
                return Ok(tabFamilia);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post(TabFamilia tabFamilia)
        {
            padariaDbContext.TabFamilia.Add(tabFamilia);
            padariaDbContext.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = tabFamilia.Id }, tabFamilia);
        }  

        [HttpPut("{id}")]
        public IActionResult Put(int id, TabFamilia tabFamiliaInput)
        {
            var tabFamilia = padariaDbContext.TabFamilia.SingleOrDefault(d => d.Id == id);
            if(tabFamilia != null)
            {
                 
                padariaDbContext.TabFamilia.Update(tabFamiliaInput);
                padariaDbContext.SaveChanges();
                return Ok(tabFamilia);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tabFamilia = padariaDbContext.TabFamilia.SingleOrDefault(d => d.Id == id);
            if(tabFamilia != null)
            {
                tabFamilia.Delete();
                padariaDbContext.SaveChanges();
                return Ok();
            }
            return NotFound();
        }        

    }
}