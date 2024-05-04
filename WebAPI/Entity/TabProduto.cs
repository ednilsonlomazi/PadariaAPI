using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Entity {
    public class TabProduto
    {
        public Guid Id {get; set;}
        public string DesProduto {get; set;}
        public bool IndAtivo {get;set;}
        public Guid Familia {get; set;}
        public TabFamilia tabFamilia {get;set;}
        public TabProduto()
        {
            this.IndAtivo = true;
        }

        public void Update(string des_produto)
        {
            this.DesProduto = des_produto;
        }

        public void Delete()
        {
            this.IndAtivo = false;
        }
    }
}