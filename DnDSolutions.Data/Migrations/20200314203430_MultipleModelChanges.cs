using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class MultipleModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Photos_Deliveries_DeliveryItemId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries");

            migrationBuilder.RenameTable(
                name: "Deliveries",
                newName: "DeliveryItem");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId16",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId16");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId15",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId15");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId14",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId14");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId13",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId13");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId12",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId12");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId11",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId11");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId10",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId10");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId9",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId9");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId8",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId8");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId7",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId7");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId6",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId6");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId5",
                table: "DeliveryItem",
                newName: "IX_DeliveryItem_UserId5");

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
                name: "FK_DeliveryItem_AspNetUsers_UserId5",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId6",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId7",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId8",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId9",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId10",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId11",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId12",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId13",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId14",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId15",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId16",
                table: "DeliveryItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_DeliveryItem_DeliveryItemId",
                table: "Photos",
                column: "DeliveryItemId",
                principalTable: "DeliveryItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_DeliveryItem_AspNetUsers_UserId5",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId6",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId7",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId8",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId9",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId10",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId11",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId12",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId13",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId14",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId15",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_AspNetUsers_UserId16",
                table: "DeliveryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_DeliveryItem_DeliveryItemId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryItem",
                table: "DeliveryItem");

            migrationBuilder.RenameTable(
                name: "DeliveryItem",
                newName: "Deliveries");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId16",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId16");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId15",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId15");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId14",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId14");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId13",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId13");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId12",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId12");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId11",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId11");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId10",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId10");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId9",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId9");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId8",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId8");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId7",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId7");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId6",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId6");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryItem_UserId5",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId5");

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
                name: "FK_Photos_Deliveries_DeliveryItemId",
                table: "Photos",
                column: "DeliveryItemId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
