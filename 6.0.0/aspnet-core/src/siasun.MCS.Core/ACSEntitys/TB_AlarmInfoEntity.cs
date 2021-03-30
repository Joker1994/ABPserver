
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
    public partial class TB_AlarmInfoEntity : Entity<long>
    {
        #region 实体成员
        /// <summary>
        /// 主键
        ///</summary>
        //[Column("C_ID")]
        public String C_ID  { get; set; }
        /// <summary>
        /// 设备ID
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
        /// 状态标识
        ///</summary>
        //[Column("N_STATE")]
        public Int32? N_State  { get; set; }
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
        /// 最近更新时间
        ///</summary>
        //[Column("C_UPDATETIME")]
        public DateTime? C_UpdateTime  { get; set; }
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
