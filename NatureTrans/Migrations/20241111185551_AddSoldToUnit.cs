using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class AddSoldToUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9263), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9455), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9419), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9395), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9438), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9372), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9375), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 11, 11, 13, 55, 50, 848, DateTimeKind.Local).AddTicks(9378) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3079), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3129), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3132), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3317), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3258), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3263), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3299), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3235), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3238), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3241), new DateTime(2024, 11, 11, 13, 53, 18, 618, DateTimeKind.Local).AddTicks(3242) });
        }
    }
}
