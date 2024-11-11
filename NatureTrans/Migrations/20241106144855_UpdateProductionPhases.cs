using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductionPhases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(304), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(575), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(505), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(487) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6079), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6247), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6269), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6187), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6197), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6204) });
        }
    }
}
