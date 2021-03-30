
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
    public class TB_AlarmInfoEntityAppService : MCSAppServiceBase, ITB_AlarmInfoEntityAppService
    {
        private readonly IRepository<TB_AlarmInfoEntity, long>_tB_AlarmInfoEntityRepository;



        private readonly ITB_AlarmInfoEntityManager _tB_AlarmInfoEntityManager;
        /// <summary>
        /// 构造函数
        ///
        //</summary>
        public TB_AlarmInfoEntityAppService(IRepository<TB_AlarmInfoEntity, long>tB_AlarmInfoEntityRepository , ITB_AlarmInfoEntityManager tB_AlarmInfoEntityManager)
        {
            _tB_AlarmInfoEntityRepository = tB_AlarmInfoEntityRepository;
            _tB_AlarmInfoEntityManager = tB_AlarmInfoEntityManager;


        }


        /// <summary>
        /// 获取的分页列表信息
        ///
        //</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task<PagedResultDto<TB_AlarmInfoEntityListDto>> GetPaged(GetTB_AlarmInfoEntitysInput input)
        {
            var query = _tB_AlarmInfoEntityRepository.GetAll()
            .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a =>

            a.Id != null
            );
            // TODO:根据传入的参数添加过滤条件

            var count = await query.CountAsync();

            var tB_AlarmInfoEntityList = await query
            .OrderBy(input.Sorting).AsNoTracking()
            //.PageBy(input)
            .ToListAsync();

            var tB_AlarmInfoEntityListDtos = ObjectMapper.Map<List<TB_AlarmInfoEntityListDto>>(tB_AlarmInfoEntityList);

            return new PagedResultDto<TB_AlarmInfoEntityListDto>(count, tB_AlarmInfoEntityListDtos);
        }


        /// <summary>
        /// 通过指定id获取TB_AlarmInfoEntityListDto信息
        /// //</summary>

        public async Task<TB_AlarmInfoEntityListDto> GetById(EntityDto<long> input)
        {
            var entity = await _tB_AlarmInfoEntityRepository.GetAsync(input.Id);

            var dto = ObjectMapper.Map<TB_AlarmInfoEntityListDto>(entity);
            return dto;
        }

        /// <summary>
        /// 获取编辑 
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task<GetTB_AlarmInfoEntityForEditOutput> GetForEdit(NullableIdDto<long> input)
        {
            var output = new GetTB_AlarmInfoEntityForEditOutput();
            TB_AlarmInfoEntityEditDto editDto;

            if (input.Id.HasValue)
            {
                var entity = await _tB_AlarmInfoEntityRepository.GetAsync(input.Id.Value);
                editDto = ObjectMapper.Map<TB_AlarmInfoEntityEditDto>(entity);
            }
            else
            {
                editDto = new TB_AlarmInfoEntityEditDto();
            }



            output.TB_AlarmInfoEntity = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改的公共方法
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task CreateOrUpdate(CreateOrUpdateTB_AlarmInfoEntityInput input)
        {

            if (input.TB_AlarmInfoEntity.Id.HasValue)
            {
                await Update(input.TB_AlarmInfoEntity);
            }
            else
            {
                await Create(input.TB_AlarmInfoEntity);
            }
        }


        /// <summary>
        /// 新增
        /// //</summary>

        protected virtual async Task<TB_AlarmInfoEntityEditDto> Create(TB_AlarmInfoEntityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<TB_AlarmInfoEntity>(input);
            //调用领域服务
            entity = await _tB_AlarmInfoEntityManager.CreateAsync(entity);

            var dto = ObjectMapper.Map<TB_AlarmInfoEntityEditDto>(entity);
            return dto;
        }

        /// <summary>
        /// 编辑
        /// //</summary>

        protected virtual async Task Update(TB_AlarmInfoEntityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _tB_AlarmInfoEntityRepository.GetAsync(input.Id.Value);
            //  input.MapTo(entity);
            //将input属性的值赋值到entity中
            ObjectMapper.Map(input, entity);
            await _tB_AlarmInfoEntityManager.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除信息
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task Delete(EntityDto<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tB_AlarmInfoEntityManager.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除TB_AlarmInfoEntity的方法
        /// //</summary>

        public async Task BatchDelete(List<long> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _tB_AlarmInfoEntityManager.BatchDelete(input);
        }




        //// custom codes



        //// custom codes end

    }
}


