using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Species = table.Column<string>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
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
                    Name = table.Column<string>(nullable: false),
                    Species = table.Column<string>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
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
                    { 1, "2", "Male", "Pippen", "Persian" },
                    { 9, "3", "Male", "Snuffs", "Ragdoll" },
                    { 8, "1", "Female", "Jay", "Siamese" },
                    { 7, "6", "Female", "Puki", "Bengal" },
                    { 6, "6", "Male", "Mittens", "Persian" },
                    { 10, "1", "Female", "Kinko", "Maine Coon" },
                    { 4, "3", "Male", "Niko", "Ragdoll" },
                    { 3, "1", "Female", "Nala", "Siamese" },
                    { 2, "1", "Female", "May", "Bengal" },
                    { 5, "4", "Female", "Simba", "Maine Coon" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 9, "3", "Male", "Mr.Pebbles", "Siberian Husky" },
                    { 1, "4", "Male", "Leith", "Beagle" },
                    { 2, "1", "Female", "Marry", "Poodle" },
                    { 3, "6", "Female", "Nakita", "German Shepherd" },
                    { 4, "7", "Male", "Apollo", "Siberian Husky" },
                    { 5, "5", "Female", "Ava", "German Shepherd" },
                    { 6, "4", "Male", "Link", "Beagle" },
                    { 7, "5", "Female", "Larry", "Poodle" },
                    { 8, "7", "Female", "Tiger", "German Shepherd" },
                    { 10, "3", "male", "Rex", "German Shepherd" }
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
