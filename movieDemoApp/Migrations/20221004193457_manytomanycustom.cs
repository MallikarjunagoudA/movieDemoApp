using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movieDemoApp.Migrations
{
    public partial class manytomanycustom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "cinemaOffers",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Begin",
                table: "cinemaOffers",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.CreateTable(
                name: "movieActors",
                columns: table => new
                {
                    movieid = table.Column<int>(type: "int", nullable: false),
                    actorid = table.Column<int>(type: "int", nullable: false),
                    character = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieActors", x => new { x.movieid, x.actorid });
                    table.ForeignKey(
                        name: "FK_movieActors_actors_actorid",
                        column: x => x.actorid,
                        principalTable: "actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieActors_movies_movieid",
                        column: x => x.movieid,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_movieActors_actorid",
                table: "movieActors",
                column: "actorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieActors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "cinemaOffers",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Begin",
                table: "cinemaOffers",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);
        }
    }
}
