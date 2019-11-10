using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NAD_IABRS.Migrations
{
    public partial class addedmanyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_authorId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_tags_books_BookId_Bookisbn",
                table: "tags");

            migrationBuilder.DropIndex(
                name: "IX_tags_BookId_Bookisbn",
                table: "tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_authors",
                table: "authors");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "tags");

            migrationBuilder.DropColumn(
                name: "Bookisbn",
                table: "tags");

            migrationBuilder.DropColumn(
                name: "tagName",
                table: "books");

            migrationBuilder.RenameTable(
                name: "authors",
                newName: "person");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "books",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "person",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_person",
                table: "person",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "bookTags",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookTags", x => new { x.BookId, x.TagId });
                    table.ForeignKey(
                        name: "FK_bookTags_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookTags_tags_TagId",
                        column: x => x.TagId,
                        principalTable: "tags",
                        principalColumn: "tagName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookUsers",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookUsers", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_bookUsers_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookUsers_person_UserId",
                        column: x => x.UserId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    startDate = table.Column<string>(maxLength: 10, nullable: false),
                    endDate = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bookCourses",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    CouseId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookCourses", x => new { x.BookId, x.CouseId });
                    table.ForeignKey(
                        name: "FK_bookCourses_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookCourses_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "courseUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    CouseId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseUsers", x => new { x.CouseId, x.UserId });
                    table.ForeignKey(
                        name: "FK_courseUsers_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_courseUsers_person_UserId",
                        column: x => x.UserId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookCourses_CourseId",
                table: "bookCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_bookTags_TagId",
                table: "bookTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_bookUsers_UserId",
                table: "bookUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_courseUsers_CourseId",
                table: "courseUsers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_courseUsers_UserId",
                table: "courseUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_person_authorId",
                table: "books",
                column: "authorId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_person_authorId",
                table: "books");

            migrationBuilder.DropTable(
                name: "bookCourses");

            migrationBuilder.DropTable(
                name: "bookTags");

            migrationBuilder.DropTable(
                name: "bookUsers");

            migrationBuilder.DropTable(
                name: "courseUsers");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_person",
                table: "person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "person");

            migrationBuilder.RenameTable(
                name: "person",
                newName: "authors");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "tags",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bookisbn",
                table: "tags",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "books",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<List<string>>(
                name: "tagName",
                table: "books",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                columns: new[] { "Id", "isbn" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_authors",
                table: "authors",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tags_BookId_Bookisbn",
                table: "tags",
                columns: new[] { "BookId", "Bookisbn" });

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_authorId",
                table: "books",
                column: "authorId",
                principalTable: "authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tags_books_BookId_Bookisbn",
                table: "tags",
                columns: new[] { "BookId", "Bookisbn" },
                principalTable: "books",
                principalColumns: new[] { "Id", "isbn" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
