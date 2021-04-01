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
    public partial class TP_OrderListEntity : Entity<String>
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
        /// c_OrderID
        ///</summary>
        //[Column("C_ORDERID")]
        public String c_OrderID  { get; set; }
        /// <summary>
        /// MagazineFromEquipmentToShelf
        ///</summary>
        //[Column("C_ORDERTYPE")]
        public String c_OrderType  { get; set; }
        /// <summary>
        /// c_OrderTypeNumber
        ///</summary>
        //[Column("C_ORDERTYPENUMBER")]
        public String c_OrderTypeNumber  { get; set; }
        /// <summary>
        /// 1
        ///</summary>
        //[Column("C_ORDERSOURCE")]
        public Int32 c_OrderSource  { get; set; }
        /// <summary>
        /// c_GroupType
        ///</summary>
        //[Column("C_GROUPTYPE")]
        public Int32 c_GroupType  { get; set; }
        /// <summary>
        /// 组合任务的顺序
        ///</summary>
        //[Column("C_GROUPORDER")]
        public String c_GroupOrder  { get; set; }
        /// <summary>
        /// c_Priority
        ///</summary>
        //[Column("C_PRIORITY")]
        public Int32 c_Priority  { get; set; }
        /// <summary>
        /// c_SourceLoc
        ///</summary>
        //[Column("C_SOURCELOC")]
        public String c_SourceLoc  { get; set; }
        /// <summary>
        /// c_SourceLocType
        ///</summary>
        //[Column("C_SOURCELOCTYPE")]
        public String c_SourceLocType  { get; set; }
        /// <summary>
        /// c_SourcePort
        ///</summary>
        //[Column("C_SOURCEPORT")]
        public String c_SourcePort  { get; set; }
        /// <summary>
        /// c_TargetLoc
        ///</summary>
        //[Column("C_TARGETLOC")]
        public String c_TargetLoc  { get; set; }
        /// <summary>
        /// c_TargetLocType
        ///</summary>
        //[Column("C_TARGETLOCTYPE")]
        public String c_TargetLocType  { get; set; }
        /// <summary>
        /// c_TargetPort
        ///</summary>
        //[Column("C_TARGETPORT")]
        public String c_TargetPort  { get; set; }
        /// <summary>
        /// c_ProcessPlan
        ///</summary>
        //[Column("C_PROCESSPLAN")]
        public String c_ProcessPlan  { get; set; }
        /// <summary>
        /// c_CarrierID
        ///</summary>
        //[Column("C_CARRIERID")]
        public String c_CarrierID  { get; set; }
        /// <summary>
        /// c_ProcessStep
        ///</summary>
        //[Column("C_PROCESSSTEP")]
        public String c_ProcessStep  { get; set; }
        /// <summary>
        /// c_LotInfo
        ///</summary>
        //[Column("C_LOTINFO")]
        public String c_LotInfo  { get; set; }
        /// <summary>
        /// c_CanStart
        ///</summary>
        //[Column("C_CANSTART")]
        public Boolean c_CanStart  { get; set; }
        /// <summary>
        /// c_CarrierType
        ///</summary>
        //[Column("C_CARRIERTYPE")]
        public String c_CarrierType  { get; set; }
        /// <summary>
        /// c_DueTime
        ///</summary>
        //[Column("C_DUETIME")]
        public DateTime c_DueTime  { get; set; }
        /// <summary>
        /// c_HandleFlag
        ///</summary>
        //[Column("C_HANDLEFLAG")]
        public Int32 c_HandleFlag  { get; set; }
        /// <summary>
        /// c_ManualFlag
        ///</summary>
        //[Column("C_MANUALFLAG")]
        public Int32 c_ManualFlag  { get; set; }
        /// <summary>
        /// n_AGVType
        ///</summary>
        //[Column("N_AGVTYPE")]
        public Int32 n_AGVType  { get; set; }
        /// <summary>
        /// n_AGVID
        ///</summary>
        //[Column("N_AGVID")]
        public Int32 n_AGVID  { get; set; }
        /// <summary>
        /// d_CreateTime
        ///</summary>
        //[Column("D_CREATETIME")]
        public DateTime d_CreateTime  { get; set; }
        /// <summary>
        /// d_PredictTime
        ///</summary>
        //[Column("D_PREDICTTIME")]
        public DateTime d_PredictTime  { get; set; }
        /// <summary>
        /// d_StartTime
        ///</summary>
        //[Column("D_STARTTIME")]
        public DateTime d_StartTime  { get; set; }
        /// <summary>
        /// d_EndTime
        ///</summary>
        //[Column("D_ENDTIME")]
        public DateTime d_EndTime  { get; set; }
        /// <summary>
        /// d_AnalyzeTime
        ///</summary>
        //[Column("D_ANALYZETIME")]
        public DateTime d_AnalyzeTime  { get; set; }
        /// <summary>
        /// c_DeleteMark
        ///</summary>
        //[Column("C_DELETEMARK")]
        public Int32 c_DeleteMark  { get; set; }
        /// <summary>
        /// c_EnabledMark
        ///</summary>
        //[Column("C_ENABLEDMARK")]
        public Int32 c_EnabledMark  { get; set; }
        /// <summary>
        /// c_TimeStamp
        ///</summary>
        //[Column("C_TIMESTAMP")]
        public DateTime c_TimeStamp  { get; set; }
        /// <summary>
        /// c_TaskCount
        ///</summary>
        //[Column("C_TASKCOUNT")]
        public Int32 c_TaskCount  { get; set; }
        /// <summary>
        /// c_CarrierStatus
        ///</summary>
        //[Column("C_CARRIERSTATUS")]
        public String c_CarrierStatus  { get; set; }
        /// <summary>
        /// C_SW02
        ///</summary>
        //[Column("C_SW02")]
        public Double C_SW02  { get; set; }
        /// <summary>
        /// c_CarrierProcessingStatus
        ///</summary>
        //[Column("C_CARRIERPROCESSINGSTATUS")]
        public String c_CarrierProcessingStatus  { get; set; }
        /// <summary>
        /// c_LocationUpdateDateTime
        ///</summary>
        //[Column("C_LOCATIONUPDATEDATETIME")]
        public String c_LocationUpdateDateTime  { get; set; }
        /// <summary>
        /// c_Department
        ///</summary>
        //[Column("C_DEPARTMENT")]
        public String c_Department  { get; set; }
        /// <summary>
        /// C_SW03
        ///</summary>
        //[Column("C_SW03")]
        public Double C_SW03  { get; set; }
        /// <summary>
        /// c_Sw04
        ///</summary>
        //[Column("C_SW04")]
        public String c_Sw04  { get; set; }
        /// <summary>
        /// c_Sw05
        ///</summary>
        //[Column("C_SW05")]
        public String c_Sw05  { get; set; }
        /// <summary>
        /// c_GroupCount
        ///</summary>
        //[Column("C_GROUPCOUNT")]
        public Int32 c_GroupCount  { get; set; }
        /// <summary>
        /// c_GroupSequence
        ///</summary>
        //[Column("C_GROUPSEQUENCE")]
        public Int32 c_GroupSequence  { get; set; }
        #endregion
    }
}
