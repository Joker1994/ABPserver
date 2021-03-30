
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
    public class TP_TaskLogEntityAppService : MCSAppServiceBase, ITP_TaskLogEntityAppService
    {
        private readonly IRepository<TP_TaskLogEntity, long>
            _tP_TaskLogEntityRepository;



        private readonly ITP_TaskLogEntityManager _tP_TaskLogEntityManager;
        /// <summary>
        /// 构造函数
        ///
        //</summary>
        public TP_TaskLogEntityAppService(
        IRepository<TP_TaskLogEntity, long>
tP_TaskLogEntityRepository
            , ITP_TaskLogEntityManager tP_TaskLogEntityManager

            )
        {
            _tP_TaskLogEntityRepository = tP_TaskLogEntityRepository;
            _tP_TaskLogEntityManager = tP_TaskLogEntityManager;


        }


        /// <summary>
        /// 获取的分页列表信息
        ///
        //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Query)]
        public async Task<PagedResultDto<TP_TaskLogEntityListDto>
> GetPaged(GetTP_TaskLogEntitysInput input)
        {

            var query = _tP_TaskLogEntityRepository.GetAll()
            .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.c_Id != null


            );
            // TODO:根据传入的参数添加过滤条件

            var count = await query.CountAsync();

            var tP_TaskLogEntityList = await query
            .OrderBy(input.Sorting).AsNoTracking()
            //.PageBy(input)
            .ToListAsync();

            var tP_TaskLogEntityListDtos = ObjectMapper.Map<List<TP_TaskLogEntityListDto>>(tP_TaskLogEntityList);

            return new PagedResultDto<TP_TaskLogEntityListDto>(count, tP_TaskLogEntityListDtos);
        }


        /// <summary>
        /// 通过指定id获取TP_TaskLogEntityListDto信息
        /// //</summary>
        [AbpAuthorize(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Query)]
        public async Task<TP_TaskLogEntityListDto> GetById(EntityDto<long> input)
        {
            var entity = await _tP_TaskLogEntityRepository.GetAsync(input.Id);

            var dto = ObjectMapper.Map<TP_TaskLogEntityListDto>(entity);
            return dto;
        }

        /// <summary>
        /// 获取编辑 
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Create, TP_TaskLogEntityPermissions.TP_TaskLogEntity_Edit)]
        public async Task<GetTP_TaskLogEntityForEditOutput> GetForEdit(NullableIdDto<long> input)
        {
            var output = new GetTP_TaskLogEntityForEditOutput();
            TP_TaskLogEntityEditDto editDto;

            if (input.Id.HasValue)
            {
                var entity = await _tP_TaskLogEntityRepository.GetAsync(input.Id.Value);
                editDto = ObjectMapper.Map<TP_TaskLogEntityEditDto>(entity);
            }
            else
            {
                editDto = new TP_TaskLogEntityEditDto();
            }



            output.TP_TaskLogEntity = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改的公共方法
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Create, TP_TaskLogEntityPermissions.TP_TaskLogEntity_Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateTP_TaskLogEntityInput input)
        {

            if (input.TP_TaskLogEntity.Id.HasValue)
            {
                await Update(input.TP_TaskLogEntity);
            }
            else
            {
                await Create(input.TP_TaskLogEntity);
            }
        }


        /// <summary>
        /// 新增
        /// //</summary>
        [AbpAuthorize(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Create)]
        protected virtual async Task<TP_TaskLogEntityEditDto> Create(TP_TaskLogEntityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<TP_TaskLogEntity>(input);
            //调用领域服务
            entity = await _tP_TaskLogEntityManager.CreateAsync(entity);

            var dto = ObjectMapper.Map<TP_TaskLogEntityEditDto>(entity);
            return dto;
        }

        /// <summary>
        /// 编辑
        /// //</summary>
        [AbpAuthorize(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Edit)]
        protected virtual async Task Update(TP_TaskLogEntityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _tP_TaskLogEntityRepository.GetAsync(input.Id.Value);
            //  input.MapTo(entity);
            //将input属性的值赋值到entity中
            ObjectMapper.Map(input, entity);
            await _tP_TaskLogEntityManager.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除信息
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Delete)]
        public async Task Delete(EntityDto<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_TaskLogEntityManager.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除TP_TaskLogEntity的方法
        /// //</summary>
        [AbpAuthorize(TP_TaskLogEntityPermissions.TP_TaskLogEntity_BatchDelete)]
        public async Task BatchDelete(List<long> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _tP_TaskLogEntityManager.BatchDelete(input);
        }




        //// custom codes



        //// custom codes end

    }
}


