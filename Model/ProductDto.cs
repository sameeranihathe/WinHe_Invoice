using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ProductDto
    {
       
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public Decimal PurchesePrice { get; set; }
        public Decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
        
    }
}
