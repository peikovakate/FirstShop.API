using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstShop.API.Models;
using Microsoft.EntityFrameworkCore;

namespace firstShop.API.Data
{
    public class ShopRepository : IShopRepository
    {
        private readonly DataContext _context;


        public ShopRepository(DataContext context)
        {
            _context = context;

        }

        public async Task<Product> GetProductAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}
