using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieRental.Data.Migrations
{
    public partial class FinalniDBxontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthdate", "IsSubscribedToNewsletter", "MembershipTypeId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)2, "Kenan Sabanovic" },
                    { 2, new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)3, "Faik Muslic" },
                    { 3, new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)1, "Muris Cengic" },
                    { 4, new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)2, "Enes Kapetanovic" },
                    { 5, new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)2, "Testni Kupac" },
                    { 6, new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)2, "Testni Kupac2" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumberAvailable",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumberAvailable",
                value: (byte)30);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumberAvailable",
                value: (byte)40);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "NumberAvailable",
                value: (byte)30);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "NumberAvailable",
                value: (byte)20);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "NumberAvailable",
                value: (byte)50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumberAvailable",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumberAvailable",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumberAvailable",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "NumberAvailable",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "NumberAvailable",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "NumberAvailable",
                value: (byte)0);
        }
    }
}
