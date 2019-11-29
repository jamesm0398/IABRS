using Microsoft.EntityFrameworkCore.Migrations;

namespace IABRS.Migrations
{
    public partial class addIdent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookUsers_AspNetUsers",
                table: "bookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseUser_AspNetUsers",
                table: "CourseUser");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroup_AspNetUsers",
                table: "UserGroup");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "BookInCart",
                table: "bookUsers");

            migrationBuilder.DropColumn(
                name: "UserOwnsBook",
                table: "bookUsers");

            migrationBuilder.AddColumn<bool>(
                name: "InCart",
                table: "bookUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Owned",
                table: "bookUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_bookUsers_users_UserId",
                table: "bookUsers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUser_User",
                table: "CourseUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroup_User",
                table: "UserGroup",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookUsers_users_UserId",
                table: "bookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseUser_User",
                table: "CourseUser");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroup_User",
                table: "UserGroup");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "InCart",
                table: "bookUsers");

            migrationBuilder.DropColumn(
                name: "Owned",
                table: "bookUsers");

            migrationBuilder.AddColumn<bool>(
                name: "BookInCart",
                table: "bookUsers",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<bool>(
                name: "UserOwnsBook",
                table: "bookUsers",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 50, nullable: false),
                    FName = table.Column<string>(maxLength: 20, nullable: false),
                    LName = table.Column<string>(maxLength: 20, nullable: false),
                    MName = table.Column<string>(maxLength: 10, nullable: true),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    UserName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.AddForeignKey(
                name: "FK_bookUsers_AspNetUsers",
                table: "bookUsers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUser_AspNetUsers",
                table: "CourseUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroup_AspNetUsers",
                table: "UserGroup",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
