

using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace siasun.MCS.ACSEntitys.DomainService
{
    /// <summary>
    /// 领域服务层一个模块的核心业务逻辑
    ///</summary>
    public class TB_MapInfoEntityManager : MCSDomainServiceBase, ITB_MapInfoEntityManager
    {

        private readonly IRepository<TB_MapInfoEntity, String> _tB_MapInfoEntityRepository;

        /// <summary>
        /// TB_MapInfoEntity的构造方法
        /// 通过构造函数注册服务到依赖注入容器中
        ///</summary>
        public TB_MapInfoEntityManager(IRepository<TB_MapInfoEntity, String> tB_MapInfoEntityRepository)
        {
            _tB_MapInfoEntityRepository = tB_MapInfoEntityRepository;
        }

        #region 查询判断的业务

        /// <summary>
        /// 返回表达式数的实体信息即IQueryable类型
        /// </summary>
        /// <returns></returns>
        public IQueryable<TB_MapInfoEntity> QueryTB_MapInfoEntitys()
        {
            return _tB_MapInfoEntityRepository.GetAll();
        }

        /// <summary>
        /// 返回即IQueryable类型的实体，不包含EF Core跟踪标记
        /// </summary>
        /// <returns></returns>
        public IQueryable<TB_MapInfoEntity> QueryTB_MapInfoEntitysAsNoTracking()
        {
            return _tB_MapInfoEntityRepository.GetAll().AsNoTracking();
        }

        /// <summary>
        /// 根据Id查询实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TB_MapInfoEntity> FindByIdAsync(string id)
        {
            var entity = await _tB_MapInfoEntityRepository.GetAsync(id);
            return entity;
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync(string id)
        {
            var result = await _tB_MapInfoEntityRepository.GetAll().AnyAsync(a => a.Id == id);
            return result;
        }

        #endregion



        public async Task<TB_MapInfoEntity> CreateAsync(TB_MapInfoEntity entity)
        {
            entity.Id = await _tB_MapInfoEntityRepository.InsertAndGetIdAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(TB_MapInfoEntity entity)
        {
            await _tB_MapInfoEntityRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(string id)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tB_MapInfoEntityRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task BatchDelete(List<string> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tB_MapInfoEntityRepository.DeleteAsync(a => input.Contains(a.Id));
        }


        //// custom codes



        //// custom codes end







    }
}
