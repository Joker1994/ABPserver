
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;
using siasun.MCS.ACSEntitys.DomainService;
using siasun.MCS.Authorization;

namespace siasun.MCS.ACSEntitys
{
    /// <summary>
    /// 应用层服务的接口实现方法
    ///
//</summary>
    [AbpAuthorize]
    public class TP_TaskListEntityAppService : MCSAppServiceBase, ITP_TaskListEntityAppService
    {
        private readonly IRepository<TP_TaskListEntity, long>
            _tP_TaskListEntityRepository;



        private readonly ITP_TaskListEntityManager _tP_TaskListEntityManager;
        /// <summary>
        /// 构造函数
        ///
        //</summary>
        public TP_TaskListEntityAppService(
        IRepository<TP_TaskListEntity, long>
tP_TaskListEntityRepository
            , ITP_TaskListEntityManager tP_TaskListEntityManager

            )
        {
            _tP_TaskListEntityRepository = tP_TaskListEntityRepository;
            _tP_TaskListEntityManager = tP_TaskListEntityManager;


        }


        /// <summary>
        /// 获取的分页列表信息
        ///
        //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_TaskListEntityPermissions.TP_TaskListEntity_Query)]
        public async Task<PagedResultDto<TP_TaskListEntityListDto>
> GetPaged(GetTP_TaskListEntitysInput input)
        {

            var query = _tP_TaskListEntityRepository.GetAll()
            .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.c_Id != null


            );
            // TODO:根据传入的参数添加过滤条件

            var count = await query.CountAsync();

            var tP_TaskListEntityList = await query
            .OrderBy(input.Sorting).AsNoTracking()
            //.PageBy(input)
            .ToListAsync();

            var tP_TaskListEntityListDtos = ObjectMapper.Map<List<TP_TaskListEntityListDto>>(tP_TaskListEntityList);

            return new PagedResultDto<TP_TaskListEntityListDto>(count, tP_TaskListEntityListDtos);
        }


        /// <summary>
        /// 通过指定id获取TP_TaskListEntityListDto信息
        /// //</summary>
        [AbpAuthorize(TP_TaskListEntityPermissions.TP_TaskListEntity_Query)]
        public async Task<TP_TaskListEntityListDto> GetById(EntityDto<long> input)
        {
            var entity = await _tP_TaskListEntityRepository.GetAsync(input.Id);

            var dto = ObjectMapper.Map<TP_TaskListEntityListDto>(entity);
            return dto;
        }

        /// <summary>
        /// 获取编辑 
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_TaskListEntityPermissions.TP_TaskListEntity_Create, TP_TaskListEntityPermissions.TP_TaskListEntity_Edit)]
        public async Task<GetTP_TaskListEntityForEditOutput> GetForEdit(NullableIdDto<long> input)
        {
            var output = new GetTP_TaskListEntityForEditOutput();
            TP_TaskListEntityEditDto editDto;

            if (input.Id.HasValue)
            {
                var entity = await _tP_TaskListEntityRepository.GetAsync(input.Id.Value);
                editDto = ObjectMapper.Map<TP_TaskListEntityEditDto>(entity);
            }
            else
            {
                editDto = new TP_TaskListEntityEditDto();
            }



            output.TP_TaskListEntity = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改的公共方法
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_TaskListEntityPermissions.TP_TaskListEntity_Create, TP_TaskListEntityPermissions.TP_TaskListEntity_Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateTP_TaskListEntityInput input)
        {

            if (input.TP_TaskListEntity.Id.HasValue)
            {
                await Update(input.TP_TaskListEntity);
            }
            else
            {
                await Create(input.TP_TaskListEntity);
            }
        }


        /// <summary>
        /// 新增
        /// //</summary>
        [AbpAuthorize(TP_TaskListEntityPermissions.TP_TaskListEntity_Create)]
        protected virtual async Task<TP_TaskListEntityEditDto> Create(TP_TaskListEntityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<TP_TaskListEntity>(input);
            //调用领域服务
            entity = await _tP_TaskListEntityManager.CreateAsync(entity);

            var dto = ObjectMapper.Map<TP_TaskListEntityEditDto>(entity);
            return dto;
        }

        /// <summary>
        /// 编辑
        /// //</summary>
        [AbpAuthorize(TP_TaskListEntityPermissions.TP_TaskListEntity_Edit)]
        protected virtual async Task Update(TP_TaskListEntityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _tP_TaskListEntityRepository.GetAsync(input.Id.Value);
            //  input.MapTo(entity);
            //将input属性的值赋值到entity中
            ObjectMapper.Map(input, entity);
            await _tP_TaskListEntityManager.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除信息
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_TaskListEntityPermissions.TP_TaskListEntity_Delete)]
        public async Task Delete(EntityDto<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_TaskListEntityManager.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除TP_TaskListEntity的方法
        /// //</summary>
        [AbpAuthorize(TP_TaskListEntityPermissions.TP_TaskListEntity_BatchDelete)]
        public async Task BatchDelete(List<long> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _tP_TaskListEntityManager.BatchDelete(input);
        }




        //// custom codes



        //// custom codes end

    }
}


