using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Model;

namespace MVC.Controller
{
    internal class ProductController
    {
        private ProductModel model = new ProductModel();

        public string SaveProduct(string name, string whatsapp, string email) 
        { 
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(whatsapp) || string.IsNullOrWhiteSpace(email)) 
            {
                return "É necessário preencher todos os campos!";
            }
            if(!double.TryParse(whatsapp, out double whatsappconvert)) 
            {
                return "Whatsapp inválido";
            }
            if (!email.Contains("@")) 
            {
                return "E-mail inválido";
            }

            Contatos product = new Contatos(name, whatsapp, email);
            model.addProduct(product);
            return "Contato salvo com sucesso!"; 
        }

        public List<Contatos> GetAllProducts() 
        {
            return model.getProducts();
        
        }

    }
}
