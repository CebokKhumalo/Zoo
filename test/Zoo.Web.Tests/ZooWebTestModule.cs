using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Zoo.EntityFrameworkCore;
using Zoo.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Zoo.Web.Tests
{
    [DependsOn(
        typeof(ZooWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ZooWebTestModule : AbpModule
    {
        public ZooWebTestModule(ZooEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZooWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ZooWebMvcModule).Assembly);
        }
    }
}