using Microsoft.EntityFrameworkCore.Migrations;

namespace BookSite2._0.Migrations
{
    public partial class AddPurchaseShipped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PurchaseShipped",
                table: "Purchases",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseShipped",
                table: "Purchases");
        }
    }
}
