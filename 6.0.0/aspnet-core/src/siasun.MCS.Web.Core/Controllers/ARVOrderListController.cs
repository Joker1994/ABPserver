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
    public class ARVOrderListController : MCSControllerBase
    {
        protected readonly ITP_OrderListEntityAppService OrderListService;

        public ARVOrderListController(ITP_OrderListEntityAppService orderListService, PermissionChecker permissionChecker)
        {
            OrderListService = orderListService;
        }

        [HttpPost]
        public async Task<ARVOrderListModel.ARVOrderListFormReturn> PostAlarmInfoDataAsync([FromBody] ARVOrderListModel.ARVOrderListQueryData obj1)
        {
            List<ARVOrderListModel.ARVOrderListTableData> resultList = new List<ARVOrderListModel.ARVOrderListTableData>();
            Type type = typeof(ARVOrderListModel.ARVOrderListTableData);
            GetTP_OrderListEntitysInput input = new GetTP_OrderListEntitysInput();
            var arvs = await OrderListService.GetPaged(input);

            foreach (var i in arvs.Items)
            {
                ARVOrderListModel.ARVOrderListTableData obj = (ARVOrderListModel.ARVOrderListTableData)type.Assembly.CreateInstance(type.ToString());
                obj.arvid = i.c_CarrierID;
                //obj.arvname = i.c_ARVDesc;
                //obj.c_AGVType = i.c_ARVType.ToString();
                //if (i.c_WorkState >= 1 && i.c_WorkState <= 6) { i.c_WorkState = 1; }
                //obj.arvstatus = i.c_WorkState.ToString();
                //obj.order = i.c_OrderId;
                //obj.actiontype = i.c_TaskType == 1 ? "Pick" : "Put";
                //obj.source = "TT-M4-001 24";//查订单
                //obj.target = "DS001 A";
                //obj.agverror = i.c_ErrorCode;
                //obj.roboterror = i.c_RobotErrorCode;
                //obj.battery = i.c_BatteryVoltage;
                resultList.Add(obj);
            }
            ARVOrderListModel.ARVOrderListFormReturn AlarmFormReturn = new ARVOrderListModel.ARVOrderListFormReturn();
            AlarmFormReturn.data = resultList;
            AlarmFormReturn.pageSize = obj1.pageSize;
            AlarmFormReturn.success = "true";
            AlarmFormReturn.total = arvs.TotalCount;
            AlarmFormReturn.current = obj1.current;


            //AlarmTableDataList AlarmTableData = new AlarmTableDataList();
            //AlarmTableData.arvstatus = resultList;
            return AlarmFormReturn;
        }
    }

}
