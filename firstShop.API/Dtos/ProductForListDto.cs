using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstShop.API.Dtos
{
    public class ProductForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
