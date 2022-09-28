using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class DropedAndAddedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38835f33-d77d-4b19-ba18-7db2a99a43f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64c0ffc4-0282-4e86-9546-333a484aab9b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd31dbbe-46e3-41e7-ad05-d67673110077", "6972574c-dc05-490d-a5c2-d2fd04c33a9e", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "467e7d81-5c4f-4400-81cb-c2e0ffdf2ba1", "3171dc56-09ce-4b8a-a02a-34b2040094a7", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "467e7d81-5c4f-4400-81cb-c2e0ffdf2ba1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd31dbbe-46e3-41e7-ad05-d67673110077");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38835f33-d77d-4b19-ba18-7db2a99a43f1", "ff332225-f67a-4ce6-95d9-18a4facdfea3", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64c0ffc4-0282-4e86-9546-333a484aab9b", "a3ad2122-2d02-4f4e-8ca1-66593babec8d", "Instructor", "INSTRUCTOR" });
        }
    }
}
