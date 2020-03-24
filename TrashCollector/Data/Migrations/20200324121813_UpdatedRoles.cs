using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5ba676a-b56b-467f-a14b-2ee69ebb23d6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e87351ed-ea9f-416a-9bee-203c01126ad8", "961fa44b-d685-4488-9b3c-44544f7f34e9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e7a2a6b-3683-41f5-9e93-7b8e0c14bd8a", "55772cb8-5252-4ea7-b51c-b475fa8d4220", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e7a2a6b-3683-41f5-9e93-7b8e0c14bd8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e87351ed-ea9f-416a-9bee-203c01126ad8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5ba676a-b56b-467f-a14b-2ee69ebb23d6", "7803bab8-05f1-402b-9f5f-0431d4934c76", "Admin", "ADMIN" });
        }
    }
}
