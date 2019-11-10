using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NAD_IABRS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    fName = table.Column<string>(nullable: false),
                    lName = table.Column<string>(nullable: false),
                    mName = table.Column<string>(nullable: true),
                    bio = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    isbn = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    authorId = table.Column<int>(nullable: false),
                    tagName = table.Column<List<string>>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => new { x.Id, x.isbn });
                    table.ForeignKey(
                        name: "FK_books_authors_authorId",
                        column: x => x.authorId,
                        principalTable: "authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    tagName = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    description = table.Column<string>(nullable: false),
                    BookId = table.Column<int>(nullable: true),
                    Bookisbn = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.tagName);
                    table.ForeignKey(
                        name: "FK_tags_books_BookId_Bookisbn",
                        columns: x => new { x.BookId, x.Bookisbn },
                        principalTable: "books",
                        principalColumns: new[] { "Id", "isbn" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_authorId",
                table: "books",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_tags_BookId_Bookisbn",
                table: "tags",
                columns: new[] { "BookId", "Bookisbn" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "authors");
        }
    }
}
