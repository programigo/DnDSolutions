using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class DeliveryInsuranceColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasInsurance",
                table: "DeliveryItem",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasInsurance",
                table: "DeliveryItem");
        }
    }
}
