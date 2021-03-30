using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using siasun.MCS.Authorization.Roles;
using siasun.MCS.Authorization.Users;
using siasun.MCS.MultiTenancy;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.EntityFrameworkCore
{
    public class MCSDbContext : AbpZeroDbContext<Tenant, Role, User, MCSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MCSDbContext(DbContextOptions<MCSDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Add-Migration AddNewTP_ARVStatusEntityEntity_Migration
        /// update-database
        /// </summary>
        public DbSet<TP_ARVStatusEntity> TP_ARVStatus { get; set; }
        public DbSet<TB_AlarmInfoEntity> TB_AlarmInfo { get; set; }
        public DbSet<TB_AlarmLogEntity> TB_AlarmLog { get; set; }
        public DbSet<TP_OrderListEntity> TP_OrderList { get; set; }
        public DbSet<TP_OrderLogEntity> TP_OrderLog { get; set; }
        public DbSet<TP_TaskListEntity> TP_TaskList { get; set; }
        public DbSet<TP_TaskLogEntity> TP_TaskLog { get; set; }
    }
}
