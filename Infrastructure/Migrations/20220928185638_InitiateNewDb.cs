using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitiateNewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27cc6380-a962-40bc-bf4c-d37444774f0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac0707cf-d6de-4a20-8a4b-af6cdba90bf0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44681609-6c00-46ef-9b89-f1e5a96b1314", "2622259f-f8b3-4273-94c2-c254c42c3143", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0d83558d-5c60-4a33-875e-cc08632934e0", "00d26e91-fcf9-4f7a-855d-4d1402141eee", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d83558d-5c60-4a33-875e-cc08632934e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44681609-6c00-46ef-9b89-f1e5a96b1314");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac0707cf-d6de-4a20-8a4b-af6cdba90bf0", "56e6802b-8caf-4c60-8f4c-1280f2eee2fc", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27cc6380-a962-40bc-bf4c-d37444774f0c", "cd67b05c-5e2c-407c-b493-573e31cf4df4", "Instructor", "INSTRUCTOR" });
        }
    }
}
