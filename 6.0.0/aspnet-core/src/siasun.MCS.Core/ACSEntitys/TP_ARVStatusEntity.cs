using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace siasun.MCS.ACSEntitys
{
   /// <summary>
   /// 版 本SSACS开发框架
   /// Copyright (c) 2018-2020 上海新松机器人有限公司
   /// 创 建：朱均岭
   /// 描 述：entity
   ///</summary>
    public partial class TP_ARVStatusEntity : Entity<String>
    {
        #region 实体成员
        /// <summary>
        /// 编号
        ///</summary>
        ////[Column("C_ID")]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Set id auto increase
        public String c_Id  { get; set; }
        /// <summary>
        /// ARV编号
        ///</summary>
        //[Column("C_ARVID")]
        public Int32 c_ARVId  { get; set; }
        /// <summary>
        /// ARV描述
        ///</summary>
        //[Column("C_ARVDESC")]
        public String c_ARVDesc  { get; set; }
        /// <summary>
        /// ARV类型
        ///</summary>
        //[Column("C_ARVTYPE")]
        public Int32 c_ARVType  { get; set; }
        /// <summary>
        /// 任务Id
        ///</summary>
        //[Column("C_TASKID")]
        public String c_TaskId  { get; set; }
        /// <summary>
        /// 任务类型
        ///</summary>
        //[Column("C_TASKTYPE")]
        public Int32 c_TaskType  { get; set; }
        /// <summary>
        /// 任务步号
        ///</summary>
        //[Column("C_TASKSTEPNO")]
        public Int32 c_TaskStepNo  { get; set; }
        /// <summary>
        /// 订单Id
        ///</summary>
        //[Column("C_ORDERID")]
        public String c_OrderId  { get; set; }
        /// <summary>
        /// 起始点位
        ///</summary>
        //[Column("C_STARTPOINT")]
        public Int32 c_StartPoint  { get; set; }
        /// <summary>
        /// 终点点位
        ///</summary>
        //[Column("C_ENDPOINT")]
        public Int32 c_EndPoint  { get; set; }
        /// <summary>
        /// 目的地
        ///</summary>
        //[Column("C_TARGETLOC")]
        public Int32 c_TargetLoc  { get; set; }
        /// <summary>
        /// 运行状态
        ///</summary>
        //[Column("C_WORKSTATE")]
        public Int32 c_WorkState  { get; set; }
        /// <summary>
        /// 错误代码
        ///</summary>
        //[Column("C_ERRORCODE")]
        public String c_ErrorCode  { get; set; }
        /// <summary>
        /// 电池状态
        ///</summary>
        //[Column("C_BATTERYSTATE")]
        public Int32 c_BatteryState  { get; set; }
        /// <summary>
        /// 机械臂状态
        ///</summary>
        //[Column("C_ROBOTSTATE")]
        public Int32 c_RobotState  { get; set; }
        /// <summary>
        /// 机械臂错误代码
        ///</summary>
        //[Column("C_ROBOTERRORCODE")]
        public String c_RobotErrorCode  { get; set; }
        /// <summary>
        /// AGV操作码
        ///</summary>
        //[Column("C_WORKCODE")]
        public Int32 c_WorkCode  { get; set; }
        /// <summary>
        /// 电量百分比
        ///</summary>
        //[Column("C_BATTERYVOLUME")]
        public String c_BatteryVolume  { get; set; }
        /// <summary>
        /// 电压百分比
        ///</summary>
        //[Column("C_BATTERYVOLTAGE")]
        public String c_BatteryVoltage  { get; set; }
        /// <summary>
        /// 避让车号
        ///</summary>
        //[Column("C_AVOIDAGVID")]
        public Int32 c_AvoidAgvId  { get; set; }
        /// <summary>
        /// 删除标记
        ///</summary>
        //[Column("C_DELETEMARK")]
        public Int32 c_DeleteMark  { get; set; }
        /// <summary>
        /// 启用标记
        ///</summary>
        //[Column("C_ENABLEDMARK")]
        public Int32 c_EnabledMark  { get; set; }
        /// <summary>
        /// 时间戳
        ///</summary>
        //[Column("C_TIMESTAMP")]
        public DateTime c_TimeStamp  { get; set; }
        /// <summary>
        /// 扩展5
        ///</summary>
        //[Column("C_SW05")]
        public String c_Sw05  { get; set; }
        /// <summary>
        /// 扩展1
        ///</summary>
        //[Column("C_SW01")]
        public String c_Sw01  { get; set; }
        /// <summary>
        /// 扩展2
        ///</summary>
        //[Column("C_SW02")]
        public String c_Sw02  { get; set; }
        /// <summary>
        /// 扩展3
        ///</summary>
        //[Column("C_SW03")]
        public String c_Sw03  { get; set; }
        /// <summary>
        /// 扩展4
        ///</summary>
        //[Column("C_SW04")]
        public String c_Sw04  { get; set; }
        #endregion
    }
}
