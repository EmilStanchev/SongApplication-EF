using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SongApplication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BasicSeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "CreatedAt", "Duration", "ReleaseDate", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { "33db3045-889f-4738-8287-54fb0fb88e47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.46m, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mockingbird", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "471938f3-7e18-45cf-b685-7df9b2a456b4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.50m, new DateTime(2010, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lose Yourself", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "62bbe71f-b1f5-4df0-93da-6ed8730ed02e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.44m, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hangover", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "e178ed6e-41b8-4e6a-bb2b-2a633f9057bd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.43m, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Be Somebody", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "e2b697b4-00d5-414c-8018-1018364393d3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.26m, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whistle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "33db3045-889f-4738-8287-54fb0fb88e47");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "471938f3-7e18-45cf-b685-7df9b2a456b4");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "62bbe71f-b1f5-4df0-93da-6ed8730ed02e");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "e178ed6e-41b8-4e6a-bb2b-2a633f9057bd");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "e2b697b4-00d5-414c-8018-1018364393d3");
        }
    }
}
