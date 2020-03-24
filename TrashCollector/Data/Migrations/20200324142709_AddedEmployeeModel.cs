using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "EmployeeModel",
                columns: table => new
                {
                    PrimaryKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeModel", x => x.PrimaryKey);
                    table.ForeignKey(
                        name: "FK_EmployeeModel_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c44ef3a7-9288-43f3-a5c4-2bafb4c05cd8", "1f94f207-3181-43be-b908-6cd6bac1ead5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a039a9a8-c56f-4600-9227-4d7c8f9018ee", "95ca2c70-0baf-4b1f-a799-da064f08608c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1075080-1dd3-48ff-8f1e-a15e18ec2d07", "041e4616-5f5d-473f-93f1-7aebc5ca9f93", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeModel_IdentityUserId",
                table: "EmployeeModel",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeModel");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a039a9a8-c56f-4600-9227-4d7c8f9018ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1075080-1dd3-48ff-8f1e-a15e18ec2d07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c44ef3a7-9288-43f3-a5c4-2bafb4c05cd8");

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
    }
}
