using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddUsersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    email_confirmed = table.Column<short>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_client_UserId",
                table: "client",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_client_users_UserId",
                table: "client",
                column: "UserId",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_client_users_UserId",
                table: "client");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropIndex(
                name: "IX_client_UserId",
                table: "client");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "client");
        }
    }
}
