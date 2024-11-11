using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class extendProduction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "RecipeIngredients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "RecipeIngredients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Productions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "Productions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "Productions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(8999), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9061), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9270), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9211), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9219), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9182), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9193), new DateTime(2024, 11, 3, 10, 10, 0, 430, DateTimeKind.Local).AddTicks(9194) });
        }
    }
}
