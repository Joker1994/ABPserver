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
    public class ARVAlarmLogController : MCSControllerBase
    {
        protected readonly ITB_AlarmLogEntityAppService AlarmInfoService;

        public ARVAlarmLogController(ITB_AlarmLogEntityAppService alarmInfoService, PermissionChecker permissionChecker)
        {
            AlarmInfoService = alarmInfoService;
        }

        [HttpPost]
        public async Task<ARVAlarmInfoModel.ARVAlarmFormReturn> PostAlarmInfoDataAsync([FromBody] ARVAlarmInfoModel.ARVAlarmQueryData obj1)
        {
            List<ARVAlarmInfoModel.ARVAlarmTableData> resultList = new List<ARVAlarmInfoModel.ARVAlarmTableData>();
            Type type = typeof(ARVAlarmInfoModel.ARVAlarmTableData);
            GetTB_AlarmLogEntitysInput input = new GetTB_AlarmLogEntitysInput();
            var arvs = await AlarmInfoService.GetPaged(input);

            foreach (var i in arvs.Items)
            {
                ARVAlarmInfoModel.ARVAlarmTableData obj = (ARVAlarmInfoModel.ARVAlarmTableData)type.Assembly.CreateInstance(type.ToString());
                obj.arvid = i.C_DeviceID.ToString();
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
            ARVAlarmInfoModel.ARVAlarmFormReturn AlarmFormReturn = new ARVAlarmInfoModel.ARVAlarmFormReturn();
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
