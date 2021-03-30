

using System;
using Abp.Application.Services.Dto;
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using siasun.MCS.ACSEntitys;
using System.Collections.ObjectModel;


namespace siasun.MCS.ACSEntitys.Dtos
{	
	/// <summary>
	/// 的列表DTO
	/// <see cref="TB_AlarmInfoEntity"/>
	/// </summary>
    public class TB_AlarmInfoEntityListDto : EntityDto<long> 
    {

        
		/// <summary>
		/// C_ID
		/// </summary>
		[Required(ErrorMessage="C_ID不能为空")]
		public String C_ID { get; set; }



		/// <summary>
		/// C_DeviceID
		/// </summary>
		public String C_DeviceID { get; set; }



		/// <summary>
		/// C_DeviceType
		/// </summary>
		public String C_DeviceType { get; set; }



		/// <summary>
		/// C_DeviceDesc
		/// </summary>
		public String C_DeviceDesc { get; set; }



		/// <summary>
		/// C_Type
		/// </summary>
		public String C_Type { get; set; }



		/// <summary>
		/// C_Reason
		/// </summary>
		public String C_Reason { get; set; }



		/// <summary>
		/// C_Measure
		/// </summary>
		public String C_Measure { get; set; }



		/// <summary>
		/// N_State
		/// </summary>
		public Int32? N_State { get; set; }



		/// <summary>
		/// c_DeleteMark
		/// </summary>
		public Int32? c_DeleteMark { get; set; }



		/// <summary>
		/// c_EnabledMark
		/// </summary>
		public Int32? c_EnabledMark { get; set; }



		/// <summary>
		/// C_UpdateTime
		/// </summary>
		public DateTime? C_UpdateTime { get; set; }



		/// <summary>
		/// C_TimeStamp
		/// </summary>
		public DateTime? C_TimeStamp { get; set; }



		/// <summary>
		/// C_Sw01
		/// </summary>
		public String C_Sw01 { get; set; }



		/// <summary>
		/// C_Sw02
		/// </summary>
		public String C_Sw02 { get; set; }



		/// <summary>
		/// C_Sw03
		/// </summary>
		public String C_Sw03 { get; set; }



		/// <summary>
		/// C_Sw04
		/// </summary>
		public String C_Sw04 { get; set; }



		/// <summary>
		/// C_Sw05
		/// </summary>
		public String C_Sw05 { get; set; }



		
							//// custom codes
									
							

							//// custom codes end
    }
}