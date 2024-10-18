using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProductOptionalFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
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
                columns: new[] { "createdAt", "quantity", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2742), 0, new DateTime(2024, 10, 14, 15, 29, 31, 618, DateTimeKind.Local).AddTicks(2743) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "createdAt", "quantity", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9513), null, new DateTime(2024, 10, 14, 15, 26, 7, 540, DateTimeKind.Local).AddTicks(9514) });

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
    }
}
