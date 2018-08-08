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
    public partial class AddCustomerdata : Form
    {
        CustomerLogic Logic = new CustomerLogic();
        public AddCustomerdata()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home HomeWindow = new Home();
            this.Hide();
            HomeWindow.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customer CustomerWindow = new Customer();
            this.Hide();
            CustomerWindow.Show();
        }

        private void btn_addcustomer_Click(object sender, EventArgs e)
        {
           
            String CustomerNames = txt_customername.Text;
            String CustomerEmails = txt_email.Text;
            String CustomerAddress = txt_address.Text;
            String CustomerContacNumbers = txt_contactnumber.Text;

            String Dob = dob_mounth.SelectionRange.Start.ToShortDateString();


            String value = "";
         
            if (radio_male.Checked)
            {
                value = radio_male.Text;  
            }
            else
            {
                value = radio_female.Text;
            }

            CustomerDto obj = new CustomerDto();

            obj.CustomersName = CustomerNames;
            obj.CustomerEmail = CustomerEmails;
            obj.Address = CustomerAddress;
            obj.ContactNumber = CustomerContacNumbers;
            obj.DateOfBirth =DateTime.Parse(Dob);
            obj.Gender = value;

            Logic.AddCustomerData(obj);

            Customer CustomerWindow = new Customer();
            this.Hide();
            CustomerWindow.Show();
        }

        private void AddCustomerdata_Load(object sender, EventArgs e)
        {

        }
    }
}
