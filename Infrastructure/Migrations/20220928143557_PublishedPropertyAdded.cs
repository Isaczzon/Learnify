using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PublishedPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "467e7d81-5c4f-4400-81cb-c2e0ffdf2ba1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd31dbbe-46e3-41e7-ad05-d67673110077");

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Courses",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ce02ed7-d306-41cf-afa1-8e1e76a42b16", "1abdf80b-91c2-4a20-92a3-d743296c1da3", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9f638be-a33e-4102-96b8-c396e059cd8f", "1a627e37-1b49-409a-8fa4-6d53eeb07869", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ce02ed7-d306-41cf-afa1-8e1e76a42b16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9f638be-a33e-4102-96b8-c396e059cd8f");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd31dbbe-46e3-41e7-ad05-d67673110077", "6972574c-dc05-490d-a5c2-d2fd04c33a9e", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "467e7d81-5c4f-4400-81cb-c2e0ffdf2ba1", "3171dc56-09ce-4b8a-a02a-34b2040094a7", "Instructor", "INSTRUCTOR" });
        }
    }
}
