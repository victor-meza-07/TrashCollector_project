using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class EditedCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023a59db-beee-4326-bb34-faf038f538d5");

            migrationBuilder.CreateTable(
                name: "CustomerModel",
                columns: table => new
                {
                    PrimaryKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LatName = table.Column<string>(nullable: true),
                    PickUpDate = table.Column<string>(nullable: true),
                    ExtraPickUpDate = table.Column<string>(nullable: true),
                    AmountOwed = table.Column<double>(nullable: false),
                    StartOfCycle = table.Column<string>(nullable: true),
                    EndOfCycle = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModel", x => x.PrimaryKey);
                    table.ForeignKey(
                        name: "FK_CustomerModel_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5ba676a-b56b-467f-a14b-2ee69ebb23d6", "7803bab8-05f1-402b-9f5f-0431d4934c76", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModel_IdentityUserId",
                table: "CustomerModel",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerModel");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5ba676a-b56b-467f-a14b-2ee69ebb23d6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "023a59db-beee-4326-bb34-faf038f538d5", "b7116582-e8dd-4a10-bb86-42bac8284815", "Admin", "ADMIN" });
        }
    }
}
