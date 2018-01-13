﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstShop.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Category ProductCategory { get; set; }
        public bool IsAvailable { get; set; }
    }
}
