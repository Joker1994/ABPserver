using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siasun.MCS.ACSEntitys
{
    public class TP_ARVStatusEntity : Entity<long>
    {
        #region 实体成员
        /// <summary>
        /// 编号
        ///</summary>
        public virtual String c_Id { get; set; }
        /// <summary>
        /// ARV编号
        ///</summary>
        public virtual Int32? c_ARVId { get; set; }
        /// <summary>
        /// ARV描述
        ///</summary>
        public virtual String c_ARVDesc { get; set; }
        /// <summary>
        /// ARV类型
        ///</summary>
        public virtual Int32? c_ARVType { get; set; }
        /// <summary>
        /// 任务Id
        ///</summary>
        public virtual String c_TaskId { get; set; }
        /// <summary>
        /// 任务类型
        ///</summary>
        public virtual Int32? c_TaskType { get; set; }
        /// <summary>
        /// 任务步号
        ///</summary>
        public virtual Int32? c_TaskStepNo { get; set; }
        /// <summary>
        /// 订单Id
        ///</summary>
        public virtual String c_OrderId { get; set; }
        /// <summary>
        /// 起始点位
        ///</summary>
        public virtual Int32? c_StartPoint { get; set; }
        /// <summary>
        /// 终点点位
        ///</summary>
        public virtual Int32? c_EndPoint { get; set; }
        /// <summary>
        /// 目的地
        ///</summary>
        public virtual Int32? c_TargetLoc { get; set; }
        /// <summary>
        /// 运行状态
        ///</summary>
        public virtual Int32? c_WorkState { get; set; }
        /// <summary>
        /// 错误代码
        ///</summary>
        public virtual String c_ErrorCode { get; set; }
        /// <summary>
        /// 电池状态
        ///</summary>
        public virtual Int32? c_BatteryState { get; set; }
        /// <summary>
        /// 机械臂状态
        ///</summary>
        public virtual Int32? c_RobotState { get; set; }
        /// <summary>
        /// 机械臂错误代码
        ///</summary>
        public virtual String c_RobotErrorCode { get; set; }
        /// <summary>
        /// AGV操作码
        ///</summary>
        public virtual Int32? c_WorkCode { get; set; }
        /// <summary>
        /// 电量百分比
        ///</summary>
        public virtual String c_BatteryVolume { get; set; }
        /// <summary>
        /// 电压百分比
        ///</summary>
        public virtual String c_BatteryVoltage { get; set; }
        /// <summary>
        /// 避让车号
        ///</summary>
        public virtual Int32? c_AvoidAgvId { get; set; }
        /// <summary>
        /// 删除标记
        ///</summary>
        public virtual Int32? c_DeleteMark { get; set; }
        /// <summary>
        /// 启用标记
        ///</summary>
        public virtual Int32? c_EnabledMark { get; set; }
        /// <summary>
        /// 时间戳
        ///</summary>
        public virtual DateTime c_TimeStamp { get; set; }
        /// <summary>
        /// 扩展5
        ///</summary>
        public virtual String c_Sw05 { get; set; }
        /// <summary>
        /// 扩展1
        ///</summary>
        public virtual String c_Sw01 { get; set; }
        /// <summary>
        /// 扩展2
        ///</summary>
        public virtual String c_Sw02 { get; set; }
        /// <summary>
        /// 扩展3
        ///</summary>
        public virtual String c_Sw03 { get; set; }
        /// <summary>
        /// 扩展4
        ///</summary>
        public virtual String c_Sw04 { get; set; }
        #endregion
    }
}
