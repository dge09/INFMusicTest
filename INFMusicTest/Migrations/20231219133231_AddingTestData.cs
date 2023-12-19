using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace INFMusicTest.Migrations
{
    /// <inheritdoc />
    public partial class AddingTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "Name" },
                values: new object[,]
                {
                    { 10, "BoyWithUke" },
                    { 11, "21 Pilots" },
                    { 12, "Marilyn Manson" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingID", "TakenFrom", "TakenSince", "TakenTill" },
                values: new object[,]
                {
                    { 1, "Dominik", new DateOnly(2023, 12, 19), new DateOnly(2023, 12, 21) },
                    { 2, "IdontKnow", new DateOnly(2023, 12, 19), new DateOnly(2023, 12, 27) }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Name" },
                values: new object[,]
                {
                    { 1, "Pop" },
                    { 2, "Soft Rock" },
                    { 3, "Hard Rock" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "OfferID", "Availability", "SongID" },
                values: new object[,]
                {
                    { 1, true, 1 },
                    { 2, true, 2 },
                    { 3, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongID", "AuthorID", "GenreID", "ReleaseDate", "SongLength", "Title" },
                values: new object[,]
                {
                    { 1, 10, 1, new DateOnly(2023, 12, 19), 278, "Toxic" },
                    { 2, 11, 2, new DateOnly(2023, 12, 19), 278, "Migrane" },
                    { 3, 12, 3, new DateOnly(2023, 12, 19), 278, "Mobscene" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "OfferID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "OfferID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "OfferID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 3);
        }
    }
}
