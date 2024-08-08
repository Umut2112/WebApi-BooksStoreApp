using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRefreshTokenFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "10a8d2e7-1da2-4d0b-b91c-a7b172ef0bae", "9fd85ddc-aa5a-4d83-bbf7-8ffd1947c122", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8880bee5-0107-46c0-9012-ea5bf098682c", "a071dccc-b4cd-43ec-a71b-d84cec2bbcb1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b1cdd7e-360b-48fd-96af-707f7a56e3a2", "8896e282-9b9a-4315-809f-9de4181d6f83", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10a8d2e7-1da2-4d0b-b91c-a7b172ef0bae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8880bee5-0107-46c0-9012-ea5bf098682c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b1cdd7e-360b-48fd-96af-707f7a56e3a2");

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
    }
}
