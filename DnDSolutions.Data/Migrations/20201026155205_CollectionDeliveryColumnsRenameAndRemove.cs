using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class CollectionDeliveryColumnsRenameAndRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionDateEarliest",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "CollectionDateLatest",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "DeliveryDateEarliest",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "DeliveryDateLatest",
                table: "DeliveryItem");

            migrationBuilder.AddColumn<DateTime>(
                name: "CollectionDate",
                table: "DeliveryItem",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "DeliveryItem",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionDate",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "DeliveryItem");

            migrationBuilder.AddColumn<DateTime>(
                name: "CollectionDateEarliest",
                table: "DeliveryItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CollectionDateLatest",
                table: "DeliveryItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDateEarliest",
                table: "DeliveryItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDateLatest",
                table: "DeliveryItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
