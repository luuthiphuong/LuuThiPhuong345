using Microsoft.EntityFrameworkCore.Migrations;

namespace LuuThiPhuong345.Migrations
{
    public partial class PersonLTP345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonLTP345",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonLTP345", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonLTP345");
        }
    }
}
