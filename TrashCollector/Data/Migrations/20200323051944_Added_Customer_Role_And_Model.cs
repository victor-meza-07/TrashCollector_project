using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Added_Customer_Role_And_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24be554b-5943-4bfb-b741-b70a3febc0a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23e719e0-85e4-4efa-a282-74f61fd94e3d", "a5e62f79-9d7f-4a35-9997-872d8e14d981", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14381f68-4c40-40a9-8936-4af185105521", "b601b345-0056-43e5-8233-4ce40e3839e1", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14381f68-4c40-40a9-8936-4af185105521");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23e719e0-85e4-4efa-a282-74f61fd94e3d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24be554b-5943-4bfb-b741-b70a3febc0a5", "05165aeb-30e8-4b18-aa56-b3b1dde7ec33", "Admin", "ADMIN" });
        }
    }
}
