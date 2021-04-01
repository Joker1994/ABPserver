
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
using siasun.MCS.Authorization;
using siasun.MCS.ACSEntitys.DomainService;

namespace siasun.MCS.ACSEntitys
{
    /// <summary>
    /// 应用层服务的接口实现方法
    ///
//</summary>
    [AbpAuthorize]
    public class TP_OrderListEntityAppService : MCSAppServiceBase, ITP_OrderListEntityAppService
    {
        private readonly IRepository<TP_OrderListEntity, string> _tP_OrderListEntityRepository;

        private readonly ITP_OrderListEntityManager _tP_OrderListEntityManager;


        /// <summary>
        /// 构造函数
        ///
        //</summary>
        public TP_OrderListEntityAppService(IRepository<TP_OrderListEntity, string>tP_OrderListEntityRepository)
        {
            _tP_OrderListEntityRepository = tP_OrderListEntityRepository;
        }


        /// <summary>
        /// 获取的分页列表信息
        ///
        //</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task<PagedResultDto<TP_OrderListEntityListDto>> GetPaged(GetTP_OrderListEntitysInput input)
        {

            var query = _tP_OrderListEntityRepository.GetAll()
            .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.c_Id != null


            );
            // TODO:根据传入的参数添加过滤条件

            var count = await query.CountAsync();

            var tP_OrderListEntityList = await query
            .OrderBy(input.Sorting).AsNoTracking()
            //.PageBy(input)
            .ToListAsync();

            var tP_OrderListEntityListDtos = ObjectMapper.Map<List<TP_OrderListEntityListDto>>(tP_OrderListEntityList);

            return new PagedResultDto<TP_OrderListEntityListDto>(count, tP_OrderListEntityListDtos);
        }


        /// <summary>
        /// 通过指定id获取TP_OrderListEntityListDto信息
        /// //</summary>

        public async Task<TP_OrderListEntityListDto> GetById(EntityDto<string> input)
        {
            var entity = await _tP_OrderListEntityRepository.GetAsync(input.Id);

            var dto = ObjectMapper.Map<TP_OrderListEntityListDto>(entity);
            return dto;
        }

        /// <summary>
        /// 获取编辑 
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task<GetTP_OrderListEntityForEditOutput> GetForEdit(string input)
        {
            var output = new GetTP_OrderListEntityForEditOutput();
            TP_OrderListEntityEditDto editDto;

            if (!string.IsNullOrEmpty(input))
            {
                var entity = await _tP_OrderListEntityRepository.GetAsync(input);
                editDto = ObjectMapper.Map<TP_OrderListEntityEditDto>(entity);
            }
            else
            {
                editDto = new TP_OrderListEntityEditDto();
            }



            output.TP_OrderListEntity = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改的公共方法
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task CreateOrUpdate(CreateOrUpdateTP_OrderListEntityInput input)
        {

            if (!string.IsNullOrEmpty(input.TP_OrderListEntity.c_Id))
            {
                await Update(input.TP_OrderListEntity);
            }
            else
            {
                await Create(input.TP_OrderListEntity);
            }
        }


        /// <summary>
        /// 新增
        /// //</summary>

        protected virtual async Task<TP_OrderListEntityEditDto> Create(TP_OrderListEntityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<TP_OrderListEntity>(input);
            //调用领域服务
            entity = await _tP_OrderListEntityManager.CreateAsync(entity);

            var dto = ObjectMapper.Map<TP_OrderListEntityEditDto>(entity);
            return dto;
        }

        /// <summary>
        /// 编辑
        /// //</summary>

        protected virtual async Task Update(TP_OrderListEntityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _tP_OrderListEntityRepository.GetAsync(input.c_Id);
            //  input.MapTo(entity);
            //将input属性的值赋值到entity中
            ObjectMapper.Map(input, entity);
            await _tP_OrderListEntityManager.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除信息
        /// //</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task Delete(EntityDto<string> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_OrderListEntityManager.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除TP_OrderListEntity的方法
        /// //</summary>

        public async Task BatchDelete(List<string> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _tP_OrderListEntityManager.BatchDelete(input);
        }




        //// custom codes



        //// custom codes end

    }
}


