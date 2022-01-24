using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelosDB.Migrations
{
    public partial class DbInicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    addressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    distric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    postal_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.addressId);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    staffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    store_id = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.staffId);
                    table.ForeignKey(
                        name: "FK_Staffs_Addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "Addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    paymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<float>(type: "real", nullable: false),
                    payment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customer_Id = table.Column<int>(type: "int", nullable: false),
                    rental_Id = table.Column<int>(type: "int", nullable: false),
                    staffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.paymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Staffs_staffId",
                        column: x => x.staffId,
                        principalTable: "Staffs",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_staffId",
                table: "Payments",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_addressId",
                table: "Staffs",
                column: "addressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
