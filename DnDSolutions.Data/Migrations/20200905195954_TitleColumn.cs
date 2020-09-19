using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class TitleColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryTitle",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "Cat_DeliveryTitle",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "Dog_DeliveryTitle",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "HeavyVehicle_DeliveryTitle",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "Art_DeliveryTitle",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "HouseholdItem_DeliveryTitle",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "Move_DeliveryTitle",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "Office_DeliveryTitle",
                table: "DeliveryItem");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "DeliveryItem",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "DeliveryItem");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryTitle",
                table: "DeliveryItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat_DeliveryTitle",
                table: "DeliveryItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dog_DeliveryTitle",
                table: "DeliveryItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeavyVehicle_DeliveryTitle",
                table: "DeliveryItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Art_DeliveryTitle",
                table: "DeliveryItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseholdItem_DeliveryTitle",
                table: "DeliveryItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Move_DeliveryTitle",
                table: "DeliveryItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Office_DeliveryTitle",
                table: "DeliveryItem",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
