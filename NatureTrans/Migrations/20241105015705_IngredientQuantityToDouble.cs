using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class IngredientQuantityToDouble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ingredient_qty",
                table: "RecipeIngredients",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ingredient_qty",
                table: "RecipeIngredients",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3747), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3947), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3876), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3879), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 11, 4, 18, 31, 0, 687, DateTimeKind.Local).AddTicks(3882) });
        }
    }
}
