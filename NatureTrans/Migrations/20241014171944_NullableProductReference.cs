using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class NullableProductReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8289), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8345), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8451), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8452) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
