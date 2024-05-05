using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Entity {
    public class TabPessoa
    {
        
        public int Id {get; set;}
        public string Nome {get; set;}
        public bool IndAtivo {get;set;}
        public List<TabLogradouro> Logradouros {get; set;} 
        public List<TabLogin> Login {get; set;}      
        public TabPessoa()
        {
            this.IndAtivo = true;
            this.Nome = "";
            this.Logradouros = new List<TabLogradouro>();
            this.Login = new List<TabLogin>();
        }

        public void Delete()
        {
            this.IndAtivo = false;
        }

       
    }
}