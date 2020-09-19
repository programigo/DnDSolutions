using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class InitialVehicleBoatUserTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "DeliveryItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectionDateEarliest = table.Column<DateTime>(nullable: false),
                    CollectionDateLatest = table.Column<DateTime>(nullable: false),
                    DeliveryDateEarliest = table.Column<DateTime>(nullable: false),
                    DeliveryDateLatest = table.Column<DateTime>(nullable: false),
                    ServiceType = table.Column<int>(nullable: false),
                    AdditionalDetails = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: true),
                    Make = table.Column<string>(maxLength: 20, nullable: true),
                    Model = table.Column<string>(maxLength: 20, nullable: true),
                    Length = table.Column<double>(nullable: true),
                    Width = table.Column<double>(nullable: true),
                    Height = table.Column<double>(nullable: true),
                    Weight = table.Column<double>(nullable: true),
                    IsOnTrailer = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    BodyType = table.Column<int>(nullable: true),
                    Car_Make = table.Column<string>(maxLength: 20, nullable: true),
                    Car_Model = table.Column<string>(maxLength: 20, nullable: true),
                    State = table.Column<int>(nullable: true),
                    PickupLocation = table.Column<string>(maxLength: 100, nullable: true),
                    DeliveryLocation = table.Column<string>(maxLength: 100, nullable: true),
                    Car_UserId = table.Column<string>(nullable: true),
                    Motorcycle_Type = table.Column<int>(nullable: true),
                    Motorcycle_Make = table.Column<string>(maxLength: 20, nullable: true),
                    Motorcycle_Model = table.Column<string>(maxLength: 20, nullable: true),
                    Motorcycle_State = table.Column<int>(nullable: true),
                    Motorcycle_PickupLocation = table.Column<string>(maxLength: 100, nullable: true),
                    Motorcycle_DeliveryLocation = table.Column<string>(maxLength: 100, nullable: true),
                    Motorcycle_UserId = table.Column<string>(nullable: true),
                    RecreationalVehicle_Type = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    RecreationalVehicle_Make = table.Column<string>(nullable: true),
                    RecreationalVehicle_Model = table.Column<string>(nullable: true),
                    RecreationalVehicle_Length = table.Column<double>(nullable: true),
                    RecreationalVehicle_Width = table.Column<double>(nullable: true),
                    RecreationalVehicle_Height = table.Column<double>(nullable: true),
                    RecreationalVehicle_Weight = table.Column<double>(nullable: true),
                    CanBeDriven = table.Column<bool>(nullable: true),
                    RecreationalVehicle_Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 2000, nullable: true),
                    RecreationalVehicle_UserId = table.Column<string>(nullable: true),
                    Snowmobile_Make = table.Column<string>(maxLength: 20, nullable: true),
                    Snowmobile_Model = table.Column<string>(maxLength: 20, nullable: true),
                    Snowmobile_Length = table.Column<double>(nullable: true),
                    Snowmobile_Width = table.Column<double>(nullable: true),
                    Snowmobile_Height = table.Column<double>(nullable: true),
                    Snowmobile_Weight = table.Column<double>(nullable: true),
                    Snowmobile_UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryItem_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeliveryItem_AspNetUsers_Car_UserId",
                        column: x => x.Car_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeliveryItem_AspNetUsers_Motorcycle_UserId",
                        column: x => x.Motorcycle_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeliveryItem_AspNetUsers_RecreationalVehicle_UserId",
                        column: x => x.RecreationalVehicle_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeliveryItem_AspNetUsers_Snowmobile_UserId",
                        column: x => x.Snowmobile_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    DeliveryItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_DeliveryItem_DeliveryItemId",
                        column: x => x.DeliveryItemId,
                        principalTable: "DeliveryItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_UserId",
                table: "DeliveryItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_Car_UserId",
                table: "DeliveryItem",
                column: "Car_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_Motorcycle_UserId",
                table: "DeliveryItem",
                column: "Motorcycle_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_RecreationalVehicle_UserId",
                table: "DeliveryItem",
                column: "RecreationalVehicle_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_Snowmobile_UserId",
                table: "DeliveryItem",
                column: "Snowmobile_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_DeliveryItemId",
                table: "Photo",
                column: "DeliveryItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
