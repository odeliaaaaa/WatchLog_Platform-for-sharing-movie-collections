using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_WatchLog.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAspNetPrefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableAspNetRoleClaimss1131601_TableAspNetRoless1131601_RoleId",
                table: "TableAspNetRoleClaimss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableAspNetUserClaimss1131601_TableAspNetUserss1131601_UserId",
                table: "TableAspNetUserClaimss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableAspNetUserLoginss1131601_TableAspNetUserss1131601_UserId",
                table: "TableAspNetUserLoginss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableAspNetUserRoless1131601_TableAspNetRoless1131601_RoleId",
                table: "TableAspNetUserRoless1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableAspNetUserRoless1131601_TableAspNetUserss1131601_UserId",
                table: "TableAspNetUserRoless1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableAspNetUserTokenss1131601_TableAspNetUserss1131601_UserId",
                table: "TableAspNetUserTokenss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableFavoritess1131601_TableAspNetUserss1131601_UserId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableWatchRecordss1131601_TableAspNetUserss1131601_UserId",
                table: "TableWatchRecordss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableAspNetUserTokenss1131601",
                table: "TableAspNetUserTokenss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableAspNetUserss1131601",
                table: "TableAspNetUserss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableAspNetUserRoless1131601",
                table: "TableAspNetUserRoless1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableAspNetUserLoginss1131601",
                table: "TableAspNetUserLoginss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableAspNetUserClaimss1131601",
                table: "TableAspNetUserClaimss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableAspNetRoless1131601",
                table: "TableAspNetRoless1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableAspNetRoleClaimss1131601",
                table: "TableAspNetRoleClaimss1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserTokenss1131601",
                newName: "TableUserTokenss1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserss1131601",
                newName: "TableUserss1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserRoless1131601",
                newName: "TableUserRoless1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserLoginss1131601",
                newName: "TableUserLoginss1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserClaimss1131601",
                newName: "TableUserClaimss1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetRoless1131601",
                newName: "TableRoless1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetRoleClaimss1131601",
                newName: "TableRoleClaimss1131601");

            migrationBuilder.RenameIndex(
                name: "IX_TableAspNetUserRoless1131601_RoleId",
                table: "TableUserRoless1131601",
                newName: "IX_TableUserRoless1131601_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TableAspNetUserLoginss1131601_UserId",
                table: "TableUserLoginss1131601",
                newName: "IX_TableUserLoginss1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TableAspNetUserClaimss1131601_UserId",
                table: "TableUserClaimss1131601",
                newName: "IX_TableUserClaimss1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TableAspNetRoleClaimss1131601_RoleId",
                table: "TableRoleClaimss1131601",
                newName: "IX_TableRoleClaimss1131601_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableUserTokenss1131601",
                table: "TableUserTokenss1131601",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableUserss1131601",
                table: "TableUserss1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableUserRoless1131601",
                table: "TableUserRoless1131601",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableUserLoginss1131601",
                table: "TableUserLoginss1131601",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableUserClaimss1131601",
                table: "TableUserClaimss1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableRoless1131601",
                table: "TableRoless1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableRoleClaimss1131601",
                table: "TableRoleClaimss1131601",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TableFavoritess1131601_TableUserss1131601_UserId",
                table: "TableFavoritess1131601",
                column: "UserId",
                principalTable: "TableUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableRoleClaimss1131601_TableRoless1131601_RoleId",
                table: "TableRoleClaimss1131601",
                column: "RoleId",
                principalTable: "TableRoless1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableUserClaimss1131601_TableUserss1131601_UserId",
                table: "TableUserClaimss1131601",
                column: "UserId",
                principalTable: "TableUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableUserLoginss1131601_TableUserss1131601_UserId",
                table: "TableUserLoginss1131601",
                column: "UserId",
                principalTable: "TableUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableUserRoless1131601_TableRoless1131601_RoleId",
                table: "TableUserRoless1131601",
                column: "RoleId",
                principalTable: "TableRoless1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableUserRoless1131601_TableUserss1131601_UserId",
                table: "TableUserRoless1131601",
                column: "UserId",
                principalTable: "TableUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableUserTokenss1131601_TableUserss1131601_UserId",
                table: "TableUserTokenss1131601",
                column: "UserId",
                principalTable: "TableUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableWatchRecordss1131601_TableUserss1131601_UserId",
                table: "TableWatchRecordss1131601",
                column: "UserId",
                principalTable: "TableUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableFavoritess1131601_TableUserss1131601_UserId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableRoleClaimss1131601_TableRoless1131601_RoleId",
                table: "TableRoleClaimss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableUserClaimss1131601_TableUserss1131601_UserId",
                table: "TableUserClaimss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableUserLoginss1131601_TableUserss1131601_UserId",
                table: "TableUserLoginss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableUserRoless1131601_TableRoless1131601_RoleId",
                table: "TableUserRoless1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableUserRoless1131601_TableUserss1131601_UserId",
                table: "TableUserRoless1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableUserTokenss1131601_TableUserss1131601_UserId",
                table: "TableUserTokenss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableWatchRecordss1131601_TableUserss1131601_UserId",
                table: "TableWatchRecordss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableUserTokenss1131601",
                table: "TableUserTokenss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableUserss1131601",
                table: "TableUserss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableUserRoless1131601",
                table: "TableUserRoless1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableUserLoginss1131601",
                table: "TableUserLoginss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableUserClaimss1131601",
                table: "TableUserClaimss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableRoless1131601",
                table: "TableRoless1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableRoleClaimss1131601",
                table: "TableRoleClaimss1131601");

            migrationBuilder.RenameTable(
                name: "TableUserTokenss1131601",
                newName: "TableAspNetUserTokenss1131601");

            migrationBuilder.RenameTable(
                name: "TableUserss1131601",
                newName: "TableAspNetUserss1131601");

            migrationBuilder.RenameTable(
                name: "TableUserRoless1131601",
                newName: "TableAspNetUserRoless1131601");

            migrationBuilder.RenameTable(
                name: "TableUserLoginss1131601",
                newName: "TableAspNetUserLoginss1131601");

            migrationBuilder.RenameTable(
                name: "TableUserClaimss1131601",
                newName: "TableAspNetUserClaimss1131601");

            migrationBuilder.RenameTable(
                name: "TableRoless1131601",
                newName: "TableAspNetRoless1131601");

            migrationBuilder.RenameTable(
                name: "TableRoleClaimss1131601",
                newName: "TableAspNetRoleClaimss1131601");

            migrationBuilder.RenameIndex(
                name: "IX_TableUserRoless1131601_RoleId",
                table: "TableAspNetUserRoless1131601",
                newName: "IX_TableAspNetUserRoless1131601_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TableUserLoginss1131601_UserId",
                table: "TableAspNetUserLoginss1131601",
                newName: "IX_TableAspNetUserLoginss1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TableUserClaimss1131601_UserId",
                table: "TableAspNetUserClaimss1131601",
                newName: "IX_TableAspNetUserClaimss1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TableRoleClaimss1131601_RoleId",
                table: "TableAspNetRoleClaimss1131601",
                newName: "IX_TableAspNetRoleClaimss1131601_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableAspNetUserTokenss1131601",
                table: "TableAspNetUserTokenss1131601",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableAspNetUserss1131601",
                table: "TableAspNetUserss1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableAspNetUserRoless1131601",
                table: "TableAspNetUserRoless1131601",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableAspNetUserLoginss1131601",
                table: "TableAspNetUserLoginss1131601",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableAspNetUserClaimss1131601",
                table: "TableAspNetUserClaimss1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableAspNetRoless1131601",
                table: "TableAspNetRoless1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableAspNetRoleClaimss1131601",
                table: "TableAspNetRoleClaimss1131601",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TableAspNetRoleClaimss1131601_TableAspNetRoless1131601_RoleId",
                table: "TableAspNetRoleClaimss1131601",
                column: "RoleId",
                principalTable: "TableAspNetRoless1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableAspNetUserClaimss1131601_TableAspNetUserss1131601_UserId",
                table: "TableAspNetUserClaimss1131601",
                column: "UserId",
                principalTable: "TableAspNetUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableAspNetUserLoginss1131601_TableAspNetUserss1131601_UserId",
                table: "TableAspNetUserLoginss1131601",
                column: "UserId",
                principalTable: "TableAspNetUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableAspNetUserRoless1131601_TableAspNetRoless1131601_RoleId",
                table: "TableAspNetUserRoless1131601",
                column: "RoleId",
                principalTable: "TableAspNetRoless1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableAspNetUserRoless1131601_TableAspNetUserss1131601_UserId",
                table: "TableAspNetUserRoless1131601",
                column: "UserId",
                principalTable: "TableAspNetUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableAspNetUserTokenss1131601_TableAspNetUserss1131601_UserId",
                table: "TableAspNetUserTokenss1131601",
                column: "UserId",
                principalTable: "TableAspNetUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableFavoritess1131601_TableAspNetUserss1131601_UserId",
                table: "TableFavoritess1131601",
                column: "UserId",
                principalTable: "TableAspNetUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableWatchRecordss1131601_TableAspNetUserss1131601_UserId",
                table: "TableWatchRecordss1131601",
                column: "UserId",
                principalTable: "TableAspNetUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
