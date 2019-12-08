using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieRental.Data.Migrations
{
    public partial class DodavanjeNumberAvailable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "NumberAvailable",
                table: "Movies",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 18, 11, 44, 582, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 18, 11, 44, 588, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 18, 11, 44, 588, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 18, 11, 44, 588, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 18, 11, 44, 588, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 18, 11, 44, 588, DateTimeKind.Local).AddTicks(818));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberAvailable",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 17, 56, 10, 833, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 17, 56, 10, 843, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 17, 56, 10, 843, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 17, 56, 10, 843, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 17, 56, 10, 843, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2019, 11, 25, 17, 56, 10, 843, DateTimeKind.Local).AddTicks(953));
        }
    }
}
