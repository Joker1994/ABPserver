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
    public class ARVTaskListController : MCSControllerBase
    {
        protected readonly ITP_TaskListEntityAppService TaskListService;

        public ARVTaskListController(ITP_TaskListEntityAppService orderListService, PermissionChecker permissionChecker)
        {
            TaskListService = orderListService;
        }

        [HttpPost]
        public async Task<ARVTaskListModel.ARVTaskListFormReturn> PostAlarmInfoDataAsync([FromBody] ARVTaskListModel.ARVTaskListQueryData obj1)
        {
            List<ARVTaskListModel.ARVTaskListTableData> resultList = new List<ARVTaskListModel.ARVTaskListTableData>();
            Type type = typeof(ARVTaskListModel.ARVTaskListTableData);
            GetTP_TaskListEntitysInput input = new GetTP_TaskListEntitysInput();
            var arvs = await TaskListService.GetPaged(input);

            foreach (var i in arvs.Items)
            {
                ARVTaskListModel.ARVTaskListTableData obj = (ARVTaskListModel.ARVTaskListTableData)type.Assembly.CreateInstance(type.ToString());
                obj.arvid = i.c_CarrierID;
                //obj.arvname = i.c_ARVDesc;
                //obj.c_AGVType = i.c_ARVType.ToString();
                //if (i.c_WorkState >= 1 && i.c_WorkState <= 6) { i.c_WorkState = 1; }
                //obj.arvstatus = i.c_WorkState.ToString();
                //obj.order = i.c_TaskId;
                //obj.actiontype = i.c_TaskType == 1 ? "Pick" : "Put";
                //obj.source = "TT-M4-001 24";//查订单
                //obj.target = "DS001 A";
                //obj.agverror = i.c_ErrorCode;
                //obj.roboterror = i.c_RobotErrorCode;
                //obj.battery = i.c_BatteryVoltage;
                resultList.Add(obj);
            }
            ARVTaskListModel.ARVTaskListFormReturn AlarmFormReturn = new ARVTaskListModel.ARVTaskListFormReturn();
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
