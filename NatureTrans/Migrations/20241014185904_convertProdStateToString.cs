using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class convertProdStateToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "prodState",
                table: "Products",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9736), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "prodState", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9898), "Good", new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9847), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9855), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9858), new DateTime(2024, 10, 14, 14, 59, 4, 564, DateTimeKind.Local).AddTicks(9859) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "prodState",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8289), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8345), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "prodState", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8490), 0, new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8451), new DateTime(2024, 10, 14, 13, 19, 44, 472, DateTimeKind.Local).AddTicks(8452) });
        }
    }
}
