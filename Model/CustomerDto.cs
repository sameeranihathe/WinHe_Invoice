using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public String CustomersName { get; set; }
        public String CustomerEmail { get; set; }
        public String Address { get; set; }
        public String ContactNumber { get; set; }
        public String Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
