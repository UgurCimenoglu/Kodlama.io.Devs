using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevsProject.Persistence.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammingLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguage", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguage",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IsActive", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 9, 19, 4, 1, 31, 302, DateTimeKind.Local).AddTicks(909), "Seed Data", true, "C#", null, null });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguage",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IsActive", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 9, 19, 4, 1, 31, 302, DateTimeKind.Local).AddTicks(919), "Seed Data", true, "Java", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgrammingLanguage");
        }
    }
}
