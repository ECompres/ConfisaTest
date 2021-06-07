using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfisaTest.Migrations
{
    public partial class idOficialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idOficial",
                table: "Dealers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idOficial",
                table: "Dealers");
        }
    }
}
