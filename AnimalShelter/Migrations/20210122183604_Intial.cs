using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 2, "Male", "Pippen", "Persian" },
                    { 2, 1, "Female", "May", "Bengal" },
                    { 3, 1, "Female", "Nala", "Siamese" },
                    { 4, 3, "Male", "Niko", "Ragdoll" },
                    { 5, 4, "Female", "Simba", "Maine Coon" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 4, "Male", "Leith", "Beagle" },
                    { 2, 1, "Female", "Marry", "Poodle" },
                    { 3, 6, "Female", "Nakita", "German Shepherd" },
                    { 4, 7, "Male", "Apollo", "Siberian Husky" },
                    { 5, 5, "Female", "Ava", "German Shepherd" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
