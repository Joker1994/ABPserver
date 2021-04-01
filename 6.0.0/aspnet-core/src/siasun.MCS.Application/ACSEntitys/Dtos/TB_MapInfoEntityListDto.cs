

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
	/// <see cref="TB_MapInfoEntity"/>
	/// </summary>
    public class TB_MapInfoEntityListDto : EntityDto 
    {

        
		/// <summary>
		/// c_Id
		/// </summary>
		[Required(ErrorMessage="c_Id不能为空")]
		public String c_Id { get; set; }



		/// <summary>
		/// c_MapLoc
		/// </summary>
		public Int32? c_MapLoc { get; set; }



		/// <summary>
		/// c_MapDecs
		/// </summary>
		public String c_MapDecs { get; set; }



		/// <summary>
		/// c_DeviceID
		/// </summary>
		public String c_DeviceID { get; set; }



		/// <summary>
		/// c_DeviceIndex
		/// </summary>
		public Int32? c_DeviceIndex { get; set; }



		/// <summary>
		/// c_PortNum
		/// </summary>
		public String c_PortNum { get; set; }



		/// <summary>
		/// c_PortIndex
		/// </summary>
		public Int32? c_PortIndex { get; set; }



		/// <summary>
		/// c_WorkType
		/// </summary>
		public Int32? c_WorkType { get; set; }



		/// <summary>
		/// c_GroupValue
		/// </summary>
		public Int32? c_GroupValue { get; set; }



		/// <summary>
		/// c_AreaId
		/// </summary>
		public Int32? c_AreaId { get; set; }



		/// <summary>
		/// n_FloorNo
		/// </summary>
		public String n_FloorNo { get; set; }



		/// <summary>
		/// c_ARSMark
		/// </summary>
		public Int32? c_ARSMark { get; set; }



		/// <summary>
		/// c_CreateID
		/// </summary>
		public String c_CreateID { get; set; }



		/// <summary>
		/// c_CreateName
		/// </summary>
		public String c_CreateName { get; set; }



		/// <summary>
		/// c_CreateTime
		/// </summary>
		public DateTime? c_CreateTime { get; set; }



		/// <summary>
		/// c_ModifyID
		/// </summary>
		public String c_ModifyID { get; set; }



		/// <summary>
		/// c_ModifyName
		/// </summary>
		public String c_ModifyName { get; set; }



		/// <summary>
		/// c_ModifyTime
		/// </summary>
		public DateTime? c_ModifyTime { get; set; }



		/// <summary>
		/// c_DeleteMark
		/// </summary>
		public Int32? c_DeleteMark { get; set; }



		/// <summary>
		/// c_EnabledMark
		/// </summary>
		public Int32? c_EnabledMark { get; set; }



		/// <summary>
		/// c_TimeStamp
		/// </summary>
		public DateTime c_TimeStamp { get; set; }



		/// <summary>
		/// c_Sw01
		/// </summary>
		public String c_Sw01 { get; set; }



		/// <summary>
		/// c_Sw02
		/// </summary>
		public String c_Sw02 { get; set; }



		/// <summary>
		/// c_Sw03
		/// </summary>
		public String c_Sw03 { get; set; }



		/// <summary>
		/// c_Sw04
		/// </summary>
		public String c_Sw04 { get; set; }



		/// <summary>
		/// c_Sw05
		/// </summary>
		public String c_Sw05 { get; set; }



		
							//// custom codes
									
							

							//// custom codes end
    }
}