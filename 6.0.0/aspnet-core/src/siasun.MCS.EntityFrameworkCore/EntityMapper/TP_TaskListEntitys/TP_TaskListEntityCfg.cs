

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.EntityMapper.TP_TaskListEntitys
{
    public class TP_TaskListEntityCfg : IEntityTypeConfiguration<TP_TaskListEntity>
    {
        public void Configure(EntityTypeBuilder<TP_TaskListEntity> builder)
        {

			 
      //   builder.ToTable("TP_TaskListEntitys", YoYoAbpefCoreConsts.SchemaNames.CMS);
        builder.ToTable("TP_TaskListEntitys");

            //可以自定义配置参数内容
			
							//// custom codes
									
							

							//// custom codes end
        }
    }
}


