using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siasun.MCS.Migrations
{
    public partial class TB_AlarmLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "TP_ARVStatus");

            migrationBuilder.CreateTable(
                name: "TB_AlarmLog",
                columns: table => new
                {
                    C_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    C_LogTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C_ErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_DeviceDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Measure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_RestoreTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C_Sw01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_AlarmLog", x => x.C_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "TB_AlarmLog");

            migrationBuilder.CreateTable(
                name: "TP_ARVStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    c_ARVDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ARVId = table.Column<int>(type: "int", nullable: false),
                    c_ARVType = table.Column<int>(type: "int", nullable: false),
                    c_AvoidAgvId = table.Column<int>(type: "int", nullable: false),
                    c_BatteryState = table.Column<int>(type: "int", nullable: false),
                    c_BatteryVoltage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_BatteryVolume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: false),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: false),
                    c_EndPoint = table.Column<int>(type: "int", nullable: false),
                    c_ErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_RobotErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_RobotState = table.Column<int>(type: "int", nullable: false),
                    c_StartPoint = table.Column<int>(type: "int", nullable: false),
                    c_Sw01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TargetLoc = table.Column<int>(type: "int", nullable: false),
                    c_TaskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskStepNo = table.Column<int>(type: "int", nullable: false),
                    c_TaskType = table.Column<int>(type: "int", nullable: false),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_WorkCode = table.Column<int>(type: "int", nullable: false),
                    c_WorkState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TP_ARVStatus", x => x.Id);
                });
        }
    }
}
