using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class EmptyProductReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "reference", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9829), "", new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9803), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9815), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9775), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9786), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9787) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "reference", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7376), null, new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7354), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7301), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7316), new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7317) });
        }
    }
}
