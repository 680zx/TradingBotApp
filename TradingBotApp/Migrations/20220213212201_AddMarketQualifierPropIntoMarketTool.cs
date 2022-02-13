using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingBotApp.Migrations
{
    public partial class AddMarketQualifierPropIntoMarketTool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarketConditionQualifierID",
                table: "MarketTools");

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "MarketTools",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MarketQualifierSettingsJson",
                table: "MarketTools",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarketQualifierSettingsJson",
                table: "MarketTools");

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "MarketTools",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "MarketConditionQualifierID",
                table: "MarketTools",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
