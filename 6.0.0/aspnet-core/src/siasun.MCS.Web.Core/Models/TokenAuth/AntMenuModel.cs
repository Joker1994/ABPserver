using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siasun.MCS.Models.TokenAuth
{
    public class AntMenuModel
    {
        public bool autoLogin { get; set; }
        /// <summary>
        /// 控制命令
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 控制对象
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 命令序号
        /// </summary>
        public string userName { get; set; }
    }
}
