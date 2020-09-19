using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDSolutions.Data.Migrations
{
    public partial class AmountColumnType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Bids",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Bids",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
