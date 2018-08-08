using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHadelar
{
    public class InvoiceData
    {
        public void getdatasDB(List<InvoiceLineDto> objs)
        {

            try
               
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {
                    InvoiceLineDetail lineData = new InvoiceLineDetail();


                    
                    for (int i = 0; i <objs.Count; i++)
                    {

                        int invoiceNumbers  = objs[i].InvoiceNumber;
                        int ProductIds = objs[i].ProductId;
                        int quntitys = objs[i].InvoicQuntity;
                        decimal unitprices = objs[i].InvoiceUnitPrice;
                        decimal totalprices = objs[i].InvoiceTotalPrice;


                        InvoiceLineDto godata = new InvoiceLineDto();

                        godata.InvoiceNumber = invoiceNumbers;
                        godata.ProductId = ProductIds;
                        godata.InvoicQuntity = quntitys;
                        godata.InvoiceUnitPrice = unitprices;
                        godata.InvoiceTotalPrice = totalprices;


                        InvoiceLineDetail inlineDb = new InvoiceLineDetail();

                        inlineDb.Invoice_No = godata.InvoiceNumber;
                        inlineDb.Product_Id = godata.ProductId;
                        inlineDb.Qntity = godata.InvoicQuntity;
                        inlineDb.Unit_Price = godata.InvoiceUnitPrice;
                        inlineDb.Total_Price = godata.InvoiceTotalPrice;

                        context.InvoiceLineDetails.Add(inlineDb);
                        context.SaveChanges();
                    }




                }

            }
            catch (Exception ex)
            {


            }


        }
        public void SetdatainvoiceheaderDb(InvoiceHeaderDto objs)
        {
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {
                    InvoiceHeaderDetail invoicehedetdatas = new InvoiceHeaderDetail();


                    invoicehedetdatas.Customer_Id = objs.CustomerId;
                    invoicehedetdatas.Invoice_Date = objs.InvoiceDate;
                    invoicehedetdatas.Discount = objs.Discount;
                    invoicehedetdatas.Invoice_Amount = objs.InvoiceAmounts;

                    context.InvoiceHeaderDetails.Add(invoicehedetdatas);

                    context.SaveChanges();




                }
            }
            catch (Exception ex)
            {


            }
        }

        public int getdatainvoiceheder()
        {
            int invoiceNO = 0;
            List<InvoiceHeaderDto> detaillist = new List<InvoiceHeaderDto>();
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    invoiceNO = (from recode in context.InvoiceHeaderDetails select recode.Invoice_No).ToList().Max();







                }
            }
            catch (Exception ex)
            {

            }
            return invoiceNO;
        }

        public List<InvoiceHeaderDto> getdatatoallInvoice(){
            List<InvoiceHeaderDto> Data = new List<InvoiceHeaderDto>();
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {
                    
                 var query= from InvoiceHeader in context.InvoiceHeaderDetails join Customer in context.CustomersDetails on InvoiceHeader.Customer_Id equals Customer.Customer_Id select new { InvoiceHeader.Invoice_No, InvoiceHeader.Invoice_Date, InvoiceHeader.Invoice_Amount, Customer.Customer_Name };

                 foreach (var item in query)
                 {
                     InvoiceHeaderDto head = new InvoiceHeaderDto();
                     head.Invoice_No = item.Invoice_No;
                     head.CustomerName = item.Customer_Name;
                     head.InvoiceAmounts = item.Invoice_Amount;
                     head.InvoiceDate = item.Invoice_Date;

                     Data.Add(head);

                 }
                
                }

            }
            catch (Exception ex)
            {

            }

            return Data;
        }


        public List<InvoiceHeaderDto> GetsearchResults(String Searchtext)
        {
            List<InvoiceHeaderDto> Data = new List<InvoiceHeaderDto>();
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    var query = from InvoiceHeader in context.InvoiceHeaderDetails join Customer in context.CustomersDetails on InvoiceHeader.Customer_Id equals Customer.Customer_Id where(Customer.Customer_Name.Contains(Searchtext) ) select new { InvoiceHeader.Invoice_No, InvoiceHeader.Invoice_Date, InvoiceHeader.Invoice_Amount, Customer.Customer_Name };

                    foreach (var item in query)
                    {
                        InvoiceHeaderDto head = new InvoiceHeaderDto();
                        head.Invoice_No = item.Invoice_No;
                        head.CustomerName = item.Customer_Name;
                        head.InvoiceAmounts = item.Invoice_Amount;
                        head.InvoiceDate = item.Invoice_Date;

                        Data.Add(head);

                    }

                }

            }
            catch (Exception ex)
            {

            }

            return Data;
        }

     /*  public List<InvoiceHeaderDto> GetsearchResults2(DateTime Searchtext)
        {
          
            List<InvoiceHeaderDto> Data = new List<InvoiceHeaderDto>();
        
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    var query = from InvoiceHeader in context.InvoiceHeaderDetails join Customer in context.CustomersDetails on InvoiceHeader.Customer_Id equals Customer.Customer_Id where(InvoiceHeader.Invoice_Date.Equals(Searchtext)) select new { InvoiceHeader.Invoice_No, InvoiceHeader.Invoice_Date, InvoiceHeader.Invoice_Amount, Customer.Customer_Name };

                    foreach (var item in query)
                    {
                        InvoiceHeaderDto head = new InvoiceHeaderDto();
                        head.Invoice_No = item.Invoice_No;
                        head.CustomerName = item.Customer_Name;
                        head.InvoiceAmounts = item.Invoice_Amount;
                        head.InvoiceDate = item.Invoice_Date;

                        Data.Add(head);

                    }

                }

            }
            catch (Exception ex)
            {

            }

            return Data;
        }*/

        public List<int> getdatainvoiceNolist()
        {
            List<int> list =new List<int>();
           
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {
                    
                list  =  (from recode in context.InvoiceHeaderDetails select recode.Invoice_No).ToList();







                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }


        public List<InvoiceHeaderDto> GetsearchResultsInvoiceNo(int Searchtext)
        {
            List<InvoiceHeaderDto> Data = new List<InvoiceHeaderDto>();
            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    var query = from InvoiceHeader in context.InvoiceHeaderDetails join Customer in context.CustomersDetails on InvoiceHeader.Customer_Id equals Customer.Customer_Id where (InvoiceHeader.Invoice_No.Equals(Searchtext)) select new { InvoiceHeader.Invoice_No, InvoiceHeader.Invoice_Date, InvoiceHeader.Invoice_Amount, Customer.Customer_Name };

                    foreach (var item in query)
                    {
                        InvoiceHeaderDto head = new InvoiceHeaderDto();
                        head.Invoice_No = item.Invoice_No;
                        head.CustomerName = item.Customer_Name;
                        head.InvoiceAmounts = item.Invoice_Amount;
                        head.InvoiceDate = item.Invoice_Date;

                        Data.Add(head);

                    }

                }

            }
            catch (Exception ex)
            {

            }

            return Data;
        }
    }
}
