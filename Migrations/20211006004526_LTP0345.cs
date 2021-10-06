using Microsoft.EntityFrameworkCore.Migrations;

namespace LuuThiPhuong345.Migrations
{
    public partial class LTP0345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LTP0345",
                columns: table => new
                {
                    LTPId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LTPName = table.Column<string>(type: "TEXT", nullable: true),
                    LTPGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LTP0345", x => x.LTPId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LTP0345");
        }
    }
}
