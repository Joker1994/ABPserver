

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.EntityMapper.TP_OrderListEntitys
{
    public class TP_OrderListEntityCfg : IEntityTypeConfiguration<TP_OrderListEntity>
    {
        public void Configure(EntityTypeBuilder<TP_OrderListEntity> builder)
        {

			 
      //   builder.ToTable("TP_OrderListEntitys", YoYoAbpefCoreConsts.SchemaNames.CMS);
        builder.ToTable("TP_OrderListEntitys");

            //可以自定义配置参数内容
			
							//// custom codes
									
							

							//// custom codes end
        }
    }
}


