using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutNull.Ojt.Products.Dtos
{
  public class CreateOrEditCategoryDto: Entity<Guid?>
    {
        public  string Name { get; set; }
        public  string Description { get; set; }
        public string ExternalId { get; set; }

    }
}
