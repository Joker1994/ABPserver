using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using siasun.MCS.Configuration;
using Microsoft.AspNetCore.Cors;

namespace siasun.MCS.Web.Host.Startup
{
    [DependsOn(
       typeof(MCSWebCoreModule))]
    public class MCSWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MCSWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MCSWebHostModule).GetAssembly());
            var cors = new EnableCorsAttribute();
            cors.PolicyName = "*";
            //GlobalConfiguration.Configuration.EnableCors(cors);
        }
    }
}
