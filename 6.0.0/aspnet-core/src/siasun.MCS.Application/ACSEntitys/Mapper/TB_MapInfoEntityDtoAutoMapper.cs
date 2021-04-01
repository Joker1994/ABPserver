
using AutoMapper;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置TB_MapInfoEntity的AutoMapper映射
	/// 前往 <see cref="MCSApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// TB_MapInfoEntityDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class TB_MapInfoEntityDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <TB_MapInfoEntity,TB_MapInfoEntityListDto>();
            configuration.CreateMap <TB_MapInfoEntityListDto,TB_MapInfoEntity>();

            configuration.CreateMap <TB_MapInfoEntityEditDto,TB_MapInfoEntity>();
            configuration.CreateMap <TB_MapInfoEntity,TB_MapInfoEntityEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
