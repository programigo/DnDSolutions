using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class LessThanContainerLoadTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HandlingUnit",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_HeightFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_HeightSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHazardous",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsStackable",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_LengthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_LengthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_MeasurementUnit",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_Type",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_Weight",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_WidthFirstPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessThanContainerLoad_WidthSecondPart",
                table: "Deliveries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId16",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId16",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId16",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_UserId16",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "HandlingUnit",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_HeightFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_HeightSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "IsHazardous",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "IsStackable",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_LengthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_LengthSecondPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_MeasurementUnit",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_Type",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_Weight",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_WidthFirstPart",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LessThanContainerLoad_WidthSecondPart",
                table: "Deliveries");
        }
    }
}
