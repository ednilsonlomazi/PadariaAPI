using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Entity {
    public class TabLogin
    {
        
        public int Id {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
        public int IdPessoa {get; set;}
        public bool IndAtivo {get;set;}       
        public TabLogin()
        {
            this.IndAtivo = true;
            this.Username = "";
            this.Password = "";
        }

        public void Delete()
        {
            this.IndAtivo = false;
        }

       
    }
}