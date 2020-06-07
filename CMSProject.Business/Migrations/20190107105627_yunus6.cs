using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSProject.Business.Migrations
{
    public partial class yunus6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "PostImages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "PostImages");
        }
    }
}
