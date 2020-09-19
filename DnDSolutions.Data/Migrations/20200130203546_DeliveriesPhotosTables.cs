using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class DeliveriesPhotosTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId",
                table: "DeliveryItem");

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

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_DeliveryItem_DeliveryItemId",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryItem",
                table: "DeliveryItem");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Photos");

            migrationBuilder.RenameTable(
                name: "DeliveryItem",
                newName: "Deliveries");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_DeliveryItemId",
                table: "Photos",
                newName: "IX_Photos_DeliveryItemId");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId4",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId4");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId3",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId3");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId2",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId2");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId1",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId1",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId2",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId3",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId4",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Deliveries_DeliveryItemId",
                table: "Photos",
                column: "DeliveryItemId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId1",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId2",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId3",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId4",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Deliveries_DeliveryItemId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photo");

            migrationBuilder.RenameTable(
                name: "Deliveries",
                newName: "DeliveryItem");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_DeliveryItemId",
                table: "Photo",
                newName: "IX_Photo_DeliveryItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId4",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId4");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId3",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId3");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId2",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId2");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId1",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryItem",
                table: "DeliveryItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_DeliveryItem_DeliveryItemId",
                table: "Photo",
                column: "DeliveryItemId",
                principalTable: "DeliveryItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
