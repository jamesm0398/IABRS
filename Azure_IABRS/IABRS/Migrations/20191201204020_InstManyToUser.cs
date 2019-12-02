using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IABRS.Migrations
{
    public partial class InstManyToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.CreateTable(
                name: "InstitutionUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstitutionId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionUser_Institution_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_InstitutionUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionUser_InstitutionId",
                table: "InstitutionUser",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionUser_UserId",
                table: "InstitutionUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstitutionUser");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);
        }
    }
}
