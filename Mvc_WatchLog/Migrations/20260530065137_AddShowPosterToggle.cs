using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_WatchLog.Migrations
{
    /// <inheritdoc />
    public partial class AddShowPosterToggle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ShowPoster",
                table: "WatchRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowPoster",
                table: "WatchRecords");
        }
    }
}
