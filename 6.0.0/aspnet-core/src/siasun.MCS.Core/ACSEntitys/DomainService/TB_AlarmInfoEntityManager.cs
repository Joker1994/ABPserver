

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
    public class TB_AlarmInfoEntityManager :MCSDomainServiceBase, ITB_AlarmInfoEntityManager
    {
		
		private readonly IRepository<TB_AlarmInfoEntity,long> _tB_AlarmInfoEntityRepository;

		/// <summary>
		/// TB_AlarmInfoEntity的构造方法
		/// 通过构造函数注册服务到依赖注入容器中
		///</summary>
	public TB_AlarmInfoEntityManager(IRepository<TB_AlarmInfoEntity, long> tB_AlarmInfoEntityRepository)	{
			_tB_AlarmInfoEntityRepository =  tB_AlarmInfoEntityRepository;
		}

		 #region 查询判断的业务

        /// <summary>
        /// 返回表达式数的实体信息即IQueryable类型
        /// </summary>
        /// <returns></returns>
        public IQueryable<TB_AlarmInfoEntity> QueryTB_AlarmInfoEntitys()
        {
            return _tB_AlarmInfoEntityRepository.GetAll();
        }

        /// <summary>
        /// 返回即IQueryable类型的实体，不包含EF Core跟踪标记
        /// </summary>
        /// <returns></returns>
        public IQueryable<TB_AlarmInfoEntity> QueryTB_AlarmInfoEntitysAsNoTracking()
        {
            return _tB_AlarmInfoEntityRepository.GetAll().AsNoTracking();
        }

        /// <summary>
        /// 根据Id查询实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TB_AlarmInfoEntity> FindByIdAsync(long id)
        {
            var entity = await _tB_AlarmInfoEntityRepository.GetAsync(id);
            return entity;
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync(long id)
        {
            var result = await _tB_AlarmInfoEntityRepository.GetAll().AnyAsync(a => a.Id == id);
            return result;
        }

        #endregion

		 
		 
        public async Task<TB_AlarmInfoEntity> CreateAsync(TB_AlarmInfoEntity entity)
        {
            entity.Id = await _tB_AlarmInfoEntityRepository.InsertAndGetIdAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(TB_AlarmInfoEntity entity)
        {
            await _tB_AlarmInfoEntityRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(long id)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tB_AlarmInfoEntityRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task BatchDelete(List<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tB_AlarmInfoEntityRepository.DeleteAsync(a => input.Contains(a.Id));
        }
	 
			
							//// custom codes
									
							

							//// custom codes end



		 
		  
		 

	}
}
