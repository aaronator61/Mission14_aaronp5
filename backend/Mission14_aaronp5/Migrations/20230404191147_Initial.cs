using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission14_aaronp5.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Category = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Title = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Year = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Director = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Rating = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Edited = table.Column<byte[]>(type: "BLOB", nullable: true),
                    LentTo = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Notes = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
