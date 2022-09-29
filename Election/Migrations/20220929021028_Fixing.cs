using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Election.Migrations
{
    public partial class Fixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PoliticalParty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliticalParty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "politicianModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoliticalPartyId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SexualOrientation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_politicianModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_politicianModels_PoliticalParty_PoliticalPartyId",
                        column: x => x.PoliticalPartyId,
                        principalTable: "PoliticalParty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_politicianModels_PoliticalPartyId",
                table: "politicianModels",
                column: "PoliticalPartyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "politicianModels");

            migrationBuilder.DropTable(
                name: "PoliticalParty");
        }
    }
}
