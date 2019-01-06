using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Meats.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "meats",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Origin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DishId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meats", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "meats");
        }
    }
}
