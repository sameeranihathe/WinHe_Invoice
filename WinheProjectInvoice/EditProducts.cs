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
    public partial class EditProducts : Form
    {
        ProductLogic Logic = new ProductLogic();
        public EditProducts()
        {
            InitializeComponent();
        }

        private void EditProducts_Load(object sender, EventArgs e)
        {
            txt_editproid.Enabled = false;
        }
        // Select Data Save in Textbox
        public void selectdatadto(ProductDto one)
        {
            

            txt_editproid.Text = one.ProductId.ToString();
            txt_editproName.Text = one.ProductName;
            txt_editdescription.Text = one.ProductDescription;
            txt_editpurchaseprice.Text = one.PurchesePrice.ToString();
            txt_editsellingprice.Text = one.SellingPrice.ToString();
            txt_editquantity.Text = one.Quantity.ToString();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home HomeWindow = new Home();
            this.Hide();
            HomeWindow.Show();
        }
     /*  public void GetTextProduct(ProductDto dto)
        {

            txt_editproid.Text = dto.ProductId.ToString();
            txt_editproName.Text = dto.ProductName;
            txt_editdescription.Text = dto.ProductDescription;
            txt_editpurchaseprice.Text = dto.PurchesePrice.ToString();
            txt_editsellingprice.Text = dto.SellingPrice.ToString();
            txt_editquantity.Text = dto.Quantity.ToString();





        }      */
        
        private void btn_editproduct_Click(object sender, EventArgs e)
        {
           

            

            ProductDto dto = new ProductDto();
            dto.ProductId = Convert.ToInt32(txt_editproid.Text);
            dto.ProductName = txt_editproName.Text;
            dto.ProductDescription = txt_editdescription.Text;
            dto.PurchesePrice = Convert.ToDecimal(txt_editpurchaseprice.Text);
            dto.SellingPrice = Convert.ToDecimal(txt_editsellingprice.Text);
            dto.Quantity = Convert.ToInt32(txt_editquantity.Text);

            Logic.UppdateLogicData(dto);

            Product pro = new Product();
            this.Hide();
            pro.Show();

        }
    }
}
