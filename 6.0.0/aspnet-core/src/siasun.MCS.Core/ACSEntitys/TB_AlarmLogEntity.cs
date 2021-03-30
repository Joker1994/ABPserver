
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
    public partial class TB_AlarmLogEntity : Entity<long>
    {
        #region 实体成员
        /// <summary>
        /// 主键
        ///</summary>
        //[Column("C_ID")]
        public String C_ID  { get; set; }
        /// <summary>
        /// 报警时间
        ///</summary>
        //[Column("C_LOGTIME")]
        public DateTime? C_LogTime  { get; set; }
        /// <summary>
        /// 消息编号
        ///</summary>
        //[Column("C_ERRORCODE")]
        public String C_ErrorCode  { get; set; }
        /// <summary>
        /// 设备
        ///</summary>
        //[Column("C_DEVICEID")]
        public String C_DeviceID  { get; set; }
        /// <summary>
        /// 设备类型
        ///</summary>
        //[Column("C_DEVICETYPE")]
        public String C_DeviceType  { get; set; }
        /// <summary>
        /// 设备描述
        ///</summary>
        //[Column("C_DEVICEDESC")]
        public String C_DeviceDesc  { get; set; }
        /// <summary>
        /// 报警类型
        ///</summary>
        //[Column("C_TYPE")]
        public String C_Type  { get; set; }
        /// <summary>
        /// 故障原因
        ///</summary>
        //[Column("C_REASON")]
        public String C_Reason  { get; set; }
        /// <summary>
        /// 解决措施
        ///</summary>
        //[Column("C_MEASURE")]
        public String C_Measure  { get; set; }
        /// <summary>
        /// 恢复时间
        ///</summary>
        //[Column("C_RESTORETIME")]
        public DateTime? C_RestoreTime  { get; set; }
        /// <summary>
        /// 时间戳
        ///</summary>
        //[Column("C_TIMESTAMP")]
        public DateTime? C_TimeStamp  { get; set; }
        /// <summary>
        /// 扩展1
        ///</summary>
        //[Column("C_SW01")]
        public String C_Sw01  { get; set; }
        /// <summary>
        /// 扩展2
        ///</summary>
        //[Column("C_SW02")]
        public String C_Sw02  { get; set; }
        /// <summary>
        /// 扩展3
        ///</summary>
        //[Column("C_SW03")]
        public String C_Sw03  { get; set; }
        /// <summary>
        /// 扩展4
        ///</summary>
        //[Column("C_SW04")]
        public String C_Sw04  { get; set; }
        /// <summary>
        /// 扩展5
        ///</summary>
        //[Column("C_SW05")]
        public String C_Sw05  { get; set; }
        #endregion
        
    }
}
