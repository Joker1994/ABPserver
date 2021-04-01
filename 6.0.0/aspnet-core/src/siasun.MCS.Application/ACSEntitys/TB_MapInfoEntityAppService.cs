
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
    public class TB_MapInfoEntityAppService : MCSAppServiceBase, ITB_MapInfoEntityAppService
    {
        private readonly IRepository<TB_MapInfoEntity, string>
            _tB_MapInfoEntityRepository;



        private readonly ITB_MapInfoEntityManager _tB_MapInfoEntityManager;
        /// <summary>
        /// 构造函数
        ///
        //</summary>
        public TB_MapInfoEntityAppService(
        IRepository<TB_MapInfoEntity, string>
tB_MapInfoEntityRepository
            , ITB_MapInfoEntityManager tB_MapInfoEntityManager

            )
        {
            _tB_MapInfoEntityRepository = tB_MapInfoEntityRepository;
            _tB_MapInfoEntityManager = tB_MapInfoEntityManager;


        }


        /// <summary>
        /// 获取的分页列表信息
        ///
        //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Query)]
        public async Task<PagedResultDto<TB_MapInfoEntityListDto>
> GetPaged(GetTB_MapInfoEntitysInput input)
        {

            var query = _tB_MapInfoEntityRepository.GetAll()
            .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a =>a.c_Id != null
            


            );
            // TODO:根据传入的参数添加过滤条件

            var count = await query.CountAsync();

            var tB_MapInfoEntityList = await query
            .OrderBy(input.Sorting).AsNoTracking()
            .PageBy(input)
            .ToListAsync();

            var tB_MapInfoEntityListDtos = ObjectMapper.Map<List<TB_MapInfoEntityListDto>>(tB_MapInfoEntityList);

            return new PagedResultDto<TB_MapInfoEntityListDto>(count, tB_MapInfoEntityListDtos);
        }


        /// <summary>
        /// 通过指定id获取TB_MapInfoEntityListDto信息
        /// //</summary>
        [AbpAuthorize(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Query)]
        public async Task<TB_MapInfoEntityListDto> GetById(EntityDto<string> input)
        {
            var entity = await _tB_MapInfoEntityRepository.GetAsync(input.Id);

            var dto = ObjectMapper.Map<TB_MapInfoEntityListDto>(entity);
            return dto;
        }

        /// <summary>
        /// 获取编辑 
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Create, TB_MapInfoEntityPermissions.TB_MapInfoEntity_Edit)]
        public async Task<GetTB_MapInfoEntityForEditOutput> GetForEdit(string input)
        {
            var output = new GetTB_MapInfoEntityForEditOutput();
            TB_MapInfoEntityEditDto editDto;

            if (!string.IsNullOrEmpty(input))
            {
                var entity = await _tB_MapInfoEntityRepository.GetAsync(input);
                editDto = ObjectMapper.Map<TB_MapInfoEntityEditDto>(entity);
            }
            else
            {
                editDto = new TB_MapInfoEntityEditDto();
            }



            output.TB_MapInfoEntity = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改的公共方法
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Create, TB_MapInfoEntityPermissions.TB_MapInfoEntity_Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateTB_MapInfoEntityInput input)
        {

            if (!string.IsNullOrEmpty(input.TB_MapInfoEntity.c_Id))
            {
                await Update(input.TB_MapInfoEntity);
            }
            else
            {
                await Create(input.TB_MapInfoEntity);
            }
        }


        /// <summary>
        /// 新增
        /// //</summary>
        [AbpAuthorize(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Create)]
        protected virtual async Task<TB_MapInfoEntityEditDto> Create(TB_MapInfoEntityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<TB_MapInfoEntity>(input);
            //调用领域服务
            entity = await _tB_MapInfoEntityManager.CreateAsync(entity);

            var dto = ObjectMapper.Map<TB_MapInfoEntityEditDto>(entity);
            return dto;
        }

        /// <summary>
        /// 编辑
        /// //</summary>
        [AbpAuthorize(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Edit)]
        protected virtual async Task Update(TB_MapInfoEntityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _tB_MapInfoEntityRepository.GetAsync(input.c_Id);
            //  input.MapTo(entity);
            //将input属性的值赋值到entity中
            ObjectMapper.Map(input, entity);
            await _tB_MapInfoEntityManager.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除信息
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Delete)]
        public async Task Delete(EntityDto<string> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tB_MapInfoEntityManager.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除TB_MapInfoEntity的方法
        /// //</summary>
        [AbpAuthorize(TB_MapInfoEntityPermissions.TB_MapInfoEntity_BatchDelete)]
        public async Task BatchDelete(List<string> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _tB_MapInfoEntityManager.BatchDelete(input);
        }




        //// custom codes



        //// custom codes end

    }
}


