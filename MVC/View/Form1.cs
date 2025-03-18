using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controller;
using MVC.Model;

namespace MVC
{
    public partial class Form1 : Form
    {
        private ProductController controller = new ProductController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string whatsapp = txt_price.Text;
            string email = txt_email.Text;
            string msg = controller.SaveProduct(name, whatsapp, email);
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.RefreshDGV();
        }
        private void RefreshDGV() 
        { 
            List<Contatos> contatos = controller.GetAllProducts();
            dgv_products.DataSource = null;
            dgv_products.DataSource = contatos;

        }

    }
}
