
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
    public interface ITB_MapInfoEntityAppService : IApplicationService
    {
        /// <summary>
		/// 获取的分页列表集合
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<TB_MapInfoEntityListDto>> GetPaged(GetTB_MapInfoEntitysInput input);


        /// <summary>
        /// 通过指定id获取ListDto信息
        /// </summary>
        Task<TB_MapInfoEntityListDto> GetById(EntityDto<string> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetTB_MapInfoEntityForEditOutput> GetForEdit(string input);


        /// <summary>
        /// 添加或者修改的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateTB_MapInfoEntityInput input);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<string> input);


        /// <summary>
        /// 批量删除
        /// </summary>
        Task BatchDelete(List<string> input);



        //// custom codes



        //// custom codes end
    }
}
