using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_WatchLog.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPublicField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 🔪 只保留新增 IsPublic 欄位的指令
            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "WatchRecords",
                type: "bit",
                nullable: false,
                defaultValue: true); // 預設值我幫妳改成 true (預設公開)
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // 🔪 復原時，也只移除 IsPublic 欄位
            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "WatchRecords");
        }
    }
}