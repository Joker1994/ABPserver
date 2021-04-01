
using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using siasun.MCS.ACSEntitys.Dtos;
using siasun.MCS.ACSEntitys;



namespace siasun.MCS.ACSEntitys
{
    /// <summary>
    /// 应用层服务的接口方法
    ///</summary>
    public interface ITB_AlarmLogEntityAppService : IApplicationService
    {
        /// <summary>
		/// 获取的分页列表集合
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<TB_AlarmLogEntityListDto>> GetPaged(GetTB_AlarmLogEntitysInput input);


		/// <summary>
		/// 通过指定id获取ListDto信息
		/// </summary>
		Task<TB_AlarmLogEntityListDto> GetById(EntityDto<String> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetTB_AlarmLogEntityForEditOutput> GetForEdit(String input);


        /// <summary>
        /// 添加或者修改的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateTB_AlarmLogEntityInput input);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<String> input);

		
        /// <summary>
        /// 批量删除
        /// </summary>
        Task BatchDelete(List<String> input);


		
							//// custom codes
									
							

							//// custom codes end
    }
}
