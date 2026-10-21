using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_WatchLog.Migrations
{
    /// <inheritdoc />
    public partial class AddTablePrefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Media_MediaId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchRecords_AspNetUsers_UserId",
                table: "WatchRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchRecords_Media_MediaId",
                table: "WatchRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchRecords",
                table: "WatchRecords");

            migrationBuilder.DropIndex(
                name: "IX_WatchRecords_UserId_MediaId",
                table: "WatchRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Media",
                table: "Media");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "WatchRecords",
                newName: "Table_WatchRecords_s1131601");

            migrationBuilder.RenameTable(
                name: "Media",
                newName: "Table_Media_s1131601");

            migrationBuilder.RenameTable(
                name: "Favorites",
                newName: "Table_Favorites_s1131601");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "Table_AspNetUserTokens_s1131601");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Table_AspNetUsers_s1131601");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "Table_AspNetUserRoles_s1131601");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "Table_AspNetUserLogins_s1131601");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "Table_AspNetUserClaims_s1131601");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Table_AspNetRoles_s1131601");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "Table_AspNetRoleClaims_s1131601");

            migrationBuilder.RenameIndex(
                name: "IX_WatchRecords_MediaId",
                table: "Table_WatchRecords_s1131601",
                newName: "IX_Table_WatchRecords_s1131601_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_UserId",
                table: "Table_Favorites_s1131601",
                newName: "IX_Table_Favorites_s1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_MediaId",
                table: "Table_Favorites_s1131601",
                newName: "IX_Table_Favorites_s1131601_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "Table_AspNetUserRoles_s1131601",
                newName: "IX_Table_AspNetUserRoles_s1131601_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "Table_AspNetUserLogins_s1131601",
                newName: "IX_Table_AspNetUserLogins_s1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "Table_AspNetUserClaims_s1131601",
                newName: "IX_Table_AspNetUserClaims_s1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "Table_AspNetRoleClaims_s1131601",
                newName: "IX_Table_AspNetRoleClaims_s1131601_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_WatchRecords_s1131601",
                table: "Table_WatchRecords_s1131601",
                column: "RecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_Media_s1131601",
                table: "Table_Media_s1131601",
                column: "MediaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_Favorites_s1131601",
                table: "Table_Favorites_s1131601",
                column: "FavoriteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_AspNetUserTokens_s1131601",
                table: "Table_AspNetUserTokens_s1131601",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_AspNetUsers_s1131601",
                table: "Table_AspNetUsers_s1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_AspNetUserRoles_s1131601",
                table: "Table_AspNetUserRoles_s1131601",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_AspNetUserLogins_s1131601",
                table: "Table_AspNetUserLogins_s1131601",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_AspNetUserClaims_s1131601",
                table: "Table_AspNetUserClaims_s1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_AspNetRoles_s1131601",
                table: "Table_AspNetRoles_s1131601",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_AspNetRoleClaims_s1131601",
                table: "Table_AspNetRoleClaims_s1131601",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Table_WatchRecords_s1131601_UserId",
                table: "Table_WatchRecords_s1131601",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Table_AspNetRoleClaims_s1131601_Table_AspNetRoles_s1131601_RoleId",
                table: "Table_AspNetRoleClaims_s1131601",
                column: "RoleId",
                principalTable: "Table_AspNetRoles_s1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_AspNetUserClaims_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_AspNetUserClaims_s1131601",
                column: "UserId",
                principalTable: "Table_AspNetUsers_s1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_AspNetUserLogins_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_AspNetUserLogins_s1131601",
                column: "UserId",
                principalTable: "Table_AspNetUsers_s1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_AspNetUserRoles_s1131601_Table_AspNetRoles_s1131601_RoleId",
                table: "Table_AspNetUserRoles_s1131601",
                column: "RoleId",
                principalTable: "Table_AspNetRoles_s1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_AspNetUserRoles_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_AspNetUserRoles_s1131601",
                column: "UserId",
                principalTable: "Table_AspNetUsers_s1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_AspNetUserTokens_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_AspNetUserTokens_s1131601",
                column: "UserId",
                principalTable: "Table_AspNetUsers_s1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Favorites_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_Favorites_s1131601",
                column: "UserId",
                principalTable: "Table_AspNetUsers_s1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Favorites_s1131601_Table_Media_s1131601_MediaId",
                table: "Table_Favorites_s1131601",
                column: "MediaId",
                principalTable: "Table_Media_s1131601",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_WatchRecords_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_WatchRecords_s1131601",
                column: "UserId",
                principalTable: "Table_AspNetUsers_s1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_WatchRecords_s1131601_Table_Media_s1131601_MediaId",
                table: "Table_WatchRecords_s1131601",
                column: "MediaId",
                principalTable: "Table_Media_s1131601",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_AspNetRoleClaims_s1131601_Table_AspNetRoles_s1131601_RoleId",
                table: "Table_AspNetRoleClaims_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_AspNetUserClaims_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_AspNetUserClaims_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_AspNetUserLogins_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_AspNetUserLogins_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_AspNetUserRoles_s1131601_Table_AspNetRoles_s1131601_RoleId",
                table: "Table_AspNetUserRoles_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_AspNetUserRoles_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_AspNetUserRoles_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_AspNetUserTokens_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_AspNetUserTokens_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_Favorites_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_Favorites_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_Favorites_s1131601_Table_Media_s1131601_MediaId",
                table: "Table_Favorites_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_WatchRecords_s1131601_Table_AspNetUsers_s1131601_UserId",
                table: "Table_WatchRecords_s1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_WatchRecords_s1131601_Table_Media_s1131601_MediaId",
                table: "Table_WatchRecords_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_WatchRecords_s1131601",
                table: "Table_WatchRecords_s1131601");

            migrationBuilder.DropIndex(
                name: "IX_Table_WatchRecords_s1131601_UserId",
                table: "Table_WatchRecords_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_Media_s1131601",
                table: "Table_Media_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_Favorites_s1131601",
                table: "Table_Favorites_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_AspNetUserTokens_s1131601",
                table: "Table_AspNetUserTokens_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_AspNetUsers_s1131601",
                table: "Table_AspNetUsers_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_AspNetUserRoles_s1131601",
                table: "Table_AspNetUserRoles_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_AspNetUserLogins_s1131601",
                table: "Table_AspNetUserLogins_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_AspNetUserClaims_s1131601",
                table: "Table_AspNetUserClaims_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_AspNetRoles_s1131601",
                table: "Table_AspNetRoles_s1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_AspNetRoleClaims_s1131601",
                table: "Table_AspNetRoleClaims_s1131601");

            migrationBuilder.RenameTable(
                name: "Table_WatchRecords_s1131601",
                newName: "WatchRecords");

            migrationBuilder.RenameTable(
                name: "Table_Media_s1131601",
                newName: "Media");

            migrationBuilder.RenameTable(
                name: "Table_Favorites_s1131601",
                newName: "Favorites");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUserTokens_s1131601",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUsers_s1131601",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUserRoles_s1131601",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUserLogins_s1131601",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUserClaims_s1131601",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Table_AspNetRoles_s1131601",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "Table_AspNetRoleClaims_s1131601",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_Table_WatchRecords_s1131601_MediaId",
                table: "WatchRecords",
                newName: "IX_WatchRecords_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_Favorites_s1131601_UserId",
                table: "Favorites",
                newName: "IX_Favorites_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_Favorites_s1131601_MediaId",
                table: "Favorites",
                newName: "IX_Favorites_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_AspNetUserRoles_s1131601_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_AspNetUserLogins_s1131601_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_AspNetUserClaims_s1131601_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_AspNetRoleClaims_s1131601_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchRecords",
                table: "WatchRecords",
                column: "RecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Media",
                table: "Media",
                column: "MediaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites",
                column: "FavoriteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_WatchRecords_UserId_MediaId",
                table: "WatchRecords",
                columns: new[] { "UserId", "MediaId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Media_MediaId",
                table: "Favorites",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchRecords_AspNetUsers_UserId",
                table: "WatchRecords",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchRecords_Media_MediaId",
                table: "WatchRecords",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
