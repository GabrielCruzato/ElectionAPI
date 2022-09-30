using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Election.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PoliticiansNumber",
                table: "politician");

            migrationBuilder.AddColumn<int>(
                name: "PoliticianId",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Person_PoliticianId",
                table: "Person",
                column: "PoliticianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_politician_PoliticianId",
                table: "Person",
                column: "PoliticianId",
                principalTable: "politician",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_politician_PoliticianId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_PoliticianId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PoliticianId",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "PoliticiansNumber",
                table: "politician",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
