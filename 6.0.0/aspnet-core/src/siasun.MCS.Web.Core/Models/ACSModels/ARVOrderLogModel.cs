using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siasun.MCS.Models.ACSModels
{
    public class ARVOrderLogModel
    {
        public class ARVOrderLogQueryData
        {
            public string arvid { get; set; }
            public int current { get; set; }
            public string arvstatus { get; set; }
            public string agvtype { get; set; }
            public string order { get; set; }
            public int pageSize { get; set; }
            public object sorter { get; set; }
            public object filter { get; set; }
        }
        public class ARVOrderLogTableData
        {
            public string arvid { get; set; }
            public string arvname { get; set; }         //ARV Desc
            public string c_AGVType { get; set; }
            public string arvstatus { get; set; }
            public string order { get; set; }           //OrderId
            public string actiontype { get; set; }      //Pick|Put 
            public string source { get; set; }          //SourceLocation   device+port   TT-M4-001 24
            public string target { get; set; }          //TargetLocation
            public string agverror { get; set; }        //AGV 错误码
            public string roboterror { get; set; }      //手臂错误码
            public string battery { get; set; }         //电池电量

        }
        public class ARVOrderLogFormReturn
        {
            public List<ARVOrderLogTableData> data { get; set; }
            public int total { get; set; }
            public string success { get; set; }
            public int pageSize { get; set; }
            public int current { get; set; }

        }
    }
}
