using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InvoiceHeaderDto
    {

        public int Invoice_No { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Decimal InvoiceAmounts { get; set; }
        public Decimal Discount { get; set; }
        public int CustomerId { get; set; }
        public String CustomerName { get; set; }
    }
}
