using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NutNull.DemoProject.Authorization.Roles;
using NutNull.DemoProject.Authorization.Users;
using NutNull.DemoProject.MultiTenancy;

namespace NutNull.DemoProject.EntityFrameworkCore
{
    public class DemoProjectDbContext : AbpZeroDbContext<Tenant, Role, User, DemoProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DemoProjectDbContext(DbContextOptions<DemoProjectDbContext> options)
            : base(options)
        {
        }
    }
}
