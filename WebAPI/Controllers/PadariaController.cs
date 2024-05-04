using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entity;
using WebAPI.Persistence;

namespace WebAPI.Controllers
{
    [Route("api/ola-mundo")]
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
            return Ok(padariaDbContext.tabProdutos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var tabProduto = padariaDbContext.tabProdutos.SingleOrDefault(d => d.Id == id);
            if(tabProduto != null)
            {
                return Ok(tabProduto);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post(TabProduto tabProduto)
        {
            padariaDbContext.tabProdutos.Add(tabProduto);

            return CreatedAtAction(nameof(GetById), new { id = tabProduto.Id }, tabProduto);
        }  

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, TabProduto tabProdutoInput)
        {
            var tabProduto = padariaDbContext.tabProdutos.SingleOrDefault(d => d.Id == id);
            if(tabProduto != null)
            {
                tabProduto.Update(tabProdutoInput.DesProduto);
                return Ok(tabProduto);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var tabProduto = padariaDbContext.tabProdutos.SingleOrDefault(d => d.Id == id);
            if(tabProduto != null)
            {
                tabProduto.Delete();
                return Ok();
            }
            return NotFound();
        }        

    }
}