using Microsoft.EntityFrameworkCore.Migrations;

namespace RepoDemoMvc1.DataAcess.Migrations
{
    public partial class dsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Numb",
                table: "Categories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numb",
                table: "Categories");
        }
    }
}
