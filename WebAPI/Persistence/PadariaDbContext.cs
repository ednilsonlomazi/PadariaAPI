using WebAPI.Entity;

namespace WebAPI.Persistence 
{
    public class PadariaDbContext
    {
        public List<TabProduto> tabProdutos {get; set;}
        public PadariaDbContext()
        {
            this.tabProdutos = new List<TabProduto>();
        }
        
    }


}