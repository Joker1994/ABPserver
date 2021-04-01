using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using siasun.MCS.Authorization;
using siasun.MCS.CustomDtoAutoMapper;

namespace siasun.MCS
{
    [DependsOn(
        typeof(MCSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MCSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MCSAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<TP_ARVStatusEntityAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<TB_AlarmLogEntityAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<TP_OrderListEntityAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<TP_OrderLogEntityAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<TP_TaskListEntityAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<TP_TaskLogEntityAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<TB_MapInfoEntityAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                // ....其他代码

                // 只需要复制这一段
                TP_ARVStatusEntityDtoAutoMapper.CreateMappings(configuration);
                TB_AlarmLogEntityDtoAutoMapper.CreateMappings(configuration);
                TP_OrderListEntityDtoAutoMapper.CreateMappings(configuration);
                TP_OrderLogEntityDtoAutoMapper.CreateMappings(configuration);
                TP_TaskListEntityDtoAutoMapper.CreateMappings(configuration);
                TP_TaskLogEntityDtoAutoMapper.CreateMappings(configuration);
                TB_MapInfoEntityDtoAutoMapper.CreateMappings(configuration);
                // ....其他代码
            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MCSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
