using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class updateProductReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "roleId",
                table: "Products");

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "categoryId", "createdAt", "description", "name", "prodState", "quantity", "reference", "stock_value", "updatedAt" },
                values: new object[] { 1, 1, new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7376), "Sac de 50Kg", "Sucre Blanc", 0, null, null, null, new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7377) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "roleId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5818), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5946), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5952), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5955), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5958), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5959) });
        }
    }
}
