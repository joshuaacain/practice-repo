using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using NutNull.Practice.Authorization.Roles;
using NutNull.Practice.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NutNull.Practice.Products
{
    public class ProductCategoryAppService:PracticeAppServiceBase,IProductCategoryAppService
    {
        private readonly IRepository<ProductCategory,Guid> _productCategoryRepository;

        public ProductCategoryAppService(IRepository<ProductCategory,Guid> productCategoryRepository) 
        {
            this._productCategoryRepository = productCategoryRepository;
        }

        public async Task<Guid>CreateOrEdit(CreateOrEditProductCategoryDto input)
        {
            if (input.Id == null)
            {
                var productCategory = this.ObjectMapper.Map<ProductCategory>(input);
                return await this._productCategoryRepository.InsertAndGetIdAsync(productCategory);
                //<------->
                //var productCategory = new ProductCategory
                //{
                //    Name = input.Name,
                //    Description = input.Description,
                //    ExternalId = input.ExternalId,
                //};
                //return await this._productCategoryRepository.InsertAndGetIdAsync(productCategory);
            }
            else
            {
                var productCategory = await this._productCategoryRepository.FirstOrDefaultAsync(input.Id.Value);
                this.ObjectMapper.Map(input, productCategory);
                return productCategory.Id;
                //<------->
                //var productCategory = await this._productCategoryRepository.FirstOrDefaultAsync(input.Id.Value);
                //productCategory.Name = input.Name;
                //productCategory.Description = input.Description;
                //productCategory.ExternalId = input.ExternalId;
                //return productCategory.Id;

            }
        }

        public async Task Delete(Guid id)
        {
            await this._productCategoryRepository.DeleteAsync(id);
        }

        public async Task<CreateOrEditProductCategoryDto>GetProductCategory(Guid id)
        {
            var productCategory = await this._productCategoryRepository.FirstOrDefaultAsync(id);
            //return new CreateOrEditProductCategoryDto
            //{
            //    Name = productCategory.Name,
            //    Description = productCategory.Description,
            //    ExternalId = productCategory.ExternalId,
            //};
            return this.ObjectMapper.Map<CreateOrEditProductCategoryDto>(productCategory);

        }



        public async Task<List<CreateOrEditProductCategoryDto>> GetAll()
        {
            var productCategories = await this._productCategoryRepository.GetAll().ToListAsync();

            var results = new List<CreateOrEditProductCategoryDto>();

            foreach (var productCategory in productCategories)
            {
                results.Add(this.ObjectMapper.Map<CreateOrEditProductCategoryDto>(productCategory));
            }
            return results;


        }
    }
}
