using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSProject.Business.Migrations
{
    public partial class yunus2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LayoutComponents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComponentClass",
                table: "LayoutComponents",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComponentClass",
                table: "LayoutComponents");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LayoutComponents",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
