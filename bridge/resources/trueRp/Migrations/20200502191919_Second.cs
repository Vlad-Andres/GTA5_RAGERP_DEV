using Microsoft.EntityFrameworkCore.Migrations;

namespace trueRp.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.AddColumn<int>(
                name: "count",
                table: "Inventory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "itemID",
                table: "Inventory",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "count",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "itemID",
                table: "Inventory");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    itemID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    code = table.Column<int>(nullable: false),
                    inventoryID = table.Column<int>(nullable: true),
                    name = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Item_inventoryID",
                table: "Item",
                column: "inventoryID");
        }
    }
}
