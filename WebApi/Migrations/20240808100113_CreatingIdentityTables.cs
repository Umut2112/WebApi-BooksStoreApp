using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class CreatingIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18b3fa71-89a1-4796-8888-2c0352836d81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49daaeb5-f4f1-4b5c-afe1-bda8f52b6989");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2e2c019-b555-4a02-9f8a-56568f8634b4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f3502b9-74fa-4694-89b0-616659e1dd33", "1cef293c-b173-4919-b092-d2dc66c3942b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "949bbf89-0b46-4a96-aa20-4e5d74a72d90", "6ee14beb-6316-4b7e-8d3a-14cff0e74120", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a599b0f7-2ee6-46f4-b9d6-8845ac5f4a5e", "cbcd41a9-1f0a-4348-8754-b39fa75e1e19", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f3502b9-74fa-4694-89b0-616659e1dd33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "949bbf89-0b46-4a96-aa20-4e5d74a72d90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a599b0f7-2ee6-46f4-b9d6-8845ac5f4a5e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18b3fa71-89a1-4796-8888-2c0352836d81", "32108382-4595-4894-a8c2-0abea9b3b702", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49daaeb5-f4f1-4b5c-afe1-bda8f52b6989", "a2ff8e01-7c33-45bd-a9bf-959be1a5cfcc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2e2c019-b555-4a02-9f8a-56568f8634b4", "e2d00cb7-7174-4116-a69a-aa483c59f454", "Editor", "EDITOR" });
        }
    }
}
