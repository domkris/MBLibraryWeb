using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MBLibraryWeb.DB.Migrations
{
    public partial class AddedSeedBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Genre", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Robert Louis Stevenson", new DateTime(2022, 1, 13, 21, 32, 50, 39, DateTimeKind.Local).AddTicks(3642), "initialSeedTest", 1, "Treasure Island", null, null },
                    { 16, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4662), "initialSeedTest", 11, "Persepolis Rising", null, null },
                    { 15, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4659), "initialSeedTest", 11, "Babylon's Ashes", null, null },
                    { 14, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4656), "initialSeedTest", 11, "Nemesis Games", null, null },
                    { 13, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4653), "initialSeedTest", 11, "Cibola Burn", null, null },
                    { 12, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4650), "initialSeedTest", 11, "Abaddon's Gate", null, null },
                    { 11, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4646), "initialSeedTest", 11, "Caliban's War", null, null },
                    { 10, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4643), "initialSeedTest", 11, "Leviathan Wakes", null, null },
                    { 9, "J. K. Rowling", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4640), "initialSeedTest", 5, "Harry Potter and the Deathly Hallows", null, null },
                    { 8, "J. K. Rowling", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4637), "initialSeedTest", 5, "Harry Potter and the Half-Blood Prince", null, null },
                    { 7, "J. K. Rowling", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4634), "initialSeedTest", 5, "Harry Potter and the Order of the Phoenix", null, null },
                    { 6, "J. K. Rowling", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4631), "initialSeedTest", 5, "Harry Potter and the Goblet of Fire", null, null },
                    { 5, "J. K. Rowling", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4628), "initialSeedTest", 5, "Harry Potter and the Prisoner of Azkaban", null, null },
                    { 4, "J. K. Rowling", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4625), "initialSeedTest", 5, "Harry Potter and the Chamber of Secrets", null, null },
                    { 3, "J. K. Rowling", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4621), "initialSeedTest", 5, "Harry Potter and the Philosopher's Stone", null, null },
                    { 2, "Steve Martin", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4589), "initialSeedTest", 2, "Born Standing Up", null, null },
                    { 17, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4665), "initialSeedTest", 11, "Tiamat's Wrath", null, null },
                    { 18, "James S. A. Corey", new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4668), "initialSeedTest", 11, "Leviathan Falls", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
