using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    internal class Contatos
    {
        public string Name { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }


        public Contatos(string name, string whatsapp, string email)
        {
            this.Name = name;
            this.Whatsapp = whatsapp;
            this.Email = email;

        }
    }
    
}
