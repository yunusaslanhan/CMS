using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSProject.Business.Migrations
{
    public partial class yunus5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainPageId",
                table: "Posts",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MainPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_MainPageId",
                table: "Posts",
                column: "MainPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_MainPages_MainPageId",
                table: "Posts",
                column: "MainPageId",
                principalTable: "MainPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_MainPages_MainPageId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "MainPages");

            migrationBuilder.DropIndex(
                name: "IX_Posts_MainPageId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "MainPageId",
                table: "Posts");
        }
    }
}
