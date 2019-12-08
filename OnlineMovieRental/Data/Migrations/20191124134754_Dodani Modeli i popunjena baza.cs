using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieRental.Data.Migrations
{
    public partial class DodaniModeliipopunjenabaza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembershipTypes",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SignUpFee = table.Column<short>(nullable: false),
                    DurationInMonths = table.Column<byte>(nullable: false),
                    DiscountRate = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    GenreId = table.Column<byte>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    NumberInStock = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    IsSubscribedToNewsletter = table.Column<bool>(nullable: false),
                    MembershipTypeId = table.Column<byte>(nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_MembershipTypes_MembershipTypeId",
                        column: x => x.MembershipTypeId,
                        principalTable: "MembershipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Action" },
                    { (byte)2, "Adventure" },
                    { (byte)3, "Comedy" },
                    { (byte)4, "Fantasy" },
                    { (byte)5, "Family" },
                    { (byte)6, "Horror" },
                    { (byte)7, "Mystery" },
                    { (byte)8, "Romance" }
                });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "DiscountRate", "DurationInMonths", "Name", "SignUpFee" },
                values: new object[,]
                {
                    { (byte)1, (byte)0, (byte)0, "Pay as You Go", (short)0 },
                    { (byte)2, (byte)10, (byte)1, "Monthly", (short)30 },
                    { (byte)3, (byte)50, (byte)3, "Quarterly", (short)90 },
                    { (byte)4, (byte)20, (byte)12, "Annual", (short)300 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateAdded", "GenreId", "Name", "NumberInStock", "ReleaseDate" },
                values: new object[,]
                {
                    { 6, new DateTime(2019, 11, 24, 14, 47, 53, 886, DateTimeKind.Local).AddTicks(3719), (byte)1, "Captain Marvel", (byte)50, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 11, 24, 14, 47, 53, 886, DateTimeKind.Local).AddTicks(3597), (byte)2, "The Kid Who Would Be King", (byte)30, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2019, 11, 24, 14, 47, 53, 886, DateTimeKind.Local).AddTicks(3708), (byte)3, "What Men Want", (byte)30, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2019, 11, 24, 14, 47, 53, 886, DateTimeKind.Local).AddTicks(3714), (byte)4, "Alita: Battle Angel", (byte)20, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2019, 11, 24, 14, 47, 53, 886, DateTimeKind.Local).AddTicks(3694), (byte)5, "The Lego Movie 2: The Second Part", (byte)40, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2019, 11, 24, 14, 47, 53, 881, DateTimeKind.Local).AddTicks(5916), (byte)7, "Glass", (byte)10, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "MembershipTypes");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
