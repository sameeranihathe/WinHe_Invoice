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
    public partial class Invoice : Form
    {
        int invoiceNo;
        int cusid;
        InvoiceLogic inlogic = new InvoiceLogic();
       InvoiceLineDto invoiceline = new InvoiceLineDto();
      List<InvoiceLineDto> retunrnlist = new List<InvoiceLineDto>();
        ProductDto obj = new ProductDto();
        public List<ProductDto> firstlist;
        List<string> listing = new List<string>();
        public List<ProductDto> secondlist =new List<ProductDto>();
        
        ProductLogic logic = new ProductLogic();

        public Double TotalPrises=0;
        
        public Invoice()
        {
            InitializeComponent();
        }
        private void SetData()
        {
            List<ProductDto> relist = logic.GetProduct();
            dgv_invoiceshow .DataSource = relist;
            
        }

       
        private void Invoice_Load(object sender, EventArgs e)
        {
            SetData();
            dgv_invoiceshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_invoice2show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            
        }
    
        public void SelectData()
        {
            int RowIndexCheck = dgv_invoiceshow.CurrentCell.RowIndex;

            String ProductIds = dgv_invoiceshow.Rows[RowIndexCheck].Cells["ProductId"].Value.ToString();
            String ProductNames = dgv_invoiceshow.Rows[RowIndexCheck].Cells["ProductName"].Value.ToString();
            String ProductDescriptions = dgv_invoiceshow.Rows[RowIndexCheck].Cells["ProductDescription"].Value.ToString();
            String PurchesPrices = dgv_invoiceshow.Rows[RowIndexCheck].Cells["PurchesePrice"].Value.ToString();
            String SellingPrices = dgv_invoiceshow.Rows[RowIndexCheck].Cells["SellingPrice"].Value.ToString();
            String Quntity = dgv_invoiceshow.Rows[RowIndexCheck].Cells["Quantity"].Value.ToString();

            
            obj.ProductId = Convert.ToInt32(ProductIds);
            obj.ProductName = ProductNames;
            obj.ProductDescription = ProductDescriptions;
            obj.PurchesePrice = Convert.ToDecimal(PurchesPrices);
            obj.SellingPrice = Convert.ToDecimal(SellingPrices);
            obj.Quantity = Convert.ToInt32(Quntity);

            
           
            

           
        }

     
        private void btn_home_Click(object sender, EventArgs e)
        {
            Home HomeWindow = new Home();
            this.Hide();
            HomeWindow.Show();
        }

        private void btn_searchcustomer_Click(object sender, EventArgs e)
        {
            
                SelectCustomer SelectCustomerwindow = new SelectCustomer();
                SelectCustomerwindow.ShowDialog();

                CustomerDto obj = SelectCustomerwindow.obj;

                lbl_showcustomerName.Text = obj.CustomersName;
                cusid = obj.CustomerId;
                SelectCustomerwindow.Dispose();
                

                if (lbl_showcustomerName.Text != "")
                {
                    Double discount = Convert.ToDouble(txt_total.Text) * 0.1;

                    txt_discount.Text = discount.ToString();

                    TotalPrises = Convert.ToDouble(txt_total.Text) - discount;

                    txt_totalprice.Text = TotalPrises.ToString();

                }
          
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String SearchsText = txt_invoicesearch.Text;

            List<ProductDto> Relist = this.logic.GetSearchProduct(SearchsText);

            dgv_invoiceshow.DataSource = Relist;
        }

        private void dgv_invoiceshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectData();
        
            lbl_showproductid.Text = obj.ProductId.ToString();
            lbl_showproductname.Text = obj.ProductName;

         
        }
  
        private void btn_addinvoice_Click(object sender, EventArgs e)
        {


            List<InvoiceLineDto> list = new List<InvoiceLineDto>();
            InvoiceLineDto invoiceline = new InvoiceLineDto();
            InvoiceHeaderDto invoicehead = new InvoiceHeaderDto();

             
                invoiceline.ProductName = obj.ProductName;
                invoiceline.ProductId = obj.ProductId;
                invoiceline.InvoiceUnitPrice = obj.SellingPrice;
                invoiceline.InvoicQuntity = Convert.ToInt32(txt_quntity.Text);
                invoiceline.InvoiceTotalPrice = invoiceline.InvoicQuntity * invoiceline.InvoiceUnitPrice;

                list.Add(invoiceline);

                retunrnlist.AddRange(list);

                dgv_invoice2show.DataSource = null;

                dgv_invoice2show.DataSource = retunrnlist;

                dgv_invoice2show.Columns["InvoiceNumber"].Visible = false;
                dgv_invoice2show.Columns["InvoiceTotalUnit"].Visible = false;

                decimal total = retunrnlist.Select(recode => recode.InvoiceTotalPrice).Sum();

                txt_total.Text = total.ToString();


                if (lbl_showcustomerName.Text == "")
                {

                    txt_discount.Text = "0";

                    TotalPrises = Convert.ToDouble(txt_total.Text) - Convert.ToDouble(txt_discount.Text);

                    txt_totalprice.Text = TotalPrises.ToString();
                }
                else
                {
                    Double discount =Convert.ToDouble(txt_total.Text)*0.1;

                    txt_discount.Text = discount.ToString();

                    TotalPrises = Convert.ToDouble(txt_total.Text) - discount;

                    txt_totalprice.Text = TotalPrises.ToString();
                }
                
                lbl_showproductid.Text = "";
                lbl_showproductname.Text = "";
                txt_quntity.Text = "";

        }

        private void dgv_invoice2show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_invoiceshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void getdatsDb(List<InvoiceLineDto> objs)
        {

            inlogic.datatodB(objs);
        }
      
        private void btn_print_Click(object sender, EventArgs e)
        {
            getdatas();
            for (int i = 0; i <retunrnlist.Count; i++)
            {
                 retunrnlist[i].InvoiceNumber=invoiceNo;
            }
            getdatsDb(retunrnlist);
            getinvoicehederdata();
            Report reportview = new Report();
            this.Hide();
            reportview.Show();

        }

        public void getinvoicehederdata() {

          
            InvoiceHeaderDto inhead = new InvoiceHeaderDto();
            SelectCustomer SelectCustomerwindow = new SelectCustomer();
           

            

            inhead.CustomerId = cusid;
            inhead.InvoiceAmounts =Convert.ToDecimal(txt_totalprice.Text);
            inhead.Discount = Convert.ToDecimal(txt_discount.Text);
            inhead.InvoiceDate = DateTime.Now;

            inlogic.invoiceheaderDB(inhead);
        
        }
        public void getdatas()
        {

          invoiceNo=  inlogic.getdatafrominheaders();
        }
        private void dgv_invoice2show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_viewinvoice_Click(object sender, EventArgs e)
        {
            ViewInvoices ViewInvoiceWindow = new ViewInvoices();
            this.Hide();
            ViewInvoiceWindow.Show();
        }
    }
}
