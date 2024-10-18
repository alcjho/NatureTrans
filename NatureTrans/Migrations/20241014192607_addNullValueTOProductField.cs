using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class addNullValueTOProductField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "prodState",
                table: "Products",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9267), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9477), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9455), new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "prodState",
                table: "Products",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "Products",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
