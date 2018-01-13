using AutoMapper;
using firstShop.API.Dtos;
using firstShop.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstShop.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductForListDto>();
            CreateMap<Product, ProductDetailedDto>();
        }
    }
}
