using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class EditedCustomerModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a73ed8f3-e206-4adf-a384-594442c8c91d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae996c6a-fb21-46fc-9dde-911510c70f3a");

            migrationBuilder.AddColumn<double>(
                name: "AmountOwed",
                table: "Customer",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndOfCycle",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "ExtraPickUpUsed",
                table: "Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpDate",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartOfCycle",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e9b87c8-6a9d-435f-951b-c974bc5ef34f", "494b2b40-0884-42f7-a7bd-8bd71ea5748f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c76277e8-2ff7-4e71-93b4-1089ec6a2b46", "1d5ea192-37f4-4aae-b87c-4e8967933cd1", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e9b87c8-6a9d-435f-951b-c974bc5ef34f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c76277e8-2ff7-4e71-93b4-1089ec6a2b46");

            migrationBuilder.DropColumn(
                name: "AmountOwed",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "EndOfCycle",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ExtraPickUpUsed",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PickUpDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "StartOfCycle",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a73ed8f3-e206-4adf-a384-594442c8c91d", "18925dff-312b-460f-af02-cc6a2d86b2ac", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae996c6a-fb21-46fc-9dde-911510c70f3a", "3d5482b9-7b64-4ff9-9030-97424c6de2a6", "Customer", "CUSTOMER" });
        }
    }
}
