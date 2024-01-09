using Abp.MultiTenancy;
using NutNull.Ojt.Authorization.Users;

namespace NutNull.Ojt.MultiTenancy
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
