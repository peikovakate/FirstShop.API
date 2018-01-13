using firstShop.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstShop.API.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }
        

        public void SeedProducts()
        {
            _context.Products.RemoveRange(_context.Products);
            _context.SaveChanges();

            var productData = System.IO.File.ReadAllText("Data/productDataSeed.json");
            var products = JsonConvert.DeserializeObject<List<Product>>(productData);

            _context.Products.AddRange(products);
            _context.SaveChanges();
        }
    }
}
