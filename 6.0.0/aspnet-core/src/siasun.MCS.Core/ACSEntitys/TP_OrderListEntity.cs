
using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace siasun.MCS.ACSEntitys
{
   /// <summary>
   /// 版 本SSACS开发框架
   /// Copyright (c) 2018-2020 上海新松机器人有限公司
   /// 创 建：朱均岭
   /// 描 述：entity
   ///</summary>
    public partial class TP_OrderListEntity : Entity<long>
    {
        #region 实体成员
        /// <summary>
        /// 主键
        ///</summary>
        //[Column("C_ID")]
        public String c_Id  { get; set; }
        /// <summary>
        /// 订单编号
        ///</summary>
        //[Column("C_ORDERID")]
        public String c_OrderID  { get; set; }
        /// <summary>
        /// 订单类型
        ///</summary>
        //[Column("C_ORDERTYPE")]
        public String c_OrderType  { get; set; }
        /// <summary>
        /// 订单来源
        ///</summary>
        //[Column("C_ORDERSOURCE")]
        public Int32? c_OrderSource  { get; set; }
        /// <summary>
        /// 组合订单类型
        ///</summary>
        //[Column("C_GROUPTYPE")]
        public Int32? c_GroupType { get; set; }
        /// <summary>
        /// 组合订单号
        ///</summary>
        //[Column("C_GROUPORDER")]
        public String c_GroupOrder  { get; set; }
        /// <summary>
        /// 组合任务数量
        ///</summary>
        //[Column("C_GROUPCOUNT")]
        public Int32? c_GroupCount { get; set; }
        /// <summary>
        /// 组合订单顺序
        ///</summary>
        //[Column("C_GROUPSEQUENCE")]
        public Int32? c_GroupSequence { get; set; }
        /// <summary>
        /// 优先级
        ///</summary>
        //[Column("C_PRIORITY")]
        public Int32? c_Priority  { get; set; }
        /// <summary>
        /// 取货机台
        ///</summary>
        //[Column("C_SOURCELOC")]
        public String c_SourceLoc  { get; set; }
        /// <summary>
        /// 取货端口
        ///</summary>
        //[Column("C_SOURCEPORT")]
        public String c_SourcePort  { get; set; }
        /// <summary>
        /// 送货机台
        ///</summary>
        //[Column("C_TARGETLOC")]
        public String c_TargetLoc  { get; set; }
        /// <summary>
        /// 送货端口
        ///</summary>
        //[Column("C_TARGETPORT")]
        public String c_TargetPort  { get; set; }
        /// <summary>
        /// 物料号
        ///</summary>
        //[Column("C_PROCESSPLAN")]
        public String c_ProcessPlan  { get; set; }
        /// <summary>
        /// 载具ID
        ///</summary>
        //[Column("C_CARRIERID")]
        public String c_CarrierID  { get; set; }
        /// <summary>
        /// 货物盘数
        ///</summary>
        //[Column("C_PROCESSSTEP")]
        public String c_ProcessStep { get; set; }
        /// <summary>
        /// 批次信息
        ///</summary>
        //[Column("C_LOTINFO")]
        public String c_LotInfo  { get; set; }
        /// <summary>
        /// 执行标识
        ///</summary>
        //[Column("C_CANSTART")]
        public Boolean? c_CanStart  { get; set; }
        /// <summary>
        /// 区域标识
        ///</summary>
        //[Column("C_CARRIERTYPE")]
        public String c_CarrierType  { get; set; }
        /// <summary>
        /// 预计时间
        ///</summary>
        //[Column("C_DUETIME")]
        public DateTime? c_DueTime  { get; set; }
        /// <summary>
        /// 处理标记
        ///</summary>
        //[Column("C_HANDLEFLAG")]
        public Int32? c_HandleFlag  { get; set; }
        /// <summary>
        /// 人工处理
        ///</summary>
        //[Column("C_MANUALFLAG")]
        public Int32? c_ManualFlag  { get; set; }
        /// <summary>
        /// 车型
        ///</summary>
        //[Column("N_AGVTYPE")]
        public Int32? n_AGVType  { get; set; }
        /// <summary>
        /// 车型编号
        ///</summary>
        //[Column("N_AGVID")]
        public Int32? n_AGVID  { get; set; }
        /// <summary>
        /// 生成时间
        ///</summary>
        //[Column("D_CREATETIME")]
        public DateTime? d_CreateTime  { get; set; }
        /// <summary>
        /// 预计时间
        ///</summary>
        //[Column("D_PREDICTTIME")]
        public DateTime? d_PredictTime  { get; set; }
        /// <summary>
        /// 开始时间
        ///</summary>
        //[Column("D_STARTTIME")]
        public DateTime? d_StartTime  { get; set; }
        /// <summary>
        /// 完成时间
        ///</summary>
        //[Column("D_ENDTIME")]
        public DateTime? d_EndTime  { get; set; }
        /// <summary>
        /// 拆分时间
        ///</summary>
        //[Column("D_ANALYZETIME")]
        public DateTime? d_AnalyzeTime  { get; set; }
        /// <summary>
        /// 删除标记
        ///</summary>
        //[Column("C_DELETEMARK")]
        public Int32? c_DeleteMark  { get; set; }
        /// <summary>
        /// 启用标记
        ///</summary>
        //[Column("C_ENABLEDMARK")]
        public Int32? c_EnabledMark  { get; set; }
        /// <summary>
        /// 时间戳
        ///</summary>
        //[Column("C_TIMESTAMP")]
        public DateTime c_TimeStamp  { get; set; }
        /// <summary>
        /// 任务数量
        ///</summary>
        //[Column("C_TASKCOUNT")]
        public Int32? c_TaskCount  { get; set; }
        /// <summary>
        /// 成功数量
        ///</summary>
        //[Column("C_CARRIERSTATUS")]
        public String c_CarrierStatus { get; set; }
        /// <summary>
        /// 扩展1
        ///</summary>
        //[Column("C_CARRIERPROCESSINGSTATUS")]
        public String c_CarrierProcessingStatus { get; set; }
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
        /// <summary>
        /// 取货机台类型
        ///</summary>
        //[Column("C_SOURCELOCTYPE")]
        public String c_SourceLocType { get; set; }
        /// <summary>
        /// 送货机台类型
        ///</summary>
        //[Column("C_TARGETLOCTYPE")]
        public String c_TargetLocType { get; set; }
        #endregion
        
    }
}
