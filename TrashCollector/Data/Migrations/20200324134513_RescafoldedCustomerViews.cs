using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class RescafoldedCustomerViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09205975-4d9d-45c8-b35b-db78e702ae75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0c35253-922c-4901-a7aa-25790edfe33f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9457313-b9d2-4dd7-a725-1fd3deeb7b5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a503f5a-474d-4786-a8b8-132d4907a2cc", "528a1a36-a5b1-4543-930c-da6fafafccfc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00381f64-5c8d-40e5-bf0c-8b9af288d696", "6d21f9e2-6ae0-4c45-a996-f5ef14210144", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a31e50a1-619e-41cb-9d5b-d86f02ab9b8b", "ce2f68d0-8222-4dc6-a5a3-f4b1d7cccab0", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00381f64-5c8d-40e5-bf0c-8b9af288d696");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a503f5a-474d-4786-a8b8-132d4907a2cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a31e50a1-619e-41cb-9d5b-d86f02ab9b8b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09205975-4d9d-45c8-b35b-db78e702ae75", "03a954f7-820e-4b6a-b167-eccd9c75a969", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9457313-b9d2-4dd7-a725-1fd3deeb7b5a", "ad1dec32-7a92-4dce-b53b-fbe483be7b9d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0c35253-922c-4901-a7aa-25790edfe33f", "fefe7c9b-d6a7-4448-aab4-cb7e8e44462d", "Employee", "EMPLOYEE" });
        }
    }
}
