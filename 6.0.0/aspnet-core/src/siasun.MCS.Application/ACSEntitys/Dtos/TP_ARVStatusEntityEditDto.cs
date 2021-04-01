
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
	/// <see cref="TP_ARVStatusEntity"/>
	/// </summary>
    public class TP_ARVStatusEntityEditDto
    {
        
		/// <summary>
		/// c_Id
		/// </summary>
		[Required(ErrorMessage="c_Id不能为空")]
		public String c_Id { get; set; }



		/// <summary>
		/// c_ARVId
		/// </summary>
		public Int32? c_ARVId { get; set; }



		/// <summary>
		/// c_ARVDesc
		/// </summary>
		public String c_ARVDesc { get; set; }



		/// <summary>
		/// c_ARVType
		/// </summary>
		public Int32? c_ARVType { get; set; }



		/// <summary>
		/// c_TaskId
		/// </summary>
		public String c_TaskId { get; set; }



		/// <summary>
		/// c_TaskType
		/// </summary>
		public Int32? c_TaskType { get; set; }



		/// <summary>
		/// c_TaskStepNo
		/// </summary>
		public Int32? c_TaskStepNo { get; set; }



		/// <summary>
		/// c_OrderId
		/// </summary>
		public String c_OrderId { get; set; }



		/// <summary>
		/// c_StartPoint
		/// </summary>
		public Int32? c_StartPoint { get; set; }



		/// <summary>
		/// c_EndPoint
		/// </summary>
		public Int32? c_EndPoint { get; set; }



		/// <summary>
		/// c_TargetLoc
		/// </summary>
		public Int32? c_TargetLoc { get; set; }



		/// <summary>
		/// c_WorkState
		/// </summary>
		public Int32? c_WorkState { get; set; }



		/// <summary>
		/// c_ErrorCode
		/// </summary>
		public String c_ErrorCode { get; set; }



		/// <summary>
		/// c_BatteryState
		/// </summary>
		public Int32? c_BatteryState { get; set; }



		/// <summary>
		/// c_RobotState
		/// </summary>
		public Int32? c_RobotState { get; set; }



		/// <summary>
		/// c_RobotErrorCode
		/// </summary>
		public String c_RobotErrorCode { get; set; }



		/// <summary>
		/// c_WorkCode
		/// </summary>
		public Int32? c_WorkCode { get; set; }



		/// <summary>
		/// c_BatteryVolume
		/// </summary>
		public String c_BatteryVolume { get; set; }



		/// <summary>
		/// c_BatteryVoltage
		/// </summary>
		public String c_BatteryVoltage { get; set; }



		/// <summary>
		/// c_AvoidAgvId
		/// </summary>
		public Int32? c_AvoidAgvId { get; set; }



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
		/// c_Sw05
		/// </summary>
		public String c_Sw05 { get; set; }



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



		
							//// custom codes
									
							

							//// custom codes end
    }
}