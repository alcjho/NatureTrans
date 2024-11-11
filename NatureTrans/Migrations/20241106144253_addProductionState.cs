using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class addProductionState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "prod_state",
                table: "Productions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "createdAt", "prod_state", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6289), 0, new DateTime(2024, 11, 6, 9, 42, 53, 264, DateTimeKind.Local).AddTicks(6290) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prod_state",
                table: "Productions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 253, DateTimeKind.Local).AddTicks(9847), new DateTime(2024, 11, 4, 20, 57, 5, 253, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 253, DateTimeKind.Local).AddTicks(9906), new DateTime(2024, 11, 4, 20, 57, 5, 253, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 253, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 11, 4, 20, 57, 5, 253, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(44), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(49), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(28), new DateTime(2024, 11, 4, 20, 57, 5, 254, DateTimeKind.Local).AddTicks(29) });
        }
    }
}
