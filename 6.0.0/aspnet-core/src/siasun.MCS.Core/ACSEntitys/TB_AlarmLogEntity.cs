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
    public partial class TB_AlarmLogEntity : Entity<String>
    {
        #region 实体成员
        /// <summary>
        /// 编号
        ///</summary>
        ////[Column("C_ID")]
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Set id auto increase
        public String C_ID { get; set; }
        /// <summary>
        /// C_LogTime
        ///</summary>
        //[Column("C_LOGTIME")]
        public DateTime C_LogTime { get; set; }
        /// <summary>
        /// C_ErrorCode
        ///</summary>
        //[Column("C_ERRORCODE")]
        public String C_ErrorCode { get; set; }
        /// <summary>
        /// C_DeviceID
        ///</summary>
        //[Column("C_DEVICEID")]
        public String C_DeviceID { get; set; }
        /// <summary>
        /// C_DeviceType
        ///</summary>
        //[Column("C_DEVICETYPE")]
        public String C_DeviceType { get; set; }
        /// <summary>
        /// C_DeviceDesc
        ///</summary>
        //[Column("C_DEVICEDESC")]
        public String C_DeviceDesc { get; set; }
        /// <summary>
        /// C_Type
        ///</summary>
        //[Column("C_TYPE")]
        public String C_Type { get; set; }
        /// <summary>
        /// C_Reason
        ///</summary>
        //[Column("C_REASON")]
        public String C_Reason { get; set; }
        /// <summary>
        /// C_Measure
        ///</summary>
        //[Column("C_MEASURE")]
        public String C_Measure { get; set; }
        /// <summary>
        /// C_RestoreTime
        ///</summary>
        //[Column("C_RESTORETIME")]
        public DateTime C_RestoreTime { get; set; }
        /// <summary>
        /// C_TimeStamp
        ///</summary>
        //[Column("C_TIMESTAMP")]
        public DateTime C_TimeStamp { get; set; }
        /// <summary>
        /// C_Sw01
        ///</summary>
        //[Column("C_SW01")]
        public String C_Sw01 { get; set; }
        /// <summary>
        /// C_Sw02
        ///</summary>
        //[Column("C_SW02")]
        public String C_Sw02 { get; set; }
        /// <summary>
        /// C_Sw03
        ///</summary>
        //[Column("C_SW03")]
        public String C_Sw03 { get; set; }
        /// <summary>
        /// C_Sw04
        ///</summary>
        //[Column("C_SW04")]
        public String C_Sw04 { get; set; }
        /// <summary>
        /// C_Sw05
        ///</summary>
        //[Column("C_SW05")]
        public String C_Sw05 { get; set; }
        #endregion
    }
}
