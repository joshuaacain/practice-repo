﻿using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NutNull.Ojt.EntityFrameworkCore;
using NutNull.Ojt.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace NutNull.Ojt.Web.Tests
{
    [DependsOn(
        typeof(OjtWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class OjtWebTestModule : AbpModule
    {
        public OjtWebTestModule(OjtEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OjtWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(OjtWebMvcModule).Assembly);
        }
    }
}