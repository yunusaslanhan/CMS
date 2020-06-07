using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSProject.Business.Migrations
{
    public partial class yns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "LayoutComponents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "LayoutComponents",
                nullable: false,
                defaultValue: "");
        }
    }
}
