using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GeekShopping.ProductAPI.Model.Entity;
using GeekShopping.ProductAPI.ValueObjects;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO,ProductEntity>().ReverseMap();

            });
            return mappingConfig;
        }
    }
}