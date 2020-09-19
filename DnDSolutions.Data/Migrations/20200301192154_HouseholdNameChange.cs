using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class HouseholdNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Household_WidthSecondPart",
                table: "Deliveries",
                newName: "HouseholdItem_WidthSecondPart");

            migrationBuilder.RenameColumn(
                name: "Household_WidthFirstPart",
                table: "Deliveries",
                newName: "HouseholdItem_WidthFirstPart");

            migrationBuilder.RenameColumn(
                name: "Household_Weight",
                table: "Deliveries",
                newName: "HouseholdItem_Weight");

            migrationBuilder.RenameColumn(
                name: "Household_Type",
                table: "Deliveries",
                newName: "HouseholdItem_Type");

            migrationBuilder.RenameColumn(
                name: "Household_MeasurementUnit",
                table: "Deliveries",
                newName: "HouseholdItem_MeasurementUnit");

            migrationBuilder.RenameColumn(
                name: "Household_LengthSecondPart",
                table: "Deliveries",
                newName: "HouseholdItem_LengthSecondPart");

            migrationBuilder.RenameColumn(
                name: "Household_LengthFirstPart",
                table: "Deliveries",
                newName: "HouseholdItem_LengthFirstPart");

            migrationBuilder.RenameColumn(
                name: "Household_HeightSecondPart",
                table: "Deliveries",
                newName: "HouseholdItem_HeightSecondPart");

            migrationBuilder.RenameColumn(
                name: "Household_HeightFirstPart",
                table: "Deliveries",
                newName: "HouseholdItem_HeightFirstPart");

            migrationBuilder.RenameColumn(
                name: "Household_DeliveryTitle",
                table: "Deliveries",
                newName: "HouseholdItem_DeliveryTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HouseholdItem_WidthSecondPart",
                table: "Deliveries",
                newName: "Household_WidthSecondPart");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_WidthFirstPart",
                table: "Deliveries",
                newName: "Household_WidthFirstPart");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_Weight",
                table: "Deliveries",
                newName: "Household_Weight");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_Type",
                table: "Deliveries",
                newName: "Household_Type");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_MeasurementUnit",
                table: "Deliveries",
                newName: "Household_MeasurementUnit");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_LengthSecondPart",
                table: "Deliveries",
                newName: "Household_LengthSecondPart");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_LengthFirstPart",
                table: "Deliveries",
                newName: "Household_LengthFirstPart");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_HeightSecondPart",
                table: "Deliveries",
                newName: "Household_HeightSecondPart");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_HeightFirstPart",
                table: "Deliveries",
                newName: "Household_HeightFirstPart");

            migrationBuilder.RenameColumn(
                name: "HouseholdItem_DeliveryTitle",
                table: "Deliveries",
                newName: "Household_DeliveryTitle");
        }
    }
}
