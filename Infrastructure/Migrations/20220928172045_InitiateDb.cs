using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitiateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ce02ed7-d306-41cf-afa1-8e1e76a42b16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9f638be-a33e-4102-96b8-c396e059cd8f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac0707cf-d6de-4a20-8a4b-af6cdba90bf0", "56e6802b-8caf-4c60-8f4c-1280f2eee2fc", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27cc6380-a962-40bc-bf4c-d37444774f0c", "cd67b05c-5e2c-407c-b493-573e31cf4df4", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7ce02ed7-d306-41cf-afa1-8e1e76a42b16", "1abdf80b-91c2-4a20-92a3-d743296c1da3", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9f638be-a33e-4102-96b8-c396e059cd8f", "1a627e37-1b49-409a-8fa4-6d53eeb07869", "Instructor", "INSTRUCTOR" });
        }
    }
}
