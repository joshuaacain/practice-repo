using AutoMapper;
using Microsoft.EntityFrameworkCore.Migrations;
using NutNull.Practice.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutNull.Practice.Products.Dtos;


namespace NutNull.Practice
{
    internal static class CustomDtoMapper
    {
        public static void CreatMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CreateOrEditProductCategoryDto, ProductCategory>().ReverseMap();
        }
    }
}
