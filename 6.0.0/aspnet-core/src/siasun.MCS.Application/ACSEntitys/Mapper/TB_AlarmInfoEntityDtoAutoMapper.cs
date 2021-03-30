
using AutoMapper;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置TB_AlarmInfoEntity的AutoMapper映射
	/// 前往 <see cref="MCSApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// TB_AlarmInfoEntityDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class TB_AlarmInfoEntityDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <TB_AlarmInfoEntity,TB_AlarmInfoEntityListDto>();
            configuration.CreateMap <TB_AlarmInfoEntityListDto,TB_AlarmInfoEntity>();

            configuration.CreateMap <TB_AlarmInfoEntityEditDto,TB_AlarmInfoEntity>();
            configuration.CreateMap <TB_AlarmInfoEntity,TB_AlarmInfoEntityEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
