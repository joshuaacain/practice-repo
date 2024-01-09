using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using NutNull.Ojt.Authorization.Roles;
using NutNull.Ojt.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutNull.Ojt.Products
{
    public class ProductCategoryAppService:OjtAppServiceBase, IProductCategoryAppService
    {
        private readonly IRepository<ProductCategory, Guid> _productCategoryRepository;


        public ProductCategoryAppService(IRepository<ProductCategory,Guid> productCategoryRepository)
        {
            this._productCategoryRepository = productCategoryRepository;
        }
        

        public async Task<Guid> CreateEdit(CreateOrEditCategoryDto input)
        {

            if (input.Id == null)
            {
                // New Product

                //var productCategory = new ProductCategory
                //{
                //    Name = input.Name,
                //    Description = input.Description,
                //    ExternalId = input.ExternalId,
                //};
                var productCategory = this.ObjectMapper.Map<ProductCategory>(input);
                return await this._productCategoryRepository.InsertAndGetIdAsync(productCategory);
            }
            else
            {
                // Update

                var productCategory = await this._productCategoryRepository.FirstOrDefaultAsync(input.Id.Value);
                this.ObjectMapper.Map(input, productCategory);

                //productCategory.Name = input.Name;
                //productCategory.Description = input.Description;
                //productCategory.ExternalId = input.ExternalId;

                return productCategory.Id; 
            }
        }

        public async Task Delete(Guid id)
        {
            await this._productCategoryRepository.DeleteAsync(id);
        }

        public async Task<CreateOrEditCategoryDto> GetProductCategory(Guid id)
        {
            var productCategory = await this._productCategoryRepository.FirstOrDefaultAsync(id);
            //return new CreateOrEditCategoryDto
            //{
            //    Name= productCategory.Name,
            //    Description= productCategory.Description,
            //    ExternalId= productCategory.ExternalId,
            //};
            return this.ObjectMapper.Map<CreateOrEditCategoryDto>(productCategory);
        }

        public async Task<List<CreateOrEditCategoryDto>> GetAll()
        {
            var productCategories = await this._productCategoryRepository.GetAll().ToListAsync();

            var results = new List<CreateOrEditCategoryDto>();

            foreach(var productCategory in productCategories)
            {
                results.Add(this.ObjectMapper.Map<CreateOrEditCategoryDto>(productCategory));
            }
            return results;
        }
    }
}
 