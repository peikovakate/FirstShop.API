using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstShop.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
