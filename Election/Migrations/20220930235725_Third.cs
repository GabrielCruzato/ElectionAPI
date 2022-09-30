using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Election.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_politician_PoliticianId",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_politician",
                table: "politician");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "politician",
                newName: "Politicians");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Voters");

            migrationBuilder.RenameIndex(
                name: "IX_Person_PoliticianId",
                table: "Voters",
                newName: "IX_Voters_PoliticianId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Politicians",
                table: "Politicians",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voters",
                table: "Voters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Politicians_PoliticianId",
                table: "Voters",
                column: "PoliticianId",
                principalTable: "Politicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Politicians_PoliticianId",
                table: "Voters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voters",
                table: "Voters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Politicians",
                table: "Politicians");

            migrationBuilder.RenameTable(
                name: "Voters",
                newName: "Person");

            migrationBuilder.RenameTable(
                name: "Politicians",
                newName: "politician");

            migrationBuilder.RenameIndex(
                name: "IX_Voters_PoliticianId",
                table: "Person",
                newName: "IX_Person_PoliticianId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_politician",
                table: "politician",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_politician_PoliticianId",
                table: "Person",
                column: "PoliticianId",
                principalTable: "politician",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
