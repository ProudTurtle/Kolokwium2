using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kolokwium2.Migrations
{
    public partial class dodanowartoscidotabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMusicAlbum",
                table: "Track",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMusicLabel",
                table: "Album",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "IdAlbum", "AlbumName", "IdMusicLabel", "MusicLabelIdMusicLabel", "PublishDate" },
                values: new object[] { 1, "Kotki dwa", 1, null, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MusicLabel",
                columns: new[] { "IdMusicLabel", "Name" },
                values: new object[] { 1, "Kotkowa" });

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "IdMusician", "FirstName", "LastName", "Nickname" },
                values: new object[] { 1, "Ala", "Kot", "SłodkiKotek" });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "IdTrack", "AlbumIdAlbum", "Duration", "IdMusicAlbum", "TrackName" },
                values: new object[] { 1, null, 3.5, 1, "Ładne kotki" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "IdAlbum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicLabel",
                keyColumn: "IdMusicLabel",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "IdMusician",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "IdTrack",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IdMusicAlbum",
                table: "Track");

            migrationBuilder.DropColumn(
                name: "IdMusicLabel",
                table: "Album");
        }
    }
}
