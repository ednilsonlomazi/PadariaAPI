using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Entity {
    public class TabFamilia
    {
        public Guid Id {get; set;}
        public string DesFamilia {get; set;}
        public bool IndAtivo {get;set;}
        
        public TabFamilia()
        {
            this.IndAtivo = true;
        }

       
    }
}