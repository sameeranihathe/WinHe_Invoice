using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InvoiceLineDto
    {
        public int InvoiceNumber { get; set; }
        public int InvoicQuntity { get; set; }
        public int InvoiceTotalUnit { get; set; }
        public Decimal InvoiceTotalPrice { get; set;}
        public Decimal InvoiceUnitPrice { get; set; }
        public String ProductName { get; set; }
        public int ProductId { get; set; }
        
    }
}