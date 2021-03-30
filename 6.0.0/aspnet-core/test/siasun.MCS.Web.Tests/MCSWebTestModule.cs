using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using siasun.MCS.EntityFrameworkCore;
using siasun.MCS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace siasun.MCS.Web.Tests
{
    [DependsOn(
        typeof(MCSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MCSWebTestModule : AbpModule
    {
        public MCSWebTestModule(MCSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MCSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MCSWebMvcModule).Assembly);
        }
    }
}