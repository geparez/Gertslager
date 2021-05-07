using Microsoft.EntityFrameworkCore.Migrations;

namespace Gertslager.Data.Migrations
{
    public partial class HallsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cooling = table.Column<bool>(nullable: false),
                    Nummer = table.Column<int>(nullable: false),
                    Antal_rækker = table.Column<int>(nullable: false),
                    Beskrivelse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Halls");
        }
    }
}
