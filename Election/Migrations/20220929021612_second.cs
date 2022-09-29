using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Election.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_politicianModels_PoliticalParty_PoliticalPartyId",
                table: "politicianModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PoliticalParty",
                table: "PoliticalParty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_politicianModels",
                table: "politicianModels");

            migrationBuilder.RenameTable(
                name: "PoliticalParty",
                newName: "politicalParty");

            migrationBuilder.RenameTable(
                name: "politicianModels",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_politicianModels_PoliticalPartyId",
                table: "Person",
                newName: "IX_Person_PoliticalPartyId");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PoliticalPartyId",
                table: "Person",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_politicalParty",
                table: "politicalParty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_politicalParty_PoliticalPartyId",
                table: "Person",
                column: "PoliticalPartyId",
                principalTable: "politicalParty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_politicalParty_PoliticalPartyId",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_politicalParty",
                table: "politicalParty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "politicalParty",
                newName: "PoliticalParty");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "politicianModels");

            migrationBuilder.RenameIndex(
                name: "IX_Person_PoliticalPartyId",
                table: "politicianModels",
                newName: "IX_politicianModels_PoliticalPartyId");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "politicianModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PoliticalPartyId",
                table: "politicianModels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                table: "politicianModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "politicianModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoliticalParty",
                table: "PoliticalParty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_politicianModels",
                table: "politicianModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_politicianModels_PoliticalParty_PoliticalPartyId",
                table: "politicianModels",
                column: "PoliticalPartyId",
                principalTable: "PoliticalParty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
