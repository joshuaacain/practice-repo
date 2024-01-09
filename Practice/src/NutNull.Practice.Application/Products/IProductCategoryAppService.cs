using NutNull.Practice.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutNull.Practice.Products
{
    public interface IProductCategoryAppService
    {
        Task<Guid> CreateOrEdit(CreateOrEditProductCategoryDto input);

        Task Delete(Guid id);

        Task<CreateOrEditProductCategoryDto> GetProductCategory(Guid id);

        Task<List<CreateOrEditProductCategoryDto>> GetAll();
    }
}
