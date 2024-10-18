using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class seedChilds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "active", "createdAt", "name", "updatedAt" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(8951), "Matières premières", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(8998) },
                    { 2, true, new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9001), "Ingredients", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9002) },
                    { 3, true, new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9004), "Outils", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9005) }
                });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "id", "active", "address", "createdAt", "name", "updatedAt" },
                values: new object[,]
                {
                    { 1, true, "Autoroute de delmas 2333, Port-au-prince,Haiti", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9143), "ACRA", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9144) },
                    { 2, true, "Autoroute de delmas 1111, Port-au-prince,Haiti", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9148), "Delimart", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9149) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "name", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9114), "Admin", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "Userid", "active", "createdAt", "name", "updatedAt" },
                values: new object[,]
                {
                    { 2, null, true, new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9119), "Vendor", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9120) },
                    { 3, null, true, new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9122), "Tech", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9123) },
                    { 4, null, true, new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9125), "User", new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9126) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "name", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 11, 42, 33, 240, DateTimeKind.Local).AddTicks(9612), "admin", new DateTime(2024, 10, 11, 11, 42, 33, 240, DateTimeKind.Local).AddTicks(9665) });
        }
    }
}
