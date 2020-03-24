using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedEmployeeModelEditedCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e7a2a6b-3683-41f5-9e93-7b8e0c14bd8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e87351ed-ea9f-416a-9bee-203c01126ad8");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CustomerModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "CustomerModel",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address",
                table: "CustomerModel");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "CustomerModel");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e87351ed-ea9f-416a-9bee-203c01126ad8", "961fa44b-d685-4488-9b3c-44544f7f34e9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e7a2a6b-3683-41f5-9e93-7b8e0c14bd8a", "55772cb8-5252-4ea7-b51c-b475fa8d4220", "Customer", "CUSTOMER" });
        }
    }
}
