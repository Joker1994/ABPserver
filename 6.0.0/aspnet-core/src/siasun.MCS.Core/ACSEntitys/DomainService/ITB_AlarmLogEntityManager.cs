
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Services;


namespace siasun.MCS.ACSEntitys.DomainService
{
    public interface ITB_AlarmLogEntityManager : IDomainService
    {


		/// <summary>
		/// 返回表达式数的实体信息即IQueryable类型
		/// </summary>
		/// <returns></returns>
		IQueryable<TB_AlarmLogEntity> QueryTB_AlarmLogEntitys();

		/// <summary>
		/// 返回性能更好的IQueryable类型，但不包含EF Core跟踪标记
		/// </summary>
		/// <returns></returns>

		IQueryable<TB_AlarmLogEntity> QueryTB_AlarmLogEntitysAsNoTracking();

		/// <summary>
		/// 根据Id查询实体信息
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task<TB_AlarmLogEntity> FindByIdAsync(String id);
	
		/// <summary>
		/// 检查实体是否存在
		/// </summary>
		/// <returns></returns>
		Task<bool> IsExistAsync(String id);


		/// <summary>
		/// 添加
		/// </summary>
		/// <param name="entity">实体</param>
		/// <returns></returns>
		Task<TB_AlarmLogEntity> CreateAsync(TB_AlarmLogEntity entity);

		/// <summary>
		/// 修改
		/// </summary>
		/// <param name="entity">实体</param>
		/// <returns></returns>
		Task UpdateAsync(TB_AlarmLogEntity entity);

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task DeleteAsync(String id);
		/// <summary>
		/// 批量删除
		/// </summary>
		/// <param name="input">Id的集合</param>
		/// <returns></returns>
		Task BatchDelete(List<String> input);


		
							//// custom codes
									
							

							//// custom codes end

		 
      
         

    }
}
