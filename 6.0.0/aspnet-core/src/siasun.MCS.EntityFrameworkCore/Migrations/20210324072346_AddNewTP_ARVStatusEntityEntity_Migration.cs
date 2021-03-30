using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siasun.MCS.Migrations
{
    public partial class AddNewTP_ARVStatusEntityEntity_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TP_ARVStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ARVId = table.Column<int>(type: "int", nullable: true),
                    c_ARVDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_ARVType = table.Column<int>(type: "int", nullable: true),
                    c_TaskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_TaskType = table.Column<int>(type: "int", nullable: true),
                    c_TaskStepNo = table.Column<int>(type: "int", nullable: true),
                    c_OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_StartPoint = table.Column<int>(type: "int", nullable: true),
                    c_EndPoint = table.Column<int>(type: "int", nullable: true),
                    c_TargetLoc = table.Column<int>(type: "int", nullable: true),
                    c_WorkState = table.Column<int>(type: "int", nullable: true),
                    c_ErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_BatteryState = table.Column<int>(type: "int", nullable: true),
                    c_RobotState = table.Column<int>(type: "int", nullable: true),
                    c_RobotErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_WorkCode = table.Column<int>(type: "int", nullable: true),
                    c_BatteryVolume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_BatteryVoltage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_AvoidAgvId = table.Column<int>(type: "int", nullable: true),
                    c_DeleteMark = table.Column<int>(type: "int", nullable: true),
                    c_EnabledMark = table.Column<int>(type: "int", nullable: true),
                    c_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_Sw05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_Sw04 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TP_ARVStatus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TP_ARVStatus");
        }
    }
}
