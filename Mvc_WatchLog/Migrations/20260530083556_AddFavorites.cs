using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_WatchLog.Migrations
{
    /// <inheritdoc />
    public partial class AddFavorites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WatchRecordRecordId",
                table: "TableFavoritess1131601",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TableFavoritess1131601_WatchRecordRecordId",
                table: "TableFavoritess1131601",
                column: "WatchRecordRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableFavoritess1131601_TableWatchRecordss1131601_WatchRecordRecordId",
                table: "TableFavoritess1131601",
                column: "WatchRecordRecordId",
                principalTable: "TableWatchRecordss1131601",
                principalColumn: "RecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableFavoritess1131601_TableWatchRecordss1131601_WatchRecordRecordId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropIndex(
                name: "IX_TableFavoritess1131601_WatchRecordRecordId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropColumn(
                name: "WatchRecordRecordId",
                table: "TableFavoritess1131601");
        }
    }
}
