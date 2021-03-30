
using AutoMapper;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置TP_TaskLogEntity的AutoMapper映射
	/// 前往 <see cref="MCSApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// TP_TaskLogEntityDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class TP_TaskLogEntityDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <TP_TaskLogEntity,TP_TaskLogEntityListDto>();
            configuration.CreateMap <TP_TaskLogEntityListDto,TP_TaskLogEntity>();

            configuration.CreateMap <TP_TaskLogEntityEditDto,TP_TaskLogEntity>();
            configuration.CreateMap <TP_TaskLogEntity,TP_TaskLogEntityEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
