
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
    public class TP_OrderLogEntityAppService : MCSAppServiceBase, ITP_OrderLogEntityAppService
    {
        private readonly IRepository<TP_OrderLogEntity, long>
            _tP_OrderLogEntityRepository;



        private readonly ITP_OrderLogEntityManager _tP_OrderLogEntityManager;
        /// <summary>
        /// 构造函数
        ///
        //</summary>
        public TP_OrderLogEntityAppService(
        IRepository<TP_OrderLogEntity, long>
tP_OrderLogEntityRepository
            , ITP_OrderLogEntityManager tP_OrderLogEntityManager

            )
        {
            _tP_OrderLogEntityRepository = tP_OrderLogEntityRepository;
            _tP_OrderLogEntityManager = tP_OrderLogEntityManager;


        }


        /// <summary>
        /// 获取的分页列表信息
        ///
        //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Query)]
        public async Task<PagedResultDto<TP_OrderLogEntityListDto>
> GetPaged(GetTP_OrderLogEntitysInput input)
        {

            var query = _tP_OrderLogEntityRepository.GetAll()
            .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.c_Id != null


            );
            // TODO:根据传入的参数添加过滤条件

            var count = await query.CountAsync();

            var tP_OrderLogEntityList = await query
            .OrderBy(input.Sorting).AsNoTracking()
            //.PageBy(input)
            .ToListAsync();

            var tP_OrderLogEntityListDtos = ObjectMapper.Map<List<TP_OrderLogEntityListDto>>(tP_OrderLogEntityList);

            return new PagedResultDto<TP_OrderLogEntityListDto>(count, tP_OrderLogEntityListDtos);
        }


        /// <summary>
        /// 通过指定id获取TP_OrderLogEntityListDto信息
        /// //</summary>
        [AbpAuthorize(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Query)]
        public async Task<TP_OrderLogEntityListDto> GetById(EntityDto<long> input)
        {
            var entity = await _tP_OrderLogEntityRepository.GetAsync(input.Id);

            var dto = ObjectMapper.Map<TP_OrderLogEntityListDto>(entity);
            return dto;
        }

        /// <summary>
        /// 获取编辑 
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Create, TP_OrderLogEntityPermissions.TP_OrderLogEntity_Edit)]
        public async Task<GetTP_OrderLogEntityForEditOutput> GetForEdit(NullableIdDto<long> input)
        {
            var output = new GetTP_OrderLogEntityForEditOutput();
            TP_OrderLogEntityEditDto editDto;

            if (input.Id.HasValue)
            {
                var entity = await _tP_OrderLogEntityRepository.GetAsync(input.Id.Value);
                editDto = ObjectMapper.Map<TP_OrderLogEntityEditDto>(entity);
            }
            else
            {
                editDto = new TP_OrderLogEntityEditDto();
            }



            output.TP_OrderLogEntity = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改的公共方法
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Create, TP_OrderLogEntityPermissions.TP_OrderLogEntity_Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateTP_OrderLogEntityInput input)
        {

            if (input.TP_OrderLogEntity.Id.HasValue)
            {
                await Update(input.TP_OrderLogEntity);
            }
            else
            {
                await Create(input.TP_OrderLogEntity);
            }
        }


        /// <summary>
        /// 新增
        /// //</summary>
        [AbpAuthorize(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Create)]
        protected virtual async Task<TP_OrderLogEntityEditDto> Create(TP_OrderLogEntityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<TP_OrderLogEntity>(input);
            //调用领域服务
            entity = await _tP_OrderLogEntityManager.CreateAsync(entity);

            var dto = ObjectMapper.Map<TP_OrderLogEntityEditDto>(entity);
            return dto;
        }

        /// <summary>
        /// 编辑
        /// //</summary>
        [AbpAuthorize(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Edit)]
        protected virtual async Task Update(TP_OrderLogEntityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _tP_OrderLogEntityRepository.GetAsync(input.Id.Value);
            //  input.MapTo(entity);
            //将input属性的值赋值到entity中
            ObjectMapper.Map(input, entity);
            await _tP_OrderLogEntityManager.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除信息
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Delete)]
        public async Task Delete(EntityDto<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_OrderLogEntityManager.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除TP_OrderLogEntity的方法
        /// //</summary>
        [AbpAuthorize(TP_OrderLogEntityPermissions.TP_OrderLogEntity_BatchDelete)]
        public async Task BatchDelete(List<long> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _tP_OrderLogEntityManager.BatchDelete(input);
        }




        //// custom codes



        //// custom codes end

    }
}


