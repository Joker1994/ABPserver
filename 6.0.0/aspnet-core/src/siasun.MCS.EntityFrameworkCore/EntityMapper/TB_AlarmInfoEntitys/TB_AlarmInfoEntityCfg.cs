

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.EntityMapper.TB_AlarmInfoEntitys
{
    public class TB_AlarmInfoEntityCfg : IEntityTypeConfiguration<TB_AlarmInfoEntity>
    {
        public void Configure(EntityTypeBuilder<TB_AlarmInfoEntity> builder)
        {

			 
      //   builder.ToTable("TB_AlarmInfoEntitys", YoYoAbpefCoreConsts.SchemaNames.CMS);
        builder.ToTable("TB_AlarmInfoEntitys");

            //可以自定义配置参数内容
			
							//// custom codes
									
							

							//// custom codes end
        }
    }
}


