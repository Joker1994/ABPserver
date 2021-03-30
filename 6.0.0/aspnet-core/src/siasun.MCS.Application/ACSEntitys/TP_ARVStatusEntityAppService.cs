
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
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
    public class TP_ARVStatusEntityAppService : MCSAppServiceBase, ITP_ARVStatusEntityAppService
    {
        private readonly IRepository<TP_ARVStatusEntity, long>_tP_ARVStatusEntityRepository;
        public TP_ARVStatusEntityAppService(
IRepository<TP_ARVStatusEntity, long> ARVStatusEntityRepository
)
        {
            _tP_ARVStatusEntityRepository = ARVStatusEntityRepository;
        }

        private readonly ITP_ARVStatusEntityManager _tP_ARVStatusEntityManager;


        /// <summary>
        /// 获取的分页列表信息
        ///
        //</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //[AbpAuthorize(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Query)]
        public async Task<PagedResultDto<TP_ARVStatusEntityListDto>> GetPaged(GetTP_ARVStatusEntitysInput input)
        {

            var query = _tP_ARVStatusEntityRepository.GetAll();
            //.WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.Id != null);
            // TODO:根据传入的参数添加过滤条件

            var count = await query.CountAsync();

            var tP_ARVStatusEntityList = await query
            .OrderBy(input.Sorting).AsNoTracking()
            //.PageBy(input)
            .ToListAsync();

            var tP_ARVStatusEntityListDtos = ObjectMapper.Map<List<TP_ARVStatusEntityListDto>>(tP_ARVStatusEntityList);

            return new PagedResultDto<TP_ARVStatusEntityListDto>(count, tP_ARVStatusEntityListDtos);
        }


        /// <summary>
        /// 通过指定id获取TP_ARVStatusEntityListDto信息
        /// </summary>
        [AbpAuthorize(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Query)]
        public async Task<TP_ARVStatusEntityListDto> GetById(EntityDto<long> input)
        {
            var entity = await _tP_ARVStatusEntityRepository.GetAsync(input.Id);

            var dto = ObjectMapper.Map<TP_ARVStatusEntityListDto>(entity);
            return dto;
        }

        /// <summary>
        /// 获取编辑 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Create, TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Edit)]
        public async Task<GetTP_ARVStatusEntityForEditOutput> GetForEdit(NullableIdDto<long> input)
        {
            var output = new GetTP_ARVStatusEntityForEditOutput();
            TP_ARVStatusEntityEditDto editDto;

            if (input.Id.HasValue)
            {
                var entity = await _tP_ARVStatusEntityRepository.GetAsync(input.Id.Value);
                editDto = ObjectMapper.Map<TP_ARVStatusEntityEditDto>(entity);
            }
            else
            {
                editDto = new TP_ARVStatusEntityEditDto();
            }



            output.TP_ARVStatusEntity = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Create, TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateTP_ARVStatusEntityInput input)
        {

            if (input.TP_ARVStatusEntity.Id.HasValue)
            {
                await Update(input.TP_ARVStatusEntity);
            }
            else
            {
                await Create(input.TP_ARVStatusEntity);
            }
        }


        /// <summary>
        /// 新增
        /// </summary>
        [AbpAuthorize(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Create)]
        protected virtual async Task<TP_ARVStatusEntityEditDto> Create(TP_ARVStatusEntityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<TP_ARVStatusEntity>(input);
            //调用领域服务
            entity = await _tP_ARVStatusEntityManager.CreateAsync(entity);

            var dto = ObjectMapper.Map<TP_ARVStatusEntityEditDto>(entity);
            return dto;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        [AbpAuthorize(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Edit)]
        protected virtual async Task Update(TP_ARVStatusEntityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _tP_ARVStatusEntityRepository.GetAsync(input.Id.Value);
            //  input.MapTo(entity);
            //将input属性的值赋值到entity中
            ObjectMapper.Map(input, entity);
            await _tP_ARVStatusEntityManager.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Delete)]
        public async Task Delete(EntityDto<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_ARVStatusEntityManager.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除TP_ARVStatusEntity的方法
        /// </summary>
        [AbpAuthorize(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_BatchDelete)]
        public async Task BatchDelete(List<long> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _tP_ARVStatusEntityManager.BatchDelete(input);
        }
        //// custom codes end

    }
}


