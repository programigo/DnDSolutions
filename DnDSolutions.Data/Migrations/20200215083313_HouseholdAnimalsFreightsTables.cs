using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class HouseholdAnimalsFreightsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasAllVaccinations",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasCarrier",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasSpecificNeeds",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cat_Weight",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dog_Breed",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dog_Count",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dog_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Dog_HasAllVaccinations",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Dog_HasCarrier",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Dog_HasSpecificNeeds",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dog_Name",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dog_Weight",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Horse_Breed",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Horse_Count",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Horse_Height",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Horse_Name",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Horse_Weight",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Livestock_Breed",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Livestock_Count",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasAllTags",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Livestock_HasAllVaccinations",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Livestock_HasSpecificNeeds",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsInCorral",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalWeight",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Boat_Height",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Boat_Length",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Boat_Weight",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Boat_Width",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommercialTruck_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CommercialTruck_IsOnTrailer",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommercialTruck_Make",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommercialTruck_Model",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrailerType",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionEquipment_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ConstructionEquipment_IsOnTrailer",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionEquipment_Make",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionEquipment_Model",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConstructionEquipment_TrailerType",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FarmEquipment_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FarmEquipment_IsOnTrailer",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FarmEquipment_Make",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FarmEquipment_Model",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FarmEquipment_TrailerType",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Art_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Art_Description",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Art_Height",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Art_Length",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Packaging",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialHandling",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Art_Type",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Art_Weight",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Art_Width",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Household_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Household_Height",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCrated",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPalletised",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsStickable",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Household_Length",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfItems",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Household_Type",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Household_Weight",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Household_Width",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Move_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Move_Type",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CollectionFloor",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryFloor",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Office_DeliveryTitle",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasCollectionFloorElevator",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasDeliveryFloorElevator",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasDisassemblyItems",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasReassemblyItems",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HorizontalType",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnCasters",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VerticalType",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId5",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId6",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId7",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId8",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId9",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId10",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId11",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId12",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId13",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId14",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId15",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId16",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId17",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId5",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId6",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId7",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId8",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId9",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId10",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId11",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId12",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId13",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId14",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId15",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId5",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId6",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId7",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId8",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId9",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId10",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId11",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId12",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId13",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId14",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId15",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId16",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId17",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId5",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId6",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId7",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId8",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId9",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId10",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId11",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId12",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId13",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId14",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId15",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId16",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId17",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Cat_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HasAllVaccinations",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HasCarrier",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HasSpecificNeeds",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Cat_Weight",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Dog_Breed",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Dog_Count",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Dog_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Dog_HasAllVaccinations",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Dog_HasCarrier",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Dog_HasSpecificNeeds",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Dog_Name",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Dog_Weight",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Horse_Breed",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Horse_Count",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Horse_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Horse_Name",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Horse_Weight",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Livestock_Breed",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Livestock_Count",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HasAllTags",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Livestock_HasAllVaccinations",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Livestock_HasSpecificNeeds",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "IsInCorral",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "TotalWeight",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_Weight",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_Width",
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
                name: "TrailerType",
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
                name: "FarmEquipment_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "FarmEquipment_IsOnTrailer",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "FarmEquipment_Make",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "FarmEquipment_Model",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "FarmEquipment_TrailerType",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Description",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Packaging",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "SpecialHandling",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Type",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Weight",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Width",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "IsCrated",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "IsPalletised",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "IsStickable",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "NumberOfItems",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_Type",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_Weight",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_Width",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Move_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Move_Type",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CollectionFloor",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "DeliveryFloor",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Office_DeliveryTitle",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HasCollectionFloorElevator",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HasDeliveryFloorElevator",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HasDisassemblyItems",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HasReassemblyItems",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HorizontalType",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "IsOnCasters",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "VerticalType",
                table: "Deliveries");
        }
    }
}
