
using AutoMapper;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置TP_TaskListEntity的AutoMapper映射
	/// 前往 <see cref="MCSApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// TP_TaskListEntityDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class TP_TaskListEntityDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <TP_TaskListEntity,TP_TaskListEntityListDto>();
            configuration.CreateMap <TP_TaskListEntityListDto,TP_TaskListEntity>();

            configuration.CreateMap <TP_TaskListEntityEditDto,TP_TaskListEntity>();
            configuration.CreateMap <TP_TaskListEntity,TP_TaskListEntityEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
