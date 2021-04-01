
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
    public class TB_AlarmLogEntityAppService : MCSAppServiceBase, ITB_AlarmLogEntityAppService
    {
        private readonly IRepository<TB_AlarmLogEntity, String>
            _tB_AlarmLogEntityRepository;



        private readonly ITB_AlarmLogEntityManager _tB_AlarmLogEntityManager;
        /// <summary>
        /// 构造函数
        ///
        //</summary>
        public TB_AlarmLogEntityAppService(
        IRepository<TB_AlarmLogEntity, String>
tB_AlarmLogEntityRepository
            , ITB_AlarmLogEntityManager tB_AlarmLogEntityManager

            )
        {
            _tB_AlarmLogEntityRepository = tB_AlarmLogEntityRepository;
            _tB_AlarmLogEntityManager = tB_AlarmLogEntityManager;


        }


        /// <summary>
        /// 获取的分页列表信息
        ///
        //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Query)]
        public async Task<PagedResultDto<TB_AlarmLogEntityListDto>
> GetPaged(GetTB_AlarmLogEntitysInput input)
        {

            var query = _tB_AlarmLogEntityRepository.GetAll()
            .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a =>
            a.C_ID != null

            );
            // TODO:根据传入的参数添加过滤条件

            var count = await query.CountAsync();

            var tB_AlarmLogEntityList = await query
            .OrderBy(input.Sorting).AsNoTracking()
            .PageBy(input)
            .ToListAsync();

            var tB_AlarmLogEntityListDtos = ObjectMapper.Map<List<TB_AlarmLogEntityListDto>>(tB_AlarmLogEntityList);

            return new PagedResultDto<TB_AlarmLogEntityListDto>(count, tB_AlarmLogEntityListDtos);
        }


        /// <summary>
        /// 通过指定id获取TB_AlarmLogEntityListDto信息
        /// //</summary>
        [AbpAuthorize(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Query)]
        public async Task<TB_AlarmLogEntityListDto> GetById(EntityDto<String> input)
        {
            var entity = await _tB_AlarmLogEntityRepository.GetAsync(input.Id);

            var dto = ObjectMapper.Map<TB_AlarmLogEntityListDto>(entity);
            return dto;
        }

        /// <summary>
        /// 获取编辑 
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Create, TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Edit)]
        public async Task<GetTB_AlarmLogEntityForEditOutput> GetForEdit(string input)
        {
            var output = new GetTB_AlarmLogEntityForEditOutput();
            TB_AlarmLogEntityEditDto editDto;

            if (!string.IsNullOrEmpty(input))
            {
                var entity = await _tB_AlarmLogEntityRepository.GetAsync(input);
                editDto = ObjectMapper.Map<TB_AlarmLogEntityEditDto>(entity);
            }
            else
            {
                editDto = new TB_AlarmLogEntityEditDto();
            }



            output.TB_AlarmLogEntity = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改的公共方法
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Create, TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateTB_AlarmLogEntityInput input)
        {

            if (!string.IsNullOrEmpty(input.TB_AlarmLogEntity.C_ID))
            {
                await Update(input.TB_AlarmLogEntity);
            }
            else
            {
                await Create(input.TB_AlarmLogEntity);
            }
        }


        /// <summary>
        /// 新增
        /// //</summary>
        [AbpAuthorize(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Create)]
        protected virtual async Task<TB_AlarmLogEntityEditDto> Create(TB_AlarmLogEntityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<TB_AlarmLogEntity>(input);
            //调用领域服务
            entity = await _tB_AlarmLogEntityManager.CreateAsync(entity);

            var dto = ObjectMapper.Map<TB_AlarmLogEntityEditDto>(entity);
            return dto;
        }

        /// <summary>
        /// 编辑
        /// //</summary>
        [AbpAuthorize(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Edit)]
        protected virtual async Task Update(TB_AlarmLogEntityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _tB_AlarmLogEntityRepository.GetAsync(input.C_ID);
            //  input.MapTo(entity);
            //将input属性的值赋值到entity中
            ObjectMapper.Map(input, entity);
            await _tB_AlarmLogEntityManager.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除信息
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Delete)]
        public async Task Delete(EntityDto<String> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tB_AlarmLogEntityManager.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除TB_AlarmLogEntity的方法
        /// //</summary>
        [AbpAuthorize(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_BatchDelete)]
        public async Task BatchDelete(List<String> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _tB_AlarmLogEntityManager.BatchDelete(input);
        }




        //// custom codes



        //// custom codes end

    }
}


