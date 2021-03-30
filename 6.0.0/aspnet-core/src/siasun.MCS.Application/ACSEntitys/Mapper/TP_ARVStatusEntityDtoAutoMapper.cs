
using AutoMapper;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置TP_ARVStatusEntity的AutoMapper映射
	/// 前往 <see cref="MCSApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// TP_ARVStatusEntityDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class TP_ARVStatusEntityDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <TP_ARVStatusEntity,TP_ARVStatusEntityListDto>();
            configuration.CreateMap <TP_ARVStatusEntityListDto,TP_ARVStatusEntity>();

            configuration.CreateMap <TP_ARVStatusEntityEditDto,TP_ARVStatusEntity>();
            configuration.CreateMap <TP_ARVStatusEntity,TP_ARVStatusEntityEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
