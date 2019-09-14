using Microsoft.EntityFrameworkCore.Migrations;

namespace SDKWebPortalWebAPI.Migrations
{
    public partial class HouseIdAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "PersonelQuestions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "PersonelAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "ObservationQuestions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "ObservationAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "HouseQuestions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "PersonelQuestions");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "PersonelAnswers");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "ObservationQuestions");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "ObservationAnswers");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "HouseQuestions");
        }
    }
}
