
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
    public interface ITP_TaskListEntityAppService : IApplicationService
    {
        /// <summary>
		/// 获取的分页列表集合
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<TP_TaskListEntityListDto>> GetPaged(GetTP_TaskListEntitysInput input);


        /// <summary>
        /// 通过指定id获取ListDto信息
        /// </summary>
        Task<TP_TaskListEntityListDto> GetById(EntityDto<long> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetTP_TaskListEntityForEditOutput> GetForEdit(NullableIdDto<long> input);


        /// <summary>
        /// 添加或者修改的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateTP_TaskListEntityInput input);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<long> input);


        /// <summary>
        /// 批量删除
        /// </summary>
        Task BatchDelete(List<long> input);



        //// custom codes



        //// custom codes end
    }
}
