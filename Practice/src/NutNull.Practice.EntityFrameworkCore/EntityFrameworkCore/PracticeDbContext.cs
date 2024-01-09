using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NutNull.Practice.Authorization.Roles;
using NutNull.Practice.Authorization.Users;
using NutNull.Practice.MultiTenancy;
using NutNull.Practice.Products;

namespace NutNull.Practice.EntityFrameworkCore
{
    public class PracticeDbContext : AbpZeroDbContext<Tenant, Role, User, PracticeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<ProductCategory>ProductCategories { get; set; }
        public PracticeDbContext(DbContextOptions<PracticeDbContext> options)
            : base(options)
        {
        }
    }
}
