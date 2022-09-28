using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CurrentLectureAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adca8570-63a3-4c85-809c-f8c418493f8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2ab147-e914-46fb-aed9-e7693a8669da");

            migrationBuilder.AddColumn<int>(
                name: "CurrentLecture",
                table: "UserCourses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38835f33-d77d-4b19-ba18-7db2a99a43f1", "ff332225-f67a-4ce6-95d9-18a4facdfea3", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64c0ffc4-0282-4e86-9546-333a484aab9b", "a3ad2122-2d02-4f4e-8ca1-66593babec8d", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38835f33-d77d-4b19-ba18-7db2a99a43f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64c0ffc4-0282-4e86-9546-333a484aab9b");

            migrationBuilder.DropColumn(
                name: "CurrentLecture",
                table: "UserCourses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "adca8570-63a3-4c85-809c-f8c418493f8e", "e87ce340-5862-4c6e-94d2-dcb4c436bd07", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc2ab147-e914-46fb-aed9-e7693a8669da", "926fa455-58c3-41c4-bac7-fddb330536ad", "Instructor", "INSTRUCTOR" });
        }
    }
}
