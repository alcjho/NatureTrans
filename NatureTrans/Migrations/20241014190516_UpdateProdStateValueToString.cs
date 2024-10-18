using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProdStateValueToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9654), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9636), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9640), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9598), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 10, 14, 15, 5, 16, 227, DateTimeKind.Local).AddTicks(9610) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9736), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9847), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9855), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9858), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9859) });
        }
    }
}
