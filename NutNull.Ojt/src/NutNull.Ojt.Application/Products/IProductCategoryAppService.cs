using NutNull.Ojt.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutNull.Ojt.Products
{
  public interface IProductCategoryAppService
    {
        Task<Guid> CreateEdit(CreateOrEditCategoryDto input);

        Task Delete(Guid id);

        Task <CreateOrEditCategoryDto>GetProductCategory(Guid id);

        Task<List<CreateOrEditCategoryDto>>GetAll();
    }
}
