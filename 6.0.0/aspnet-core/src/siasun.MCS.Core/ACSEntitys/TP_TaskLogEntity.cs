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
    public partial class TP_TaskLogEntity : Entity<String>
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
        /// 任务编号
        ///</summary>
        //[Column("C_TASKID")]
        public String c_TaskId  { get; set; }
        /// <summary>
        /// 任务数
        ///</summary>
        //[Column("C_TASKCOUNT")]
        public Int32 c_TaskCount  { get; set; }
        /// <summary>
        /// 任务步
        ///</summary>
        //[Column("C_TASKNO")]
        public Int32 c_TaskNo  { get; set; }
        /// <summary>
        /// AGV编号
        ///</summary>
        //[Column("C_AGVID")]
        public Int32 c_AGVId  { get; set; }
        /// <summary>
        /// AGV类型
        ///</summary>
        //[Column("C_AGVTYPE")]
        public Int32 c_AGVType  { get; set; }
        /// <summary>
        /// 当前点位
        ///</summary>
        //[Column("C_NOWMAPLOC")]
        public Int32 c_NowMapLoc  { get; set; }
        /// <summary>
        /// 目标工作位
        ///</summary>
        //[Column("C_WORKMAPLOC")]
        public Int32 c_WorkMapLoc  { get; set; }
        /// <summary>
        /// AGV任务类型
        ///</summary>
        //[Column("C_AGVTASKTYPE")]
        public Int32 c_AGVTaskType  { get; set; }
        /// <summary>
        /// Robot任务类型
        ///</summary>
        //[Column("C_ROBOTTASKTYPE")]
        public Int32 c_RobotTaskType  { get; set; }
        /// <summary>
        /// 目标机台
        ///</summary>
        //[Column("C_WORKLOC")]
        public String c_WorkLoc  { get; set; }
        /// <summary>
        /// 目标机台端口
        ///</summary>
        //[Column("C_WORKPORT")]
        public String c_WorkPort  { get; set; }
        /// <summary>
        /// Robot控制码1
        ///</summary>
        //[Column("C_TASKCODE")]
        public Int32 c_TaskCode  { get; set; }
        /// <summary>
        /// Robot控制码2
        ///</summary>
        //[Column("C_TASKCODE2")]
        public Int32 c_TaskCode2  { get; set; }
        /// <summary>
        /// 载具ID
        ///</summary>
        //[Column("C_CARRIERID")]
        public String c_CarrierID  { get; set; }
        /// <summary>
        /// 优先级
        ///</summary>
        //[Column("C_PRIORITY")]
        public Int32 c_Priority  { get; set; }
        /// <summary>
        /// 预计时间
        ///</summary>
        //[Column("D_DUETIME")]
        public String d_DueTime  { get; set; }
        /// <summary>
        /// 楼层号
        ///</summary>
        //[Column("C_FLOORNO")]
        public Int32 c_FloorNo  { get; set; }
        /// <summary>
        /// 区域标识
        ///</summary>
        //[Column("C_AREAINDEX")]
        public Int32 c_AreaIndex  { get; set; }
        /// <summary>
        /// 订单编号
        ///</summary>
        //[Column("C_ORDERID")]
        public String c_OrderId  { get; set; }
        /// <summary>
        /// 订单类型
        ///</summary>
        //[Column("C_ORDERTYPE")]
        public Int32 c_OrderType  { get; set; }
        /// <summary>
        /// 组合标记
        ///</summary>
        //[Column("C_GROUPMARK")]
        public Int32 c_GroupMark  { get; set; }
        /// <summary>
        /// 组合Id
        ///</summary>
        //[Column("C_GROUPID")]
        public String c_GroupId  { get; set; }
        /// <summary>
        /// 组合类型
        ///</summary>
        //[Column("C_GROUPTYPE")]
        public Int32 c_GroupType  { get; set; }
        /// <summary>
        /// 组合顺序
        ///</summary>
        //[Column("C_GROUPORDER")]
        public Int32 c_GroupOrder  { get; set; }
        /// <summary>
        /// ARS任务标识
        ///</summary>
        //[Column("C_ARSTASKMARK")]
        public Int32 c_ARSTaskmark  { get; set; }
        /// <summary>
        /// 处理标记
        ///</summary>
        //[Column("C_HANDLEFLAG")]
        public Int32 c_HandleFlag  { get; set; }
        /// <summary>
        /// 人工处理
        ///</summary>
        //[Column("C_MANUALFLAG")]
        public Int32 c_ManualFlag  { get; set; }
        /// <summary>
        /// 生成时间
        ///</summary>
        //[Column("D_CREATETIME")]
        public DateTime d_CreateTime  { get; set; }
        /// <summary>
        /// 发送时间
        ///</summary>
        //[Column("D_SENDTIME")]
        public DateTime d_SendTime  { get; set; }
        /// <summary>
        /// 开始时间
        ///</summary>
        //[Column("D_STARTTIME")]
        public DateTime d_StartTime  { get; set; }
        /// <summary>
        /// 完成时间
        ///</summary>
        //[Column("D_ENDTIME")]
        public DateTime d_EndTime  { get; set; }
        /// <summary>
        /// 机器人开始时间
        ///</summary>
        //[Column("D_ACTIONTIME")]
        public DateTime d_ActionTime  { get; set; }
        /// <summary>
        /// 机器人执行结束时间
        ///</summary>
        //[Column("D_DONETIME")]
        public DateTime d_DoneTime  { get; set; }
        /// <summary>
        /// 小车解锁时间
        ///</summary>
        //[Column("D_UNLOCKTIME")]
        public DateTime d_UnlockTime  { get; set; }
        /// <summary>
        /// 小车运行时间
        ///</summary>
        //[Column("D_AGVTIME")]
        public String d_AGVTime  { get; set; }
        /// <summary>
        /// 机械臂运行时间
        ///</summary>
        //[Column("D_ROBOTTIME")]
        public String d_RobotTime  { get; set; }
        /// <summary>
        /// ASD上报标识
        ///</summary>
        //[Column("C_ASDCONFIRMFLAG")]
        public Int32 c_ASDConfirmFlag  { get; set; }
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
        /// 记录RFID验证结果1
        ///</summary>
        //[Column("C_RFIDCHECKRESULT")]
        public String c_RFIDCheckResult  { get; set; }
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
        /// <summary>
        /// 扩展5
        ///</summary>
        //[Column("C_SW05")]
        public String c_Sw05  { get; set; }
        #endregion
    }
}
