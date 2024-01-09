using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NutNull.Ojt.Authorization.Roles;
using NutNull.Ojt.Authorization.Users;
using NutNull.Ojt.MultiTenancy;
using NutNull.Ojt.Products;

namespace NutNull.Ojt.EntityFrameworkCore
{
    public class OjtDbContext : AbpZeroDbContext<Tenant, Role, User, OjtDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<ProductCategory>ProductCategories { get; set; }

        public OjtDbContext(DbContextOptions<OjtDbContext> options)
            : base(options)
        {
        }
    }
} 
