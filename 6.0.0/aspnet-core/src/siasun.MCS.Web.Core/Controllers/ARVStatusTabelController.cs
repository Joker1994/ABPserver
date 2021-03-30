using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using Abp.UI;
using siasun.MCS.Authentication.External;
using siasun.MCS.Authentication.JwtBearer;
using siasun.MCS.Authorization;
using siasun.MCS.Authorization.Users;
using siasun.MCS.Models.TokenAuth;
using siasun.MCS.MultiTenancy;
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;
using siasun.MCS.Models.ACSModels;

namespace siasun.MCS.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ARVStatusTabelController : MCSControllerBase
    {

        protected readonly ITP_ARVStatusEntityAppService ArvStatusService;
        protected readonly ITP_OrderListEntityAppService OrderListService;
        public ARVStatusTabelController(ITP_ARVStatusEntityAppService arvStatusService, ITP_OrderListEntityAppService orderListService, PermissionChecker permissionChecker)
        {
            ArvStatusService = arvStatusService;
            OrderListService = orderListService;
        }
        [HttpPost]
        public async Task<ARVStatusTabelModel.ARVStatusFormReturn> PostARVStatusTableDataAsync([FromBody] ARVStatusTabelModel.ARVStatusQueryData obj1)
        {
            List<ARVStatusTabelModel.ARVStatusTableData> resultList = new List<ARVStatusTabelModel.ARVStatusTableData>();
            Type type = typeof(ARVStatusTabelModel.ARVStatusTableData);
            GetTP_ARVStatusEntitysInput input = new GetTP_ARVStatusEntitysInput();
            var arvs = await ArvStatusService.GetPaged(input);

            foreach (var i in arvs.Items)
            {
                ARVStatusTabelModel.ARVStatusTableData obj = (ARVStatusTabelModel.ARVStatusTableData)type.Assembly.CreateInstance(type.ToString());
                obj.arvid = i.c_ARVId.ToString();
                obj.arvname = i.c_ARVDesc;
                obj.c_AGVType = i.c_ARVType.ToString();
                if (i.c_WorkState >= 1 && i.c_WorkState <= 6) { i.c_WorkState = 1; }
                obj.arvstatus = i.c_WorkState.ToString();
                obj.order = i.c_OrderId;
                obj.actiontype = i.c_TaskType == 1 ? "Pick" : "Put";
                obj.source = i.c_Sw03;//查订单
                obj.target = i.c_Sw04;
                obj.agverror = i.c_ErrorCode;
                obj.roboterror = i.c_RobotErrorCode;
                obj.battery = i.c_BatteryVoltage;
                resultList.Add(obj);
            }
            ARVStatusTabelModel.ARVStatusFormReturn ARVStatusFormReturn = new ARVStatusTabelModel.ARVStatusFormReturn();
            ARVStatusFormReturn.data = resultList;
            ARVStatusFormReturn.pageSize = obj1.pageSize;
            ARVStatusFormReturn.success = "true";
            ARVStatusFormReturn.total = arvs.TotalCount;
            ARVStatusFormReturn.current = obj1.current;


            //ARVStatusTableDataList ARVStatusTableData = new ARVStatusTableDataList();
            //ARVStatusTableData.arvstatus = resultList;
            return ARVStatusFormReturn;
        }
    }
    public class queryData
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
    public class tableData
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
    public class formReturn
    {
        public List<tableData> data { get; set; }
        public int total { get; set; }
        public string success { get; set; }
        public int pageSize { get; set; }
        public int current { get; set; }

    }

}
