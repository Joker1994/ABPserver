
using AutoMapper;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置TB_AlarmLogEntity的AutoMapper映射
	/// 前往 <see cref="MCSApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// TB_AlarmLogEntityDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class TB_AlarmLogEntityDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <TB_AlarmLogEntity,TB_AlarmLogEntityListDto>();
            configuration.CreateMap <TB_AlarmLogEntityListDto,TB_AlarmLogEntity>();

            configuration.CreateMap <TB_AlarmLogEntityEditDto,TB_AlarmLogEntity>();
            configuration.CreateMap <TB_AlarmLogEntity,TB_AlarmLogEntityEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
