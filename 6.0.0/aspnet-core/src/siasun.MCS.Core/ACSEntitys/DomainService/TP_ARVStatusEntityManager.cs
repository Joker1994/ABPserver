

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
    public class TP_ARVStatusEntityManager :MCSDomainServiceBase, ITP_ARVStatusEntityManager
    {
		
		private readonly IRepository<TP_ARVStatusEntity,string> _tP_ARVStatusEntityRepository;

		/// <summary>
		/// TP_ARVStatusEntity的构造方法
		/// 通过构造函数注册服务到依赖注入容器中
		///</summary>
	public TP_ARVStatusEntityManager(IRepository<TP_ARVStatusEntity, string> tP_ARVStatusEntityRepository)	{
			_tP_ARVStatusEntityRepository =  tP_ARVStatusEntityRepository;
		}

		 #region 查询判断的业务

        /// <summary>
        /// 返回表达式数的实体信息即IQueryable类型
        /// </summary>
        /// <returns></returns>
        public IQueryable<TP_ARVStatusEntity> QueryTP_ARVStatusEntitys()
        {
            return _tP_ARVStatusEntityRepository.GetAll();
        }

        /// <summary>
        /// 返回即IQueryable类型的实体，不包含EF Core跟踪标记
        /// </summary>
        /// <returns></returns>
        public IQueryable<TP_ARVStatusEntity> QueryTP_ARVStatusEntitysAsNoTracking()
        {
            return _tP_ARVStatusEntityRepository.GetAll().AsNoTracking();
        }

        /// <summary>
        /// 根据Id查询实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TP_ARVStatusEntity> FindByIdAsync(string id)
        {
            var entity = await _tP_ARVStatusEntityRepository.GetAsync(id);
            return entity;
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync(string id)
        {
            var result = await _tP_ARVStatusEntityRepository.GetAll().AnyAsync(a => a.c_Id == id);
            return result;
        }

        #endregion

		 
		 
        public async Task<TP_ARVStatusEntity> CreateAsync(TP_ARVStatusEntity entity)
        {
            entity.Id = await _tP_ARVStatusEntityRepository.InsertAndGetIdAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(TP_ARVStatusEntity entity)
        {
            await _tP_ARVStatusEntityRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(string id)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_ARVStatusEntityRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task BatchDelete(List<string> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_ARVStatusEntityRepository.DeleteAsync(a => input.Contains(a.Id));
        }
	 
			
							//// custom codes
									
							

							//// custom codes end



		 
		  
		 

	}
}
