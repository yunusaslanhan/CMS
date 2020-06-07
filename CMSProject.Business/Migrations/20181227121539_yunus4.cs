using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSProject.Business.Migrations
{
    public partial class yunus4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostImage",
                table: "Posts",
                newName: "PostPhoto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostPhoto",
                table: "Posts",
                newName: "PostImage");
        }
    }
}
