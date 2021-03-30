
using AutoMapper;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置TP_OrderLogEntity的AutoMapper映射
	/// 前往 <see cref="MCSApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// TP_OrderLogEntityDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class TP_OrderLogEntityDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <TP_OrderLogEntity,TP_OrderLogEntityListDto>();
            configuration.CreateMap <TP_OrderLogEntityListDto,TP_OrderLogEntity>();

            configuration.CreateMap <TP_OrderLogEntityEditDto,TP_OrderLogEntity>();
            configuration.CreateMap <TP_OrderLogEntity,TP_OrderLogEntityEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
