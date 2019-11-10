using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NAD_IABRS.Migrations
{
    public partial class changedInheritStrat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_person_authorId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_bookUsers_person_UserId",
                table: "bookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_courseUsers_person_UserId",
                table: "courseUsers");

            migrationBuilder.DropColumn(
                name: "bio",
                table: "person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "person");

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    authorId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    personId = table.Column<int>(nullable: false),
                    bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.authorId);
                    table.ForeignKey(
                        name: "FK_authors_person_personId",
                        column: x => x.personId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    personId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_person_personId",
                        column: x => x.personId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_authors_personId",
                table: "authors",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_users_personId",
                table: "users",
                column: "personId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_authorId",
                table: "books",
                column: "authorId",
                principalTable: "authors",
                principalColumn: "authorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookUsers_users_UserId",
                table: "bookUsers",
                column: "UserId",
                principalTable: "users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courseUsers_users_UserId",
                table: "courseUsers",
                column: "UserId",
                principalTable: "users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_authorId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_bookUsers_users_UserId",
                table: "bookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_courseUsers_users_UserId",
                table: "courseUsers");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.AddColumn<string>(
                name: "bio",
                table: "person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "person",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_books_person_authorId",
                table: "books",
                column: "authorId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookUsers_person_UserId",
                table: "bookUsers",
                column: "UserId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courseUsers_person_UserId",
                table: "courseUsers",
                column: "UserId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
