
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
	/// <see cref="TP_OrderLogEntity"/>
	/// </summary>
    public class TP_OrderLogEntityEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }         


        
		/// <summary>
		/// c_Id
		/// </summary>
		public String c_Id { get; set; }



		/// <summary>
		/// c_OrderID
		/// </summary>
		public String c_OrderID { get; set; }



		/// <summary>
		/// c_OrderType
		/// </summary>
		public Int32? c_OrderType { get; set; }



		/// <summary>
		/// c_OrderSource
		/// </summary>
		public Int32? c_OrderSource { get; set; }



		/// <summary>
		/// c_GroupMark
		/// </summary>
		public Int32? c_GroupMark { get; set; }



		/// <summary>
		/// c_GroupId
		/// </summary>
		public String c_GroupId { get; set; }



		/// <summary>
		/// c_GroupType
		/// </summary>
		public Int32? c_GroupType { get; set; }



		/// <summary>
		/// c_GroupOrder
		/// </summary>
		public Int32? c_GroupOrder { get; set; }



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
		/// c_PartNum
		/// </summary>
		public String c_PartNum { get; set; }



		/// <summary>
		/// c_CarrierID
		/// </summary>
		public String c_CarrierID { get; set; }



		/// <summary>
		/// c_LotQTY
		/// </summary>
		public Int32? c_LotQTY { get; set; }



		/// <summary>
		/// c_LotInfo
		/// </summary>
		public String c_LotInfo { get; set; }



		/// <summary>
		/// c_CanStart
		/// </summary>
		public Boolean? c_CanStart { get; set; }



		/// <summary>
		/// c_AreaLoc
		/// </summary>
		public String c_AreaLoc { get; set; }



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
		/// c_SucceedNum
		/// </summary>
		public Int32? c_SucceedNum { get; set; }



		/// <summary>
		/// c_FailedNum
		/// </summary>
		public Int32? c_FailedNum { get; set; }



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