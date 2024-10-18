using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class addedMessageBoxLoggging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(8815), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(8966), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(8968), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9063), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9068), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9074), new DateTime(2024, 10, 14, 9, 39, 40, 461, DateTimeKind.Local).AddTicks(9075) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 10, 14, 9, 33, 25, 378, DateTimeKind.Local).AddTicks(9830) });

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
    }
}
