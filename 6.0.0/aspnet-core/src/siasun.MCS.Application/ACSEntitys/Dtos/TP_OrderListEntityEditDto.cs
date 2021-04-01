
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using System.Collections.ObjectModel;
using siasun.MCS.ACSEntitys;


namespace  siasun.MCS.ACSEntitys.Dtos
{
	/// <summary>
	/// 的列表DTO
	/// <see cref="TP_OrderListEntity"/>
	/// </summary>
    public class TP_OrderListEntityEditDto
    {    
		/// <summary>
		/// c_Id
		/// </summary>
		[Required(ErrorMessage="c_Id不能为空")]
		public String c_Id { get; set; }



		/// <summary>
		/// c_OrderID
		/// </summary>
		public String c_OrderID { get; set; }



		/// <summary>
		/// c_OrderType
		/// </summary>
		public String c_OrderType { get; set; }



		/// <summary>
		/// c_OrderSource
		/// </summary>
		public Int32? c_OrderSource { get; set; }



		/// <summary>
		/// c_GroupType
		/// </summary>
		public Int32? c_GroupType { get; set; }



		/// <summary>
		/// c_GroupOrder
		/// </summary>
		public String c_GroupOrder { get; set; }



		/// <summary>
		/// c_GroupCount
		/// </summary>
		public Int32? c_GroupCount { get; set; }



		/// <summary>
		/// c_GroupSequence
		/// </summary>
		public Int32? c_GroupSequence { get; set; }



		/// <summary>
		/// c_Priority
		/// </summary>
		public Int32? c_Priority { get; set; }



		/// <summary>
		/// c_SourceLoc
		/// </summary>
		public String c_SourceLoc { get; set; }



		/// <summary>
		/// c_SourcePort
		/// </summary>
		public String c_SourcePort { get; set; }



		/// <summary>
		/// c_TargetLoc
		/// </summary>
		public String c_TargetLoc { get; set; }



		/// <summary>
		/// c_TargetPort
		/// </summary>
		public String c_TargetPort { get; set; }



		/// <summary>
		/// c_ProcessPlan
		/// </summary>
		public String c_ProcessPlan { get; set; }



		/// <summary>
		/// c_CarrierID
		/// </summary>
		public String c_CarrierID { get; set; }



		/// <summary>
		/// c_ProcessStep
		/// </summary>
		public String c_ProcessStep { get; set; }



		/// <summary>
		/// c_LotInfo
		/// </summary>
		public String c_LotInfo { get; set; }



		/// <summary>
		/// c_CanStart
		/// </summary>
		public Boolean? c_CanStart { get; set; }



		/// <summary>
		/// c_CarrierType
		/// </summary>
		public String c_CarrierType { get; set; }



		/// <summary>
		/// c_DueTime
		/// </summary>
		public DateTime? c_DueTime { get; set; }



		/// <summary>
		/// c_HandleFlag
		/// </summary>
		public Int32? c_HandleFlag { get; set; }



		/// <summary>
		/// c_ManualFlag
		/// </summary>
		public Int32? c_ManualFlag { get; set; }



		/// <summary>
		/// n_AGVType
		/// </summary>
		public Int32? n_AGVType { get; set; }



		/// <summary>
		/// n_AGVID
		/// </summary>
		public Int32? n_AGVID { get; set; }



		/// <summary>
		/// d_CreateTime
		/// </summary>
		public DateTime? d_CreateTime { get; set; }



		/// <summary>
		/// d_PredictTime
		/// </summary>
		public DateTime? d_PredictTime { get; set; }



		/// <summary>
		/// d_StartTime
		/// </summary>
		public DateTime? d_StartTime { get; set; }



		/// <summary>
		/// d_EndTime
		/// </summary>
		public DateTime? d_EndTime { get; set; }



		/// <summary>
		/// d_AnalyzeTime
		/// </summary>
		public DateTime? d_AnalyzeTime { get; set; }



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
		/// c_TaskCount
		/// </summary>
		public Int32? c_TaskCount { get; set; }



		/// <summary>
		/// c_CarrierStatus
		/// </summary>
		public String c_CarrierStatus { get; set; }



		/// <summary>
		/// c_CarrierProcessingStatus
		/// </summary>
		public String c_CarrierProcessingStatus { get; set; }



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



		/// <summary>
		/// c_SourceLocType
		/// </summary>
		public String c_SourceLocType { get; set; }



		/// <summary>
		/// c_TargetLocType
		/// </summary>
		public String c_TargetLocType { get; set; }



		
							//// custom codes
									
							

							//// custom codes end
    }
}