using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class OptionalUnitAndPhase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "prod_unit",
                table: "Productions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "prod_state",
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
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7684), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "prod_state", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(8208), null, new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7993), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7960), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7968), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(8045), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7919), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7927), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7931), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7934), new DateTime(2024, 11, 11, 13, 45, 58, 512, DateTimeKind.Local).AddTicks(7936) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "prod_unit",
                table: "Productions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "prod_state",
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
                columns: new[] { "createdAt", "prod_state", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(636), 0, new DateTime(2024, 11, 8, 7, 25, 47, 960, DateTimeKind.Local).AddTicks(637) });

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
    }
}
