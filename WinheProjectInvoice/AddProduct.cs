using BussinessLogic;
using Model;
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

    public partial class AddProduct : Form 
    {
        ProductLogic logic = new ProductLogic();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home HomeWindow = new Home();
            this.Hide();
            HomeWindow.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Product ProductWindow = new Product();
            this.Hide();
            ProductWindow.Show();
        }

    
        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            String ProductNames = txt_productname.Text;
            String ProductDescriptions = txt_description.Text;
            Decimal PurchesPrices =Convert.ToDecimal(txt_purchaseprice.Text);
            Decimal SellingPrices = Convert.ToDecimal(txt_sellingprice.Text);
            int Quantitys = Convert.ToInt32(txt_quantity.Text);

            ProductDto obj = new ProductDto();

            obj.ProductName = ProductNames;
            obj.ProductDescription = ProductDescriptions;
            obj.PurchesePrice = PurchesPrices;
            obj.SellingPrice = SellingPrices;
            obj.Quantity = Quantitys;

            logic.AddProduct(obj);

            Product productwindow = new Product();
            this.Hide();
            productwindow.Show();
        }

      
        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
