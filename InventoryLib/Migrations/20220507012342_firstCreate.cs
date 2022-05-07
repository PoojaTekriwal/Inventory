using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryLib.Migrations
{
    public partial class firstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Inventory",
                schema: "dbo",
                columns: table => new
                {
                    inInventoryId = table.Column<int>(type: "int", nullable: false),
                    unInventoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    stInventoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dcPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory",
                schema: "dbo");
        }
    }
}
