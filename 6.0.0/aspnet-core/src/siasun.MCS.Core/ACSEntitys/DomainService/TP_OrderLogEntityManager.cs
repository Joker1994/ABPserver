

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
    public class TP_OrderLogEntityManager :MCSDomainServiceBase, ITP_OrderLogEntityManager
    {
		
		private readonly IRepository<TP_OrderLogEntity,string> _tP_OrderLogEntityRepository;

		/// <summary>
		/// TP_OrderLogEntity的构造方法
		/// 通过构造函数注册服务到依赖注入容器中
		///</summary>
	public TP_OrderLogEntityManager(IRepository<TP_OrderLogEntity, string> tP_OrderLogEntityRepository)	{
			_tP_OrderLogEntityRepository =  tP_OrderLogEntityRepository;
		}

		 #region 查询判断的业务

        /// <summary>
        /// 返回表达式数的实体信息即IQueryable类型
        /// </summary>
        /// <returns></returns>
        public IQueryable<TP_OrderLogEntity> QueryTP_OrderLogEntitys()
        {
            return _tP_OrderLogEntityRepository.GetAll();
        }

        /// <summary>
        /// 返回即IQueryable类型的实体，不包含EF Core跟踪标记
        /// </summary>
        /// <returns></returns>
        public IQueryable<TP_OrderLogEntity> QueryTP_OrderLogEntitysAsNoTracking()
        {
            return _tP_OrderLogEntityRepository.GetAll().AsNoTracking();
        }

        /// <summary>
        /// 根据Id查询实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TP_OrderLogEntity> FindByIdAsync(string id)
        {
            var entity = await _tP_OrderLogEntityRepository.GetAsync(id);
            return entity;
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync(string id)
        {
            var result = await _tP_OrderLogEntityRepository.GetAll().AnyAsync(a => a.Id == id);
            return result;
        }

        #endregion

		 
		 
        public async Task<TP_OrderLogEntity> CreateAsync(TP_OrderLogEntity entity)
        {
            entity.Id = await _tP_OrderLogEntityRepository.InsertAndGetIdAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(TP_OrderLogEntity entity)
        {
            await _tP_OrderLogEntityRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(string id)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_OrderLogEntityRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task BatchDelete(List<string> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_OrderLogEntityRepository.DeleteAsync(a => input.Contains(a.Id));
        }
	 
			
							//// custom codes
									
							

							//// custom codes end



		 
		  
		 

	}
}
