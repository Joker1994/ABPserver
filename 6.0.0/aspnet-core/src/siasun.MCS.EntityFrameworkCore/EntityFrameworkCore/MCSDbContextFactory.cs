using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using siasun.MCS.Configuration;
using siasun.MCS.Web;

namespace siasun.MCS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MCSDbContextFactory : IDesignTimeDbContextFactory<MCSDbContext>
    {
        public MCSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MCSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MCSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MCSConsts.ConnectionStringName));

            return new MCSDbContext(builder.Options);
        }
    }
}
