using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace trueRp.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    playerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    balance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.playerID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    inventoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    playerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.inventoryID);
                    table.ForeignKey(
                        name: "FK_Inventory_Player_playerID",
                        column: x => x.playerID,
                        principalTable: "Player",
                        principalColumn: "playerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    propertyID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ownerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.propertyID);
                    table.ForeignKey(
                        name: "FK_Property_Player_ownerID",
                        column: x => x.ownerID,
                        principalTable: "Player",
                        principalColumn: "playerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    itemID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    code = table.Column<int>(nullable: false),
                    inventoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.itemID);
                    table.ForeignKey(
                        name: "FK_Item_Inventory_inventoryID",
                        column: x => x.inventoryID,
                        principalTable: "Inventory",
                        principalColumn: "inventoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    contractID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    date = table.Column<DateTime>(type: "Date", nullable: false),
                    playerID = table.Column<int>(nullable: false),
                    propertyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.contractID);
                    table.ForeignKey(
                        name: "FK_Contract_Player_playerID",
                        column: x => x.playerID,
                        principalTable: "Player",
                        principalColumn: "playerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contract_Property_propertyID",
                        column: x => x.propertyID,
                        principalTable: "Property",
                        principalColumn: "propertyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_playerID",
                table: "Contract",
                column: "playerID");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_propertyID",
                table: "Contract",
                column: "propertyID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_playerID",
                table: "Inventory",
                column: "playerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_inventoryID",
                table: "Item",
                column: "inventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ownerID",
                table: "Property",
                column: "ownerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
