
using AutoMapper;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置TP_OrderListEntity的AutoMapper映射
	/// 前往 <see cref="MCSApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// TP_OrderListEntityDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class TP_OrderListEntityDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <TP_OrderListEntity,TP_OrderListEntityListDto>();
            configuration.CreateMap <TP_OrderListEntityListDto,TP_OrderListEntity>();

            configuration.CreateMap <TP_OrderListEntityEditDto,TP_OrderListEntity>();
            configuration.CreateMap <TP_OrderListEntity,TP_OrderListEntityEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
