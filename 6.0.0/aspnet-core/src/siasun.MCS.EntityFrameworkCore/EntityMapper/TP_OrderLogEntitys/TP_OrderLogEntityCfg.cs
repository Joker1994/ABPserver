

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.EntityMapper.TP_OrderLogEntitys
{
    public class TP_OrderLogEntityCfg : IEntityTypeConfiguration<TP_OrderLogEntity>
    {
        public void Configure(EntityTypeBuilder<TP_OrderLogEntity> builder)
        {

			 
      //   builder.ToTable("TP_OrderLogEntitys", YoYoAbpefCoreConsts.SchemaNames.CMS);
        builder.ToTable("TP_OrderLogEntitys");

            //可以自定义配置参数内容
			
							//// custom codes
									
							

							//// custom codes end
        }
    }
}


