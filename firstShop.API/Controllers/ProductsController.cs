using AutoMapper;
using firstShop.API.Data;
using firstShop.API.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstShop.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController: Controller
    {
        private readonly IShopRepository _repo;
        private readonly IMapper _mapper;

        public ProductsController(IShopRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _repo.GetProducts();
            var productsToReturn = _mapper.Map<IEnumerable<ProductForListDto>>(products);

            return Ok(productsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _repo.GetProductAsync(id);
            var productToReturn = _mapper.Map<ProductDetailedDto>(product);
            return Ok(product);
        }

        //for Authorize
        //Edit
        //Add
        //Delete
    }
}
