using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class DeliveryUserIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_Car_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_Motorcycle_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_RecreationalVehicle_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_Snowmobile_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_Car_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_Motorcycle_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_RecreationalVehicle_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_Snowmobile_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "Car_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "Motorcycle_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "RecreationalVehicle_UserId",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "Snowmobile_UserId",
                table: "DeliveryItem");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_UserId1",
                table: "DeliveryItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_UserId2",
                table: "DeliveryItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_UserId3",
                table: "DeliveryItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_UserId4",
                table: "DeliveryItem",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId1",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId2",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId3",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId4",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId1",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId2",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId3",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId4",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_UserId1",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_UserId2",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_UserId3",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_UserId4",
                table: "DeliveryItem");

            migrationBuilder.AddColumn<string>(
                name: "Car_UserId",
                table: "DeliveryItem",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motorcycle_UserId",
                table: "DeliveryItem",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecreationalVehicle_UserId",
                table: "DeliveryItem",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Snowmobile_UserId",
                table: "DeliveryItem",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_Car_UserId",
                table: "DeliveryItem",
                column: "Car_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_Motorcycle_UserId",
                table: "DeliveryItem",
                column: "Motorcycle_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_RecreationalVehicle_UserId",
                table: "DeliveryItem",
                column: "RecreationalVehicle_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_Snowmobile_UserId",
                table: "DeliveryItem",
                column: "Snowmobile_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
