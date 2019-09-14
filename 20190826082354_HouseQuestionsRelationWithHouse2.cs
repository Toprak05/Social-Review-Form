using Microsoft.EntityFrameworkCore.Migrations;

namespace SDKWebPortalWebAPI.Migrations
{
    public partial class HouseQuestionsRelationWithHouse2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HouseQuestions_HouseId",
                table: "HouseQuestions",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseQuestions_House_HouseId",
                table: "HouseQuestions",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseQuestions_House_HouseId",
                table: "HouseQuestions");

            migrationBuilder.DropIndex(
                name: "IX_HouseQuestions_HouseId",
                table: "HouseQuestions");
        }
    }
}
