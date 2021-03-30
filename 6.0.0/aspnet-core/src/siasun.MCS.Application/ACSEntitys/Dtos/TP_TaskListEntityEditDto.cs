
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
	/// <see cref="TP_TaskListEntity"/>
	/// </summary>
    public class TP_TaskListEntityEditDto
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
		/// c_TaskId
		/// </summary>
		public String c_TaskId { get; set; }



		/// <summary>
		/// c_TaskCount
		/// </summary>
		public Int32? c_TaskCount { get; set; }



		/// <summary>
		/// c_TaskNo
		/// </summary>
		public Int32? c_TaskNo { get; set; }



		/// <summary>
		/// c_AGVId
		/// </summary>
		public Int32? c_AGVId { get; set; }



		/// <summary>
		/// c_AGVType
		/// </summary>
		public Int32? c_AGVType { get; set; }



		/// <summary>
		/// c_WorkMapLoc
		/// </summary>
		public Int32? c_WorkMapLoc { get; set; }



		/// <summary>
		/// c_AGVTaskType
		/// </summary>
		public Int32? c_AGVTaskType { get; set; }



		/// <summary>
		/// c_RobotTaskType
		/// </summary>
		public Int32? c_RobotTaskType { get; set; }



		/// <summary>
		/// c_WorkLoc
		/// </summary>
		public String c_WorkLoc { get; set; }



		/// <summary>
		/// c_WorkLocType
		/// </summary>
		public String c_WorkLocType { get; set; }



		/// <summary>
		/// c_WorkPort
		/// </summary>
		public String c_WorkPort { get; set; }



		/// <summary>
		/// c_TaskCode
		/// </summary>
		public Int32? c_TaskCode { get; set; }



		/// <summary>
		/// c_TaskCode2
		/// </summary>
		public Int32? c_TaskCode2 { get; set; }



		/// <summary>
		/// c_CarrierID
		/// </summary>
		public String c_CarrierID { get; set; }



		/// <summary>
		/// c_Priority
		/// </summary>
		public Int32? c_Priority { get; set; }



		/// <summary>
		/// d_DueTime
		/// </summary>
		public String d_DueTime { get; set; }



		/// <summary>
		/// c_GroupCount
		/// </summary>
		public Int32? c_GroupCount { get; set; }



		/// <summary>
		/// c_AreaIndex
		/// </summary>
		public Int32? c_AreaIndex { get; set; }



		/// <summary>
		/// c_OrderId
		/// </summary>
		public String c_OrderId { get; set; }



		/// <summary>
		/// c_OrderSource
		/// </summary>
		public Int32? c_OrderSource { get; set; }



		/// <summary>
		/// c_GroupMark
		/// </summary>
		public Int32? c_GroupMark { get; set; }



		/// <summary>
		/// c_GroupType
		/// </summary>
		public Int32? c_GroupType { get; set; }



		/// <summary>
		/// c_GroupId
		/// </summary>
		public String c_GroupId { get; set; }



		/// <summary>
		/// c_ARSTaskmark
		/// </summary>
		public Int32? c_ARSTaskmark { get; set; }



		/// <summary>
		/// c_NextTask
		/// </summary>
		public String c_NextTask { get; set; }



		/// <summary>
		/// c_IsArvBuff
		/// </summary>
		public Int32? c_IsArvBuff { get; set; }



		/// <summary>
		/// c_HandleFlag
		/// </summary>
		public Int32? c_HandleFlag { get; set; }



		/// <summary>
		/// c_ManualFlag
		/// </summary>
		public Int32? c_ManualFlag { get; set; }



		/// <summary>
		/// d_CreateTime
		/// </summary>
		public DateTime? d_CreateTime { get; set; }



		/// <summary>
		/// d_SendTime
		/// </summary>
		public DateTime? d_SendTime { get; set; }



		/// <summary>
		/// d_StartTime
		/// </summary>
		public DateTime? d_StartTime { get; set; }



		/// <summary>
		/// d_EndTime
		/// </summary>
		public DateTime? d_EndTime { get; set; }



		/// <summary>
		/// d_ActionTime
		/// </summary>
		public DateTime? d_ActionTime { get; set; }



		/// <summary>
		/// d_DoneTime
		/// </summary>
		public DateTime? d_DoneTime { get; set; }



		/// <summary>
		/// d_UnlockTime
		/// </summary>
		public DateTime? d_UnlockTime { get; set; }



		/// <summary>
		/// d_AGVTime
		/// </summary>
		public String d_AGVTime { get; set; }



		/// <summary>
		/// d_RobotTime
		/// </summary>
		public String d_RobotTime { get; set; }



		/// <summary>
		/// c_ConfirmFlag
		/// </summary>
		public Int32? c_ConfirmFlag { get; set; }



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
		/// c_RFIDCheckResult
		/// </summary>
		public String c_RFIDCheckResult { get; set; }



		/// <summary>
		/// c_LastTask
		/// </summary>
		public Int32? c_LastTask { get; set; }



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