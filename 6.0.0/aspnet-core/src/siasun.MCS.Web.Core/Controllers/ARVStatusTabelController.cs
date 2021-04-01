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
            //input.TP_ARVStatusEntity.c_ARVId = obj1.arvid;
            //input.TP_ARVStatusEntity
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
   

}
