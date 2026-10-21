using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_WatchLog.Migrations
{
    /// <inheritdoc />
    public partial class FinalTableNamingNoUnderscore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "TableWatchRecordss1131601");

            migrationBuilder.RenameTable(
                name: "Table_Media_s1131601",
                newName: "TableMedias1131601");

            migrationBuilder.RenameTable(
                name: "Table_Favorites_s1131601",
                newName: "TableFavoritess1131601");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUserTokens_s1131601",
                newName: "TableAspNetUserTokenss1131601");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUsers_s1131601",
                newName: "TableAspNetUserss1131601");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUserRoles_s1131601",
                newName: "TableAspNetUserRoless1131601");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUserLogins_s1131601",
                newName: "TableAspNetUserLoginss1131601");

            migrationBuilder.RenameTable(
                name: "Table_AspNetUserClaims_s1131601",
                newName: "TableAspNetUserClaimss1131601");

            migrationBuilder.RenameTable(
                name: "Table_AspNetRoles_s1131601",
                newName: "TableAspNetRoless1131601");

            migrationBuilder.RenameTable(
                name: "Table_AspNetRoleClaims_s1131601",
                newName: "TableAspNetRoleClaimss1131601");

            migrationBuilder.RenameIndex(
                name: "IX_Table_WatchRecords_s1131601_UserId",
                table: "TableWatchRecordss1131601",
                newName: "IX_TableWatchRecordss1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_WatchRecords_s1131601_MediaId",
                table: "TableWatchRecordss1131601",
                newName: "IX_TableWatchRecordss1131601_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_Favorites_s1131601_UserId",
                table: "TableFavoritess1131601",
                newName: "IX_TableFavoritess1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_Favorites_s1131601_MediaId",
                table: "TableFavoritess1131601",
                newName: "IX_TableFavoritess1131601_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_AspNetUserRoles_s1131601_RoleId",
                table: "TableAspNetUserRoless1131601",
                newName: "IX_TableAspNetUserRoless1131601_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_AspNetUserLogins_s1131601_UserId",
                table: "TableAspNetUserLoginss1131601",
                newName: "IX_TableAspNetUserLoginss1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_AspNetUserClaims_s1131601_UserId",
                table: "TableAspNetUserClaimss1131601",
                newName: "IX_TableAspNetUserClaimss1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Table_AspNetRoleClaims_s1131601_RoleId",
                table: "TableAspNetRoleClaimss1131601",
                newName: "IX_TableAspNetRoleClaimss1131601_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableWatchRecordss1131601",
                table: "TableWatchRecordss1131601",
                column: "RecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableMedias1131601",
                table: "TableMedias1131601",
                column: "MediaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableFavoritess1131601",
                table: "TableFavoritess1131601",
                column: "FavoriteId");

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
                name: "FK_TableFavoritess1131601_TableMedias1131601_MediaId",
                table: "TableFavoritess1131601",
                column: "MediaId",
                principalTable: "TableMedias1131601",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableWatchRecordss1131601_TableAspNetUserss1131601_UserId",
                table: "TableWatchRecordss1131601",
                column: "UserId",
                principalTable: "TableAspNetUserss1131601",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableWatchRecordss1131601_TableMedias1131601_MediaId",
                table: "TableWatchRecordss1131601",
                column: "MediaId",
                principalTable: "TableMedias1131601",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_TableFavoritess1131601_TableMedias1131601_MediaId",
                table: "TableFavoritess1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableWatchRecordss1131601_TableAspNetUserss1131601_UserId",
                table: "TableWatchRecordss1131601");

            migrationBuilder.DropForeignKey(
                name: "FK_TableWatchRecordss1131601_TableMedias1131601_MediaId",
                table: "TableWatchRecordss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableWatchRecordss1131601",
                table: "TableWatchRecordss1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableMedias1131601",
                table: "TableMedias1131601");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableFavoritess1131601",
                table: "TableFavoritess1131601");

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
                name: "TableWatchRecordss1131601",
                newName: "Table_WatchRecords_s1131601");

            migrationBuilder.RenameTable(
                name: "TableMedias1131601",
                newName: "Table_Media_s1131601");

            migrationBuilder.RenameTable(
                name: "TableFavoritess1131601",
                newName: "Table_Favorites_s1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserTokenss1131601",
                newName: "Table_AspNetUserTokens_s1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserss1131601",
                newName: "Table_AspNetUsers_s1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserRoless1131601",
                newName: "Table_AspNetUserRoles_s1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserLoginss1131601",
                newName: "Table_AspNetUserLogins_s1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetUserClaimss1131601",
                newName: "Table_AspNetUserClaims_s1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetRoless1131601",
                newName: "Table_AspNetRoles_s1131601");

            migrationBuilder.RenameTable(
                name: "TableAspNetRoleClaimss1131601",
                newName: "Table_AspNetRoleClaims_s1131601");

            migrationBuilder.RenameIndex(
                name: "IX_TableWatchRecordss1131601_UserId",
                table: "Table_WatchRecords_s1131601",
                newName: "IX_Table_WatchRecords_s1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TableWatchRecordss1131601_MediaId",
                table: "Table_WatchRecords_s1131601",
                newName: "IX_Table_WatchRecords_s1131601_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_TableFavoritess1131601_UserId",
                table: "Table_Favorites_s1131601",
                newName: "IX_Table_Favorites_s1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TableFavoritess1131601_MediaId",
                table: "Table_Favorites_s1131601",
                newName: "IX_Table_Favorites_s1131601_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_TableAspNetUserRoless1131601_RoleId",
                table: "Table_AspNetUserRoles_s1131601",
                newName: "IX_Table_AspNetUserRoles_s1131601_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TableAspNetUserLoginss1131601_UserId",
                table: "Table_AspNetUserLogins_s1131601",
                newName: "IX_Table_AspNetUserLogins_s1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TableAspNetUserClaimss1131601_UserId",
                table: "Table_AspNetUserClaims_s1131601",
                newName: "IX_Table_AspNetUserClaims_s1131601_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TableAspNetRoleClaimss1131601_RoleId",
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
    }
}
