using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProdQuantityType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "prod_quantity",
                table: "Productions",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6419), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6480), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6483), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "prod_quantity", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6682), 100.0, new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6643), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6615), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6663), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6587), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6592), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6595), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6597), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6598) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "prod_quantity",
                table: "Productions",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(304), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "prod_quantity", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(575), 100, new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(505), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 11, 6, 9, 48, 55, 304, DateTimeKind.Local).AddTicks(487) });
        }
    }
}
