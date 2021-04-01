

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
    public class TP_TaskLogEntityManager :MCSDomainServiceBase, ITP_TaskLogEntityManager
    {
		
		private readonly IRepository<TP_TaskLogEntity,string> _tP_TaskLogEntityRepository;

		/// <summary>
		/// TP_TaskLogEntity的构造方法
		/// 通过构造函数注册服务到依赖注入容器中
		///</summary>
	public TP_TaskLogEntityManager(IRepository<TP_TaskLogEntity, string> tP_TaskLogEntityRepository)	{
			_tP_TaskLogEntityRepository =  tP_TaskLogEntityRepository;
		}

		 #region 查询判断的业务

        /// <summary>
        /// 返回表达式数的实体信息即IQueryable类型
        /// </summary>
        /// <returns></returns>
        public IQueryable<TP_TaskLogEntity> QueryTP_TaskLogEntitys()
        {
            return _tP_TaskLogEntityRepository.GetAll();
        }

        /// <summary>
        /// 返回即IQueryable类型的实体，不包含EF Core跟踪标记
        /// </summary>
        /// <returns></returns>
        public IQueryable<TP_TaskLogEntity> QueryTP_TaskLogEntitysAsNoTracking()
        {
            return _tP_TaskLogEntityRepository.GetAll().AsNoTracking();
        }

        /// <summary>
        /// 根据Id查询实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TP_TaskLogEntity> FindByIdAsync(string id)
        {
            var entity = await _tP_TaskLogEntityRepository.GetAsync(id);
            return entity;
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync(string id)
        {
            var result = await _tP_TaskLogEntityRepository.GetAll().AnyAsync(a => a.Id == id);
            return result;
        }

        #endregion

		 
		 
        public async Task<TP_TaskLogEntity> CreateAsync(TP_TaskLogEntity entity)
        {
            entity.Id = await _tP_TaskLogEntityRepository.InsertAndGetIdAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(TP_TaskLogEntity entity)
        {
            await _tP_TaskLogEntityRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(string id)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_TaskLogEntityRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task BatchDelete(List<string> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _tP_TaskLogEntityRepository.DeleteAsync(a => input.Contains(a.Id));
        }
	 
			
							//// custom codes
									
							

							//// custom codes end



		 
		  
		 

	}
}
