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
    
    public partial class SelectCustomer : Form
    {
        Invoice invoicewindow = new Invoice();
        public CustomerDto obj = new CustomerDto();
        CustomerLogic logic = new CustomerLogic();
        public SelectCustomer()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String SearchText = txt_searchtext.Text;

            List<CustomerDto> relist = logic.GetSearchData(SearchText);

            dgv_selectcustomer.DataSource = relist;
        }

        public void SetData()
        {
            List<CustomerDto> relist = this.logic.GetCustomerData();
            dgv_selectcustomer.DataSource = relist;

        }
        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            SetData();
        }

        public void SelectData()
        {
            int RowIndexCheck = dgv_selectcustomer.CurrentCell.RowIndex;

            String CustomerId = dgv_selectcustomer.Rows[RowIndexCheck].Cells["CustomerId"].Value.ToString();
            String CustomerNames = dgv_selectcustomer.Rows[RowIndexCheck].Cells["CustomersName"].Value.ToString();


            
            obj.CustomerId= Convert.ToInt32(CustomerId);
            obj.CustomersName = CustomerNames;

            txt_cusid.Text = obj.CustomerId.ToString();
            txt_cusname.Text = obj.CustomersName;

        }
        private void dgv_selectcustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectData();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {


            this.Hide();
           

        }

        private void dgv_selectcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
