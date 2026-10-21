using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_WatchLog.Migrations
{
    /// <inheritdoc />
    public partial class SafeAddRecordId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableFavoritess1131601_TableMedias1131601_MediaId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableFavoritess1131601_TableUserss1131601_UserId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableFavoritess1131601_TableWatchRecordss1131601_WatchRecordRecordId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropIndex(
                name: "IX_TableFavoritess1131601_UserId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropIndex(
                name: "IX_TableFavoritess1131601_WatchRecordRecordId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropColumn(
                name: "WatchRecordRecordId",
                table: "TableFavoritess1131601");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TableFavoritess1131601",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "TableFavoritess1131601",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RecordId",
                table: "TableFavoritess1131601",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TableFavoritess1131601_RecordId",
                table: "TableFavoritess1131601",
                column: "RecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableFavoritess1131601_TableMedias1131601_MediaId",
                table: "TableFavoritess1131601",
                column: "MediaId",
                principalTable: "TableMedias1131601",
                principalColumn: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableFavoritess1131601_TableWatchRecordss1131601_RecordId",
                table: "TableFavoritess1131601",
                column: "RecordId",
                principalTable: "TableWatchRecordss1131601",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableFavoritess1131601_TableMedias1131601_MediaId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableFavoritess1131601_TableWatchRecordss1131601_RecordId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropIndex(
                name: "IX_TableFavoritess1131601_RecordId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropColumn(
                name: "RecordId",
                table: "TableFavoritess1131601");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TableFavoritess1131601",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "TableFavoritess1131601",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WatchRecordRecordId",
                table: "TableFavoritess1131601",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TableFavoritess1131601_UserId",
                table: "TableFavoritess1131601",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TableFavoritess1131601_WatchRecordRecordId",
                table: "TableFavoritess1131601",
                column: "WatchRecordRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableFavoritess1131601_TableMedias1131601_MediaId",
                table: "TableFavoritess1131601",
                column: "MediaId",
                principalTable: "TableMedias1131601",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableFavoritess1131601_TableUserss1131601_UserId",
                table: "TableFavoritess1131601",
                column: "UserId",
                principalTable: "TableUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableFavoritess1131601_TableWatchRecordss1131601_WatchRecordRecordId",
                table: "TableFavoritess1131601",
                column: "WatchRecordRecordId",
                principalTable: "TableWatchRecordss1131601",
                principalColumn: "RecordId");
        }
    }
}
