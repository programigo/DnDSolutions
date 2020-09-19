using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class MeasurementsColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Horse_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_Width",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_Width",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_Width",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_Width",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_Height",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_Length",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_Width",
                table: "Deliveries");

            migrationBuilder.AlterColumn<int>(
                name: "Snowmobile_Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecreationalVehicle_Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Household_Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Art_Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Boat_Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TotalWeight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Horse_Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Dog_Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cat_Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeightFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeightSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LengthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LengthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnit",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WidthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WidthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Boat_HeightFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Boat_HeightSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Boat_LengthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Boat_LengthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Boat_MeasurementUnit",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Boat_WidthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Boat_WidthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Art_HeightFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Art_HeightSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Art_LengthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Art_LengthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Art_MeasurementUnit",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Art_WidthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Art_WidthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Household_HeightFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Household_HeightSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Household_LengthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Household_LengthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Household_MeasurementUnit",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Household_WidthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Household_WidthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecreationalVehicle_HeightFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecreationalVehicle_HeightSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecreationalVehicle_LengthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecreationalVehicle_LengthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecreationalVehicle_MeasurementUnit",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecreationalVehicle_WidthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecreationalVehicle_WidthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Snowmobile_HeightFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Snowmobile_HeightSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Snowmobile_LengthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Snowmobile_LengthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Snowmobile_MeasurementUnit",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Snowmobile_WidthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Snowmobile_WidthSecondPart",
                table: "Deliveries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeightFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HeightSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LengthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LengthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "MeasurementUnit",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "WidthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "WidthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_HeightFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_HeightSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_LengthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_LengthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_MeasurementUnit",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_WidthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Boat_WidthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_HeightFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_HeightSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_LengthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_LengthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_MeasurementUnit",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_WidthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Art_WidthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_HeightFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_HeightSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_LengthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_LengthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_MeasurementUnit",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_WidthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Household_WidthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_HeightFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_HeightSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_LengthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_LengthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_MeasurementUnit",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_WidthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_WidthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_HeightFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_HeightSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_LengthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_LengthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_MeasurementUnit",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_WidthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Snowmobile_WidthSecondPart",
                table: "Deliveries");

            migrationBuilder.AlterColumn<double>(
                name: "Snowmobile_Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RecreationalVehicle_Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Household_Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Art_Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Boat_Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalWeight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Horse_Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Dog_Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Cat_Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Deliveries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Horse_Height",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Boat_Height",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Boat_Length",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Boat_Width",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Art_Height",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Art_Length",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Art_Width",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Household_Height",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Household_Length",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Household_Width",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RecreationalVehicle_Height",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RecreationalVehicle_Length",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RecreationalVehicle_Width",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Snowmobile_Height",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Snowmobile_Length",
                table: "Deliveries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Snowmobile_Width",
                table: "Deliveries",
                type: "float",
                nullable: true);
        }
    }
}
