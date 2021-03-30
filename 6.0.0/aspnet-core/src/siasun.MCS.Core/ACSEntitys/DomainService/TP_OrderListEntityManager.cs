

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
    public class TP_OrderListEntityManager :MCSDomainServiceBase, ITP_OrderListEntityManager
    {
		
		private readonly IRepository<TP_OrderListEntity,long> _tP_OrderListEntityRepository;

		/// <summary>
		/// TP_OrderListEntity的构造方法
		/// 通过构造函数注册服务到依赖注入容器中
		///</summary>
	public TP_OrderListEntityManager(IRepository<TP_OrderListEntity, long> tP_OrderListEntityRepository)	{
			_tP_OrderListEntityRepository =  tP_OrderListEntityRepository;
		}

		 #region 查询判断的业务

        /// <summary>
        /// 返回表达式数的实体信息即IQueryable类型
        /// </summary>
        /// <returns></returns>
        public IQueryable<TP_OrderListEntity> QueryTP_OrderListEntitys()
        {
            return _tP_OrderListEntityRepository.GetAll();
        }

        /// <summary>
        /// 返回即IQueryable类型的实体，不包含EF Core跟踪标记
        /// </summary>
        /// <returns></returns>
        public IQueryable<TP_OrderListEntity> QueryTP_OrderListEntitysAsNoTracking()
        {
            return _tP_OrderListEntityRepository.GetAll().AsNoTracking();
        }

        /// <summary>
        /// 根据Id查询实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TP_OrderListEntity> FindByIdAsync(long id)
        {
            var entity = await _tP_OrderListEntityRepository.GetAsync(id);
            return entity;
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync(long id)
        {
            var result = await _tP_OrderListEntityRepository.GetAll().AnyAsync(a => a.Id == id);
            return result;
        }

        #endregion

		 
		 
        public async Task<TP_OrderListEntity> CreateAsync(TP_OrderListEntity entity)
        {
            entity.Id = await _tP_OrderListEntityRepository.InsertAndGetIdAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(TP_OrderListEntity entity)
        {
            await _tP_OrderListEntityRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(long id)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_OrderListEntityRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task BatchDelete(List<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_OrderListEntityRepository.DeleteAsync(a => input.Contains(a.Id));
        }
	 
			
							//// custom codes
									
							

							//// custom codes end



		 
		  
		 

	}
}
