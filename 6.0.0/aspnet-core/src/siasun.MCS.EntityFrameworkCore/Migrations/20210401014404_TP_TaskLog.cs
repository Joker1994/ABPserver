using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siasun.MCS.Migrations
{
    public partial class TP_TaskLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "TP_TaskList");

            migrationBuilder.CreateTable(
                name: "TP_TaskLog",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskCount = table.Column<int>(type: "int", nullable: false),
                    c_TaskNo = table.Column<int>(type: "int", nullable: false),
                    c_AGVId = table.Column<int>(type: "int", nullable: false),
                    c_AGVType = table.Column<int>(type: "int", nullable: false),
                    c_NowMapLoc = table.Column<int>(type: "int", nullable: false),
                    c_WorkMapLoc = table.Column<int>(type: "int", nullable: false),
                    c_AGVTaskType = table.Column<int>(type: "int", nullable: false),
                    c_RobotTaskType = table.Column<int>(type: "int", nullable: false),
                    c_WorkLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_WorkPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskCode = table.Column<int>(type: "int", nullable: false),
                    c_TaskCode2 = table.Column<int>(type: "int", nullable: false),
                    c_CarrierID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Priority = table.Column<int>(type: "int", nullable: false),
                    d_DueTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_FloorNo = table.Column<int>(type: "int", nullable: false),
                    c_AreaIndex = table.Column<int>(type: "int", nullable: false),
                    c_OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderType = table.Column<int>(type: "int", nullable: false),
                    c_GroupMark = table.Column<int>(type: "int", nullable: false),
                    c_GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_GroupType = table.Column<int>(type: "int", nullable: false),
                    c_GroupOrder = table.Column<int>(type: "int", nullable: false),
                    c_ARSTaskmark = table.Column<int>(type: "int", nullable: false),
                    c_HandleFlag = table.Column<int>(type: "int", nullable: false),
                    c_ManualFlag = table.Column<int>(type: "int", nullable: false),
                    d_CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_SendTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_ActionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_DoneTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_UnlockTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_AGVTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    d_RobotTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ASDConfirmFlag = table.Column<int>(type: "int", nullable: false),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: false),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: false),
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
            //migrationBuilder.DropTable(
            //    name: "TP_TaskLog");

            migrationBuilder.CreateTable(
                name: "TP_TaskList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    c_AGVId = table.Column<int>(type: "int", nullable: false),
                    c_AGVTaskType = table.Column<int>(type: "int", nullable: false),
                    c_AGVType = table.Column<int>(type: "int", nullable: false),
                    c_ARSTaskmark = table.Column<int>(type: "int", nullable: false),
                    c_AreaIndex = table.Column<int>(type: "int", nullable: false),
                    c_CarrierID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ConfirmFlag = table.Column<int>(type: "int", nullable: false),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: false),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: false),
                    c_GroupCount = table.Column<int>(type: "int", nullable: false),
                    c_GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_GroupMark = table.Column<int>(type: "int", nullable: false),
                    c_GroupType = table.Column<int>(type: "int", nullable: false),
                    c_HandleFlag = table.Column<int>(type: "int", nullable: false),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_IsArvBuff = table.Column<int>(type: "int", nullable: false),
                    c_LastTask = table.Column<int>(type: "int", nullable: false),
                    c_ManualFlag = table.Column<int>(type: "int", nullable: false),
                    c_NextTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderSource = table.Column<int>(type: "int", nullable: false),
                    c_OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderTypeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Priority = table.Column<int>(type: "int", nullable: false),
                    c_RFIDCheckResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_RobotTaskType = table.Column<int>(type: "int", nullable: false),
                    c_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskCode = table.Column<int>(type: "int", nullable: false),
                    c_TaskCode2 = table.Column<int>(type: "int", nullable: false),
                    c_TaskCount = table.Column<int>(type: "int", nullable: false),
                    c_TaskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskNo = table.Column<int>(type: "int", nullable: false),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_WorkLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_WorkLocType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_WorkMapLoc = table.Column<int>(type: "int", nullable: false),
                    c_WorkPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    d_AGVTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    d_ActionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_DoneTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_DueTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    d_EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_RobotTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    d_SendTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_UnlockTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TP_TaskList", x => x.Id);
                });
        }
    }
}
