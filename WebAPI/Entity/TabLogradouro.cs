using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Entity {
    public class TabLogradouro
    {
        
        public int Id {get; set;}
        public string DescLogradouro {get; set;}
        public bool IndAtivo {get;set;}
        public int IdPessoa {get; set;}

        public TabLogradouro()
        {
            this.IndAtivo = true;
            this.DescLogradouro = "";
        }

        public void Delete()
        {
            this.IndAtivo = false;
        }

       
    }
}