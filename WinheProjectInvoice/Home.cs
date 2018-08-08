using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinheProjectInvoice
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Product ProductWindow = new Product();
            this.Hide();
            ProductWindow.Show();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Customer CustomerWindow = new Customer();
            this.Hide();
            CustomerWindow.Show();
        }

        private void btn_invoices_Click(object sender, EventArgs e)
        {
            Invoice InvoiceWindow = new Invoice();
            this.Hide();
            InvoiceWindow.Show();
        }
    }
}
