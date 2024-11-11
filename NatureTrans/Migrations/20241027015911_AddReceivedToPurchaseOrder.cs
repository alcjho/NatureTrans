using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class AddReceivedToPurchaseOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "received",
                table: "PurchaseOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4633), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4828), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4833), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4834) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "received",
                table: "PurchaseOrders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2525), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2579), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2582), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2742), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2721), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2727), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2691), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2698), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2700), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2703), new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2704) });
        }
    }
}
