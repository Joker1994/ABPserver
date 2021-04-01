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
    public partial class TB_MapInfoEntity : Entity<String>
    {
        #region 实体成员
        /// <summary>
        /// 编号
        ///</summary>
        //[Column("C_ID")]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Set id auto increase
        public String c_Id  { get; set; }
        /// <summary>
        /// 地图点位值
        ///</summary>
        //[Column("C_MAPLOC")]
        public Int32? c_MapLoc  { get; set; }
        /// <summary>
        /// 点位描述
        ///</summary>
        //[Column("C_MAPDECS")]
        public String c_MapDecs  { get; set; }
        /// <summary>
        /// 设备编号
        ///</summary>
        //[Column("C_DEVICEID")]
        public String c_DeviceID  { get; set; }
        /// <summary>
        /// 设备值
        ///</summary>
        //[Column("C_DEVICEINDEX")]
        public Int32? c_DeviceIndex  { get; set; }
        /// <summary>
        /// 端口号
        ///</summary>
        //[Column("C_PORTNUM")]
        public String c_PortNum  { get; set; }
        /// <summary>
        /// 端口值
        ///</summary>
        //[Column("C_PORTINDEX")]
        public Int32? c_PortIndex  { get; set; }
        /// <summary>
        /// 点位类型
        ///</summary>
        //[Column("C_WORKTYPE")]
        public Int32? c_WorkType  { get; set; }
        /// <summary>
        /// 设备点位组合值
        ///</summary>
        //[Column("C_GROUPVALUE")]
        public Int32? c_GroupValue  { get; set; }
        /// <summary>
        /// 区域编号
        ///</summary>
        //[Column("C_AREAID")]
        public Int32? c_AreaId  { get; set; }
        /// <summary>
        /// 所在楼层
        ///</summary>
        //[Column("N_FLOORNO")]
        public String n_FloorNo  { get; set; }
        /// <summary>
        /// ARS标识
        ///</summary>
        //[Column("C_ARSMARK")]
        public Int32? c_ARSMark  { get; set; }
        /// <summary>
        /// 创建人
        ///</summary>
        //[Column("C_CREATEID")]
        public String c_CreateID  { get; set; }
        /// <summary>
        /// 创建人
        ///</summary>
        //[Column("C_CREATENAME")]
        public String c_CreateName  { get; set; }
        /// <summary>
        /// 创建时间
        ///</summary>
        //[Column("C_CREATETIME")]
        public DateTime? c_CreateTime  { get; set; }
        /// <summary>
        /// 修改人
        ///</summary>
        //[Column("C_MODIFYID")]
        public String c_ModifyID  { get; set; }
        /// <summary>
        /// 修改人
        ///</summary>
        //[Column("C_MODIFYNAME")]
        public String c_ModifyName  { get; set; }
        /// <summary>
        /// 修改时间
        ///</summary>
        //[Column("C_MODIFYTIME")]
        public DateTime? c_ModifyTime  { get; set; }
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
        #region 扩展操作

        #endregion
    }
}
