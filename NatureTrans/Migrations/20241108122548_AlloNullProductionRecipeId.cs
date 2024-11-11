using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class AlloNullProductionRecipeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "recipeId",
                table: "Productions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(368), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(420), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(592), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(569), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(553) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "recipeId",
                table: "Productions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4444), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4715), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4656), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4695), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4626), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4629), new DateTime(2024, 11, 8, 7, 8, 45, 233, DateTimeKind.Local).AddTicks(4630) });
        }
    }
}
