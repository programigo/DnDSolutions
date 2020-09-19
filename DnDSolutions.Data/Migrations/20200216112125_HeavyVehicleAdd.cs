using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class HeavyVehicleAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId16",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId17",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId16",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId17",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CommercialTruck_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CommercialTruck_IsOnTrailer",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CommercialTruck_Make",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CommercialTruck_Model",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "ConstructionEquipment_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "ConstructionEquipment_IsOnTrailer",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "ConstructionEquipment_Make",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "ConstructionEquipment_Model",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "ConstructionEquipment_TrailerType",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "FarmEquipment_TrailerType",
                table: "Deliveries");

            migrationBuilder.RenameColumn(
                name: "FarmEquipment_Model",
                table: "Deliveries",
                newName: "HeavyVehicle_Model");

            migrationBuilder.RenameColumn(
                name: "FarmEquipment_Make",
                table: "Deliveries",
                newName: "HeavyVehicle_Make");

            migrationBuilder.RenameColumn(
                name: "FarmEquipment_IsOnTrailer",
                table: "Deliveries",
                newName: "HeavyVehicle_IsOnTrailer");

            migrationBuilder.RenameColumn(
                name: "FarmEquipment_DeliveryTitle",
                table: "Deliveries",
                newName: "HeavyVehicle_DeliveryTitle");

            migrationBuilder.AddColumn<int>(
                name: "HeavyVehicle_Type",
                table: "Deliveries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeavyVehicle_Type",
                table: "Deliveries");

            migrationBuilder.RenameColumn(
                name: "HeavyVehicle_Model",
                table: "Deliveries",
                newName: "FarmEquipment_Model");

            migrationBuilder.RenameColumn(
                name: "HeavyVehicle_Make",
                table: "Deliveries",
                newName: "FarmEquipment_Make");

            migrationBuilder.RenameColumn(
                name: "HeavyVehicle_IsOnTrailer",
                table: "Deliveries",
                newName: "FarmEquipment_IsOnTrailer");

            migrationBuilder.RenameColumn(
                name: "HeavyVehicle_DeliveryTitle",
                table: "Deliveries",
                newName: "FarmEquipment_DeliveryTitle");

            migrationBuilder.AddColumn<string>(
                name: "CommercialTruck_DeliveryTitle",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CommercialTruck_IsOnTrailer",
                table: "Deliveries",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommercialTruck_Make",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommercialTruck_Model",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionEquipment_DeliveryTitle",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ConstructionEquipment_IsOnTrailer",
                table: "Deliveries",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionEquipment_Make",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionEquipment_Model",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConstructionEquipment_TrailerType",
                table: "Deliveries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FarmEquipment_TrailerType",
                table: "Deliveries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId16",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId17",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId16",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId17",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
