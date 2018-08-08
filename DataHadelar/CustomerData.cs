using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHadelar
{
    public class CustomerData
    {
        public List<CustomerDto> CustomerDataDb()
        {
            List<CustomerDto> CustomerList = new List<CustomerDto>();
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {
                    List<CustomersDetail> list = (from recode in context.CustomersDetails select recode).ToList();

                    foreach (CustomersDetail item in list)
                    {
                        CustomerDto obj = new CustomerDto();

                        obj.CustomerId = item.Customer_Id;
                        obj.CustomersName = item.Customer_Name;
                        obj.CustomerEmail = item.Customer_Email;
                        obj.Address = item.Address;
                        obj.ContactNumber = item.Contact_Number;
                        obj.Gender = item.Gender;
                        obj.DateOfBirth = item.Date_of_Birth;

                        CustomerList.Add(obj);
                    }

                }
            }
            catch (Exception ex)
            {


            }

            return CustomerList;
        }

        public List<CustomerDto> CustomerSearchData(String SearchText)
        {
            List<CustomerDto> Customerlist = new List<CustomerDto>();

            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {
                    List<CustomersDetail> list = (from recode in context.CustomersDetails where (recode.Customer_Name.Contains(SearchText)) select recode).ToList();

                    foreach (CustomersDetail item in list)
                    {
                        CustomerDto obj = new CustomerDto();

                        obj.CustomerId = item.Customer_Id;
                        obj.CustomersName = item.Customer_Name;
                        obj.CustomerEmail = item.Customer_Email;
                        obj.Address = item.Address;
                        obj.ContactNumber = item.Contact_Number;
                        obj.Gender = item.Gender;
                        obj.DateOfBirth = item.Date_of_Birth;

                        Customerlist.Add(obj);

                    }
                }

            }
            catch (Exception ex)
            {


            }
            return Customerlist;
        }

        public bool CustomerAdding(CustomerDto CusAddDb)
        {
            bool isSaved = false;
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {
                    CustomersDetail cusdetails = new CustomersDetail();

                    
                    cusdetails.Customer_Name = CusAddDb.CustomersName;
                    cusdetails.Customer_Email = CusAddDb.CustomerEmail;
                    cusdetails.Contact_Number = CusAddDb.ContactNumber;
                    cusdetails.Date_of_Birth = CusAddDb.DateOfBirth;
                    cusdetails.Address = CusAddDb.Address;
                    cusdetails.Gender = CusAddDb.Gender;

                    context.CustomersDetails.Add(cusdetails);

                    context.SaveChanges();
 
 
 
 
              }
            }
            catch (Exception ex)
            {



            }




            return isSaved;


        }
    }
}
