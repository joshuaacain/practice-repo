using Abp.MultiTenancy;
using NutNull.DemoProject.Authorization.Users;

namespace NutNull.DemoProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
