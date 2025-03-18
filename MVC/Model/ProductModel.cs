using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    internal class ProductModel
    {
        private static List<Contatos> contatos = new List<Contatos>();

        public void addProduct(Contatos product) 
        { 
            contatos.Add(product);
        }
        public List<Contatos> getProducts() 
        { 
            return contatos; 
        }
    }
}
