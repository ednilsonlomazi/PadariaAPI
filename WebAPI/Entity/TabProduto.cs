using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Entity {

   
    public class TabProduto
    {
        
        public int Id {get; set;}
        public string DesProduto {get; set;}
        public bool IndAtivo {get;set;}
        public int IdFamilia {get;set;}

        public TabProduto()
        {
            this.IndAtivo = true;
            this.DesProduto = "";
        }

        public void Delete()
        {
            this.IndAtivo = false;
        }
    }
}