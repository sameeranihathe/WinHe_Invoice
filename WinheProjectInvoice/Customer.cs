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
    public partial class Customer : Form
    {
        CustomerLogic logic = new CustomerLogic();
        public Customer()
        {
            InitializeComponent();
        }
        public void SetData(){
            List<CustomerDto> relist = this.logic.GetCustomerData();
            dgv_showcustomers.DataSource = relist;

        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            Home HomeWindow = new Home();
            this.Hide();
            HomeWindow.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SetData();
            dgv_showcustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String SearchText = txt_search.Text;

            List<CustomerDto> relist = logic.GetSearchData(SearchText);

            dgv_showcustomers.DataSource = relist;
        }

        private void btn_addcustomer_Click(object sender, EventArgs e)
        {
            AddCustomerdata addcustomerwindow = new AddCustomerdata();
            this.Hide();
            addcustomerwindow.Show();
        }

        private void dgv_showcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
