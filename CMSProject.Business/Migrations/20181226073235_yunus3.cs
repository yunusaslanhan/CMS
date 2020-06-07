using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSProject.Business.Migrations
{
    public partial class yunus3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostText",
                table: "Posts",
                newName: "PostTitle");

            migrationBuilder.AddColumn<string>(
                name: "PostDesc",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostImage",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostDesc",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostImage",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostTitle",
                table: "Posts",
                newName: "PostText");
        }
    }
}
