using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siasun.MCS.Migrations
{
    public partial class TP_OrderLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "TP_OrderList");

            migrationBuilder.CreateTable(
                name: "TP_OrderLog",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderType = table.Column<int>(type: "int", nullable: false),
                    c_OrderSource = table.Column<int>(type: "int", nullable: false),
                    c_GroupMark = table.Column<int>(type: "int", nullable: false),
                    c_GroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_GroupType = table.Column<int>(type: "int", nullable: false),
                    c_GroupOrder = table.Column<int>(type: "int", nullable: false),
                    c_Priority = table.Column<int>(type: "int", nullable: false),
                    c_SourceLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_SourcePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_PartNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CarrierID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_LotQTY = table.Column<int>(type: "int", nullable: false),
                    c_LotInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CanStart = table.Column<bool>(type: "bit", nullable: false),
                    c_AreaLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_DueTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_HandleFlag = table.Column<int>(type: "int", nullable: false),
                    c_ManualFlag = table.Column<int>(type: "int", nullable: false),
                    n_AGVType = table.Column<int>(type: "int", nullable: false),
                    n_AGVID = table.Column<int>(type: "int", nullable: false),
                    d_CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_PredictTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_AnalyzeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: false),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: false),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_TaskCount = table.Column<int>(type: "int", nullable: false),
                    c_SucceedNum = table.Column<int>(type: "int", nullable: false),
                    c_FailedNum = table.Column<int>(type: "int", nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "TP_OrderLog");

            migrationBuilder.CreateTable(
                name: "TP_OrderList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    C_SW02 = table.Column<double>(type: "float", nullable: false),
                    C_SW03 = table.Column<double>(type: "float", nullable: false),
                    c_CanStart = table.Column<bool>(type: "bit", nullable: false),
                    c_CarrierID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CarrierProcessingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CarrierStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_CarrierType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: false),
                    c_Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_DueTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: false),
                    c_GroupCount = table.Column<int>(type: "int", nullable: false),
                    c_GroupOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_GroupSequence = table.Column<int>(type: "int", nullable: false),
                    c_GroupType = table.Column<int>(type: "int", nullable: false),
                    c_HandleFlag = table.Column<int>(type: "int", nullable: false),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_LocationUpdateDateTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_LotInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ManualFlag = table.Column<int>(type: "int", nullable: false),
                    c_OrderID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderSource = table.Column<int>(type: "int", nullable: false),
                    c_OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderTypeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Priority = table.Column<int>(type: "int", nullable: false),
                    c_ProcessPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ProcessStep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_SourceLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_SourceLocType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_SourcePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetLocType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskCount = table.Column<int>(type: "int", nullable: false),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_AnalyzeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_PredictTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    d_StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    n_AGVID = table.Column<int>(type: "int", nullable: false),
                    n_AGVType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TP_OrderList", x => x.Id);
                });
        }
    }
}
