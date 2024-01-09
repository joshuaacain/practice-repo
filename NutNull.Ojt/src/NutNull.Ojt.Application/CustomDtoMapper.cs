using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NutNull.Ojt.Products;
using NutNull.Ojt.Products.Dtos;
using System.Configuration;

namespace NutNull.Ojt
{
    internal static class CustomDtoMapper
    {
        public static void CreatMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CreateOrEditCategoryDto, ProductCategory>().ReverseMap();
        }
    }
}
