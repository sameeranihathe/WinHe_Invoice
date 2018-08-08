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
    public partial class Product : Form 
    {
        EditProducts editProductWindow = new EditProducts();
        ProductLogic Logic = new ProductLogic();
        public Product()
        {
            InitializeComponent();
        }

        //get datDatalogic
        private void SetData()
        {
            List<ProductDto> relist = Logic.GetProduct();
            dgv_showproduct.DataSource = relist;

        }

        private void Product_Load(object sender, EventArgs e)
        {
            SetData();
            dgv_showproduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home HomeWindow = new Home();
            this.Hide();
            HomeWindow.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String SearchsText = txt_search.Text;

            List<ProductDto> Relist = this.Logic.GetSearchProduct(SearchsText);

            dgv_showproduct.DataSource = Relist;
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            AddProduct addproductWindow = new AddProduct();
            this.Hide();
            addproductWindow.Show();
        }

        //Select Datas From Grid View And Save ProductDto
        public void SelectData()
        {
             int RowIndexCheck = dgv_showproduct.CurrentCell.RowIndex;

            String ProductIds = dgv_showproduct.Rows[RowIndexCheck].Cells["ProductId"].Value.ToString();
            String ProductNames = dgv_showproduct.Rows[RowIndexCheck].Cells["ProductName"].Value.ToString();
            String ProductDescriptions = dgv_showproduct.Rows[RowIndexCheck].Cells["ProductDescription"].Value.ToString();
            String PurchesPrices = dgv_showproduct.Rows[RowIndexCheck].Cells["PurchesePrice"].Value.ToString();
            String SellingPrices = dgv_showproduct.Rows[RowIndexCheck].Cells["SellingPrice"].Value.ToString();
            String Quntity = dgv_showproduct.Rows[RowIndexCheck].Cells["Quantity"].Value.ToString();

            ProductDto obj = new ProductDto();
            obj.ProductId = Convert.ToInt32(ProductIds);
            obj.ProductName = ProductNames;
            obj.ProductDescription = ProductDescriptions;
            obj.PurchesePrice = Convert.ToDecimal(PurchesPrices);
            obj.SellingPrice = Convert.ToDecimal(SellingPrices);
            obj.Quantity = Convert.ToInt32(Quntity);


            
           
            editProductWindow.selectdatadto(obj);
            this.Hide();
            editProductWindow.Show();



        }
      




        private void dgv_showproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            
           
            
           
        }

        private void dgv_showproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_editproducts_Click(object sender, EventArgs e)
        {
            SelectData();
         
            
           

        }

        private void btn_deleteproducts_Click(object sender, EventArgs e)
        {
            int RowIndex = dgv_showproduct.CurrentCell.RowIndex;
            String ProductId = dgv_showproduct.Rows[RowIndex].Cells["ProductId"].Value.ToString();

            int id = Convert.ToInt32(ProductId);

            Logic.DeleteProduct(id);

            SetData();
        }
    }
}
