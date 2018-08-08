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
   
    public partial class ViewInvoices : Form
    {
        InvoiceLogic logic = new InvoiceLogic();
        public ViewInvoices()
        {
            InitializeComponent();
        }
        public void Setdata()
        {
            List<InvoiceHeaderDto> returnlist = logic.getdatainvoices();
            dgv_showinvoices.DataSource = returnlist;

        }
        private void dgv_showproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home homewindow = new Home();
            this.Hide();
            homewindow.Show();
        }
        public void setcmb()
        {
            List<int> retuenlist = logic.invoiceNoDb();
            cmb_invoiceNo.DataSource = retuenlist;
           



        }

        public void setinvoiceNodata()
        {
            int selectvalue = (int)cmb_invoiceNo.SelectedValue;
            List<InvoiceHeaderDto> retuenlist2 = logic.GetsearchinvoNo(selectvalue);
            dgv_showinvoices.DataSource = retuenlist2;




        }
        private void ViewInvoices_Load(object sender, EventArgs e)
        {
            Setdata();
            setcmb();
            dgv_showinvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_showinvoices.Columns["CustomerId"].Visible = false;
            dgv_showinvoices.Columns["Discount"].Visible = false;
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            Invoice invoicewindow = new Invoice();
            this.Hide();
            invoicewindow.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
           String Searchtext = txt_search.Text;
  //         DateTime date = Convert.ToDateTime(txt_search.Text);
          
            List<InvoiceHeaderDto> returnlist = logic.GetsearchResults(Searchtext);
        //    List<InvoiceHeaderDto> returnlist2 = logic.GetsearchResults2(date);
          //  dgv_showinvoices.DataSource = returnlist2;
            dgv_showinvoices.DataSource = returnlist;

           

        }

        private void cmb_invoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txt_searchtext_Click(object sender, EventArgs e)
        {
            setinvoiceNodata();
        }
    }
}
