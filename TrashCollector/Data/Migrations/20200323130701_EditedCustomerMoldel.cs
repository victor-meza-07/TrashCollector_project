using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class EditedCustomerMoldel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2e98de86-69f3-4e21-bb4a-b5b57ec1a619", "69dfdedd-565e-4511-9368-1d7f110f6304", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cff7747-6908-4ac3-8c44-597c4f1fb4a8", "49cf5a5c-f931-4dde-aca6-094460e69e39", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cff7747-6908-4ac3-8c44-597c4f1fb4a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e98de86-69f3-4e21-bb4a-b5b57ec1a619");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23e719e0-85e4-4efa-a282-74f61fd94e3d", "a5e62f79-9d7f-4a35-9997-872d8e14d981", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14381f68-4c40-40a9-8936-4af185105521", "b601b345-0056-43e5-8233-4ce40e3839e1", "Customer", "CUSTOMER" });
        }
    }
}
