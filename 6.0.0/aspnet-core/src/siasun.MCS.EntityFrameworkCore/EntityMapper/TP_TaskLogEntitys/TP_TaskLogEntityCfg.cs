

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.EntityMapper.TP_TaskLogEntitys
{
    public class TP_TaskLogEntityCfg : IEntityTypeConfiguration<TP_TaskLogEntity>
    {
        public void Configure(EntityTypeBuilder<TP_TaskLogEntity> builder)
        {

			 
      //   builder.ToTable("TP_TaskLogEntitys", YoYoAbpefCoreConsts.SchemaNames.CMS);
        builder.ToTable("TP_TaskLogEntitys");

            //可以自定义配置参数内容
			
							//// custom codes
									
							

							//// custom codes end
        }
    }
}


