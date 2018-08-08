using DataHadelar;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class CustomerLogic
    {
        CustomerData CusData = new CustomerData();
        public List<CustomerDto> GetCustomerData()
        {
            List<CustomerDto> returnlist = new List<CustomerDto>();

            returnlist = this.CusData.CustomerDataDb();

            return returnlist;
        }

        public List<CustomerDto> GetSearchData(String Seachtext) {

            List<CustomerDto> returnList = new List<CustomerDto>();

            returnList = this.CusData.CustomerSearchData(Seachtext);
            return returnList;
        
        }
        public bool AddCustomerData(CustomerDto Addcustom)
        {
            return this.CusData.CustomerAdding(Addcustom);
        }
    }
}
