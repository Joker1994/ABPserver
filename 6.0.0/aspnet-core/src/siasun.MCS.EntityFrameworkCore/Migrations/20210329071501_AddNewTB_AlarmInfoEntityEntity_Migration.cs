using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siasun.MCS.Migrations
{
    public partial class AddNewTB_AlarmInfoEntityEntity_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_AlarmInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Measure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_State = table.Column<int>(type: "int", nullable: true),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: true),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: true),
                    C_UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    C_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    C_Sw01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_AlarmInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_AlarmLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_LogTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    C_ErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Measure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_RestoreTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    C_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    C_Sw01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_AlarmLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TP_OrderList",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderSource = table.Column<int>(type: "int", nullable: true),
                    c_GroupType = table.Column<int>(type: "int", nullable: true),
                    c_GroupOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_GroupCount = table.Column<int>(type: "int", nullable: true),
                    c_GroupSequence = table.Column<int>(type: "int", nullable: true),
                    c_Priority = table.Column<int>(type: "int", nullable: true),
                    c_SourceLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_SourcePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ProcessPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CarrierID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ProcessStep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_LotInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CanStart = table.Column<bool>(type: "bit", nullable: true),
                    c_CarrierType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_DueTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    c_HandleFlag = table.Column<int>(type: "int", nullable: true),
                    c_ManualFlag = table.Column<int>(type: "int", nullable: true),
                    n_AGVType = table.Column<int>(type: "int", nullable: true),
                    n_AGVID = table.Column<int>(type: "int", nullable: true),
                    d_CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_PredictTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_AnalyzeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: true),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: true),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_TaskCount = table.Column<int>(type: "int", nullable: true),
                    c_CarrierStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CarrierProcessingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_SourceLocType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetLocType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TP_OrderList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TP_OrderLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderType = table.Column<int>(type: "int", nullable: true),
                    c_OrderSource = table.Column<int>(type: "int", nullable: true),
                    c_GroupMark = table.Column<int>(type: "int", nullable: true),
                    c_GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_GroupType = table.Column<int>(type: "int", nullable: true),
                    c_GroupOrder = table.Column<int>(type: "int", nullable: true),
                    c_Priority = table.Column<int>(type: "int", nullable: true),
                    c_SourceLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_SourcePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_PartNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CarrierID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_LotQTY = table.Column<int>(type: "int", nullable: true),
                    c_LotInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CanStart = table.Column<bool>(type: "bit", nullable: true),
                    c_AreaLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_DueTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    c_HandleFlag = table.Column<int>(type: "int", nullable: true),
                    c_ManualFlag = table.Column<int>(type: "int", nullable: true),
                    n_AGVType = table.Column<int>(type: "int", nullable: true),
                    n_AGVID = table.Column<int>(type: "int", nullable: true),
                    d_CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_PredictTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_AnalyzeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: true),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: true),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_TaskCount = table.Column<int>(type: "int", nullable: true),
                    c_SucceedNum = table.Column<int>(type: "int", nullable: true),
                    c_FailedNum = table.Column<int>(type: "int", nullable: true),
                    c_Sw01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TP_OrderLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TP_TaskList",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskCount = table.Column<int>(type: "int", nullable: true),
                    c_TaskNo = table.Column<int>(type: "int", nullable: true),
                    c_AGVId = table.Column<int>(type: "int", nullable: true),
                    c_AGVType = table.Column<int>(type: "int", nullable: true),
                    c_WorkMapLoc = table.Column<int>(type: "int", nullable: true),
                    c_AGVTaskType = table.Column<int>(type: "int", nullable: true),
                    c_RobotTaskType = table.Column<int>(type: "int", nullable: true),
                    c_WorkLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_WorkLocType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_WorkPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskCode = table.Column<int>(type: "int", nullable: true),
                    c_TaskCode2 = table.Column<int>(type: "int", nullable: true),
                    c_CarrierID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Priority = table.Column<int>(type: "int", nullable: true),
                    d_DueTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_GroupCount = table.Column<int>(type: "int", nullable: true),
                    c_AreaIndex = table.Column<int>(type: "int", nullable: true),
                    c_OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderSource = table.Column<int>(type: "int", nullable: true),
                    c_GroupMark = table.Column<int>(type: "int", nullable: true),
                    c_GroupType = table.Column<int>(type: "int", nullable: true),
                    c_GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ARSTaskmark = table.Column<int>(type: "int", nullable: true),
                    c_NextTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_IsArvBuff = table.Column<int>(type: "int", nullable: true),
                    c_HandleFlag = table.Column<int>(type: "int", nullable: true),
                    c_ManualFlag = table.Column<int>(type: "int", nullable: true),
                    d_CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_SendTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_ActionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_DoneTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_UnlockTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_AGVTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    d_RobotTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ConfirmFlag = table.Column<int>(type: "int", nullable: true),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: true),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: true),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_RFIDCheckResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_LastTask = table.Column<int>(type: "int", nullable: true),
                    c_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TP_TaskList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TP_TaskLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskCount = table.Column<int>(type: "int", nullable: true),
                    c_TaskNo = table.Column<int>(type: "int", nullable: true),
                    c_AGVId = table.Column<int>(type: "int", nullable: true),
                    c_AGVType = table.Column<int>(type: "int", nullable: true),
                    c_NowMapLoc = table.Column<int>(type: "int", nullable: true),
                    c_WorkMapLoc = table.Column<int>(type: "int", nullable: true),
                    c_AGVTaskType = table.Column<int>(type: "int", nullable: true),
                    c_RobotTaskType = table.Column<int>(type: "int", nullable: true),
                    c_WorkLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_WorkPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskCode = table.Column<int>(type: "int", nullable: true),
                    c_TaskCode2 = table.Column<int>(type: "int", nullable: true),
                    c_CarrierID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Priority = table.Column<int>(type: "int", nullable: true),
                    d_DueTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_FloorNo = table.Column<int>(type: "int", nullable: true),
                    c_AreaIndex = table.Column<int>(type: "int", nullable: true),
                    c_OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderSource = table.Column<int>(type: "int", nullable: true),
                    c_GroupMark = table.Column<int>(type: "int", nullable: true),
                    c_GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_GroupType = table.Column<int>(type: "int", nullable: true),
                    c_GroupOrder = table.Column<int>(type: "int", nullable: true),
                    c_ARSTaskmark = table.Column<int>(type: "int", nullable: true),
                    c_HandleFlag = table.Column<int>(type: "int", nullable: true),
                    c_ManualFlag = table.Column<int>(type: "int", nullable: true),
                    d_CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_SendTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_ActionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_DoneTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_UnlockTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    d_AGVTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    d_RobotTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ConfirmFlag = table.Column<int>(type: "int", nullable: true),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: true),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: true),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_RFIDCheckResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TP_TaskLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_AlarmInfo");

            migrationBuilder.DropTable(
                name: "TB_AlarmLog");

            migrationBuilder.DropTable(
                name: "TP_OrderList");

            migrationBuilder.DropTable(
                name: "TP_OrderLog");

            migrationBuilder.DropTable(
                name: "TP_TaskList");

            migrationBuilder.DropTable(
                name: "TP_TaskLog");
        }
    }
}
