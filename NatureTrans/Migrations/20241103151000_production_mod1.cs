using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class production_mod1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                column: "recipeId",
                value: 1);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(759), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                column: "recipeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(953), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(905), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(908), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 11, 3, 10, 6, 22, 174, DateTimeKind.Local).AddTicks(912) });
        }
    }
}
