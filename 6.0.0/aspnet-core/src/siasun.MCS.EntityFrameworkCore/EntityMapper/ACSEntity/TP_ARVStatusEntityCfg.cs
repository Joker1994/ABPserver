

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.EntityMapper.ACSEntity
{
    public class TP_ARVStatusEntityCfg : IEntityTypeConfiguration<TP_ARVStatusEntity>
    {
        public void Configure(EntityTypeBuilder<TP_ARVStatusEntity> builder)
        {

			 
      //   builder.ToTable("TP_ARVStatusEntitys", YoYoAbpefCoreConsts.SchemaNames.CMS);
        builder.ToTable("TP_ARVStatusEntitys");

            //可以自定义配置参数内容
			
							//// custom codes
									
							

							//// custom codes end
        }
    }
}


