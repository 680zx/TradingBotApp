using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingBotApp.Migrations
{
    public partial class version_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MarketTools",
                table: "MarketTools");

            migrationBuilder.RenameColumn(
                name: "MarketQualifierID",
                table: "MarketTools",
                newName: "MarketConditionQualifierID");

            migrationBuilder.AlterColumn<int>(
                name: "MarketConditionQualifierID",
                table: "MarketTools",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MarketToolID",
                table: "MarketTools",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarketTools",
                table: "MarketTools",
                column: "MarketToolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MarketTools",
                table: "MarketTools");

            migrationBuilder.DropColumn(
                name: "MarketToolID",
                table: "MarketTools");

            migrationBuilder.RenameColumn(
                name: "MarketConditionQualifierID",
                table: "MarketTools",
                newName: "MarketQualifierID");

            migrationBuilder.AlterColumn<int>(
                name: "MarketQualifierID",
                table: "MarketTools",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarketTools",
                table: "MarketTools",
                column: "MarketQualifierID");
        }
    }
}
