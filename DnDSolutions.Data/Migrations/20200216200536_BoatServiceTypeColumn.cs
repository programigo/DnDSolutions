using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class BoatServiceTypeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Motorcycle_DeliveryLocation",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Motorcycle_PickupLocation",
                table: "Deliveries");

            migrationBuilder.AlterColumn<string>(
                name: "PickupLocation",
                table: "Deliveries",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryLocation",
                table: "Deliveries",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Car_ServiceType",
                table: "Deliveries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Car_ServiceType",
                table: "Deliveries");

            migrationBuilder.AlterColumn<string>(
                name: "PickupLocation",
                table: "Deliveries",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryLocation",
                table: "Deliveries",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Motorcycle_DeliveryLocation",
                table: "Deliveries",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motorcycle_PickupLocation",
                table: "Deliveries",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
