using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "carid",
                table: "parking_ticket",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "parking_ticket",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "parkingPositionid",
                table: "parking_ticket",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "parking_ticket",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "pricingid",
                table: "parking_ticket",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "purchased_time",
                table: "parking_ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "spend_time",
                table: "parking_ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "companyParkingsid",
                table: "parking_position",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "parking_position",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "idNumber",
                table: "client",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "carid",
                table: "cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clientid",
                table: "cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "group",
                table: "cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "car",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    clientid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.id);
                    table.ForeignKey(
                        name: "FK_company_client_clientid",
                        column: x => x.clientid,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "parking_pricing",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false),
                    parkingPositionsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parking_pricing", x => x.id);
                    table.ForeignKey(
                        name: "FK_parking_pricing_parking_position_parkingPositionsid",
                        column: x => x.parkingPositionsid,
                        principalTable: "parking_position",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "company_parking",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    companiesid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company_parking", x => x.id);
                    table.ForeignKey(
                        name: "FK_company_parking_company_companiesid",
                        column: x => x.companiesid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_parking_ticket_carid",
                table: "parking_ticket",
                column: "carid");

            migrationBuilder.CreateIndex(
                name: "IX_parking_ticket_parkingPositionid",
                table: "parking_ticket",
                column: "parkingPositionid");

            migrationBuilder.CreateIndex(
                name: "IX_parking_ticket_pricingid",
                table: "parking_ticket",
                column: "pricingid");

            migrationBuilder.CreateIndex(
                name: "IX_parking_position_companyParkingsid",
                table: "parking_position",
                column: "companyParkingsid");

            migrationBuilder.CreateIndex(
                name: "IX_cars_carid",
                table: "cars",
                column: "carid");

            migrationBuilder.CreateIndex(
                name: "IX_cars_clientid",
                table: "cars",
                column: "clientid");

            migrationBuilder.CreateIndex(
                name: "IX_company_clientid",
                table: "company",
                column: "clientid");

            migrationBuilder.CreateIndex(
                name: "IX_company_parking_companiesid",
                table: "company_parking",
                column: "companiesid");

            migrationBuilder.CreateIndex(
                name: "IX_parking_pricing_parkingPositionsid",
                table: "parking_pricing",
                column: "parkingPositionsid");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_car_carid",
                table: "cars",
                column: "carid",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cars_client_clientid",
                table: "cars",
                column: "clientid",
                principalTable: "client",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_parking_position_company_parking_companyParkingsid",
                table: "parking_position",
                column: "companyParkingsid",
                principalTable: "company_parking",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_parking_ticket_car_carid",
                table: "parking_ticket",
                column: "carid",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_parking_ticket_parking_position_parkingPositionid",
                table: "parking_ticket",
                column: "parkingPositionid",
                principalTable: "parking_position",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_parking_ticket_parking_pricing_pricingid",
                table: "parking_ticket",
                column: "pricingid",
                principalTable: "parking_pricing",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_car_carid",
                table: "cars");

            migrationBuilder.DropForeignKey(
                name: "FK_cars_client_clientid",
                table: "cars");

            migrationBuilder.DropForeignKey(
                name: "FK_parking_position_company_parking_companyParkingsid",
                table: "parking_position");

            migrationBuilder.DropForeignKey(
                name: "FK_parking_ticket_car_carid",
                table: "parking_ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_parking_ticket_parking_position_parkingPositionid",
                table: "parking_ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_parking_ticket_parking_pricing_pricingid",
                table: "parking_ticket");

            migrationBuilder.DropTable(
                name: "company_parking");

            migrationBuilder.DropTable(
                name: "parking_pricing");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropIndex(
                name: "IX_parking_ticket_carid",
                table: "parking_ticket");

            migrationBuilder.DropIndex(
                name: "IX_parking_ticket_parkingPositionid",
                table: "parking_ticket");

            migrationBuilder.DropIndex(
                name: "IX_parking_ticket_pricingid",
                table: "parking_ticket");

            migrationBuilder.DropIndex(
                name: "IX_parking_position_companyParkingsid",
                table: "parking_position");

            migrationBuilder.DropIndex(
                name: "IX_cars_carid",
                table: "cars");

            migrationBuilder.DropIndex(
                name: "IX_cars_clientid",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "carid",
                table: "parking_ticket");

            migrationBuilder.DropColumn(
                name: "name",
                table: "parking_ticket");

            migrationBuilder.DropColumn(
                name: "parkingPositionid",
                table: "parking_ticket");

            migrationBuilder.DropColumn(
                name: "price",
                table: "parking_ticket");

            migrationBuilder.DropColumn(
                name: "pricingid",
                table: "parking_ticket");

            migrationBuilder.DropColumn(
                name: "purchased_time",
                table: "parking_ticket");

            migrationBuilder.DropColumn(
                name: "spend_time",
                table: "parking_ticket");

            migrationBuilder.DropColumn(
                name: "companyParkingsid",
                table: "parking_position");

            migrationBuilder.DropColumn(
                name: "name",
                table: "parking_position");

            migrationBuilder.DropColumn(
                name: "idNumber",
                table: "client");

            migrationBuilder.DropColumn(
                name: "carid",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "group",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "type",
                table: "car");

            migrationBuilder.DropColumn(
                name: "code",
                table: "car");
        }
    }
}
