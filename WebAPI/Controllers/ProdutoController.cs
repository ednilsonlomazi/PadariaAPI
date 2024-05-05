using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entity;
using WebAPI.Persistence;

namespace WebAPI.Controllers
{
    [Route("api/padaria/produto")]
    [ApiController]
    public class PadariaController : ControllerBase
    {

        private readonly PadariaDbContext padariaDbContext;

        public PadariaController(PadariaDbContext padariaDbContext)
        {
            this.padariaDbContext = padariaDbContext;
        }

        [HttpGet]
        public IActionResult GetAll ()
        {
            return Ok(padariaDbContext.TabProdutos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tabProduto = padariaDbContext.TabProdutos.SingleOrDefault(d => d.Id == id);
            if(tabProduto != null)
            {
                return Ok(tabProduto);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post(TabProduto tabProduto)
        {
            padariaDbContext.TabProdutos.Add(tabProduto);
             
            padariaDbContext.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = tabProduto.Id }, tabProduto);
        }  

        [HttpPut("{id}")]
        public IActionResult Put(int id, TabProduto tabProdutoInput)
        {
            var tabProduto = padariaDbContext.TabProdutos.SingleOrDefault(d => d.Id == id);
            if(tabProduto != null)
            {
                
                padariaDbContext.TabProdutos.Update(tabProdutoInput);
                padariaDbContext.SaveChanges();
                return Ok(tabProduto);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tabProduto = padariaDbContext.TabProdutos.SingleOrDefault(d => d.Id == id);
            if(tabProduto != null)
            {
                tabProduto.Delete();
                padariaDbContext.SaveChanges();
                return Ok();
            }
            return NotFound();
        }        

    }
}