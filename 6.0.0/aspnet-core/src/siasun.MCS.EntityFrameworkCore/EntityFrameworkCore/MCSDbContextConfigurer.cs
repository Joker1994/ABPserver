using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace siasun.MCS.EntityFrameworkCore
{
    public static class MCSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MCSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MCSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
