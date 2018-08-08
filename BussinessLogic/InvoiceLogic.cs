using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataHadelar;
namespace BussinessLogic
{
    public class InvoiceLogic
    {
        InvoiceData datainvo = new InvoiceData();
      public void datatodB(List<InvoiceLineDto> obj){

          datainvo.getdatasDB(obj);
          
           
            


        }

      public void invoiceheaderDB(InvoiceHeaderDto obj)
      {

          datainvo.SetdatainvoiceheaderDb(obj);
      }

      public int getdatafrominheaders()
      {

          return datainvo.getdatainvoiceheder();
      }

      public List<InvoiceHeaderDto> getdatainvoices()
      {
          return datainvo.getdatatoallInvoice();

      }

      public List<InvoiceHeaderDto> GetsearchResults(String Searchtext)
      {
          return datainvo.GetsearchResults(Searchtext);
      }

    /* public List<InvoiceHeaderDto> GetsearchResults2(DateTime Searchtext)
      {
          return datainvo.GetsearchResults2(Searchtext);
      }
        */

      public List<int> invoiceNoDb()
      {
          return datainvo.getdatainvoiceNolist();
      }

      public List<InvoiceHeaderDto> GetsearchinvoNo(int No)
      {
          return datainvo.GetsearchResultsInvoiceNo(No);
      }
    }
}
