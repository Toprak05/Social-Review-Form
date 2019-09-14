using Microsoft.EntityFrameworkCore.Migrations;

namespace SDKWebPortalWebAPI.Migrations
{
    public partial class InitialCreateUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_TC",
                table: "FamilyMembers",
                column: "TC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_TC",
                table: "FamilyMembers");
        }
    }
}
