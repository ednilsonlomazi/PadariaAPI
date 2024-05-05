using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Entity {
    public class TabFamilia
    {
        
        public int Id {get; set;}
        public string DesFamilia {get; set;}
        public bool IndAtivo {get;set;}
        public List<TabProduto> Produtos {get;set;}

        public TabFamilia()
        {
            this.IndAtivo = true;
            this.Produtos = new List<TabProduto>();
            this.DesFamilia = "";
        }

        public void Delete()
        {
            this.IndAtivo = false;
        }

       
    }
}