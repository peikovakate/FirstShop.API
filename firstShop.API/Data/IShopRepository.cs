using firstShop.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstShop.API.Data
{
    public interface IShopRepository
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProductAsync(int id);
    }
}
