using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDeleteRecipeProductions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productions_Recipes_receipeId",
                table: "Productions");

            migrationBuilder.DropIndex(
                name: "IX_Productions_receipeId",
                table: "Productions");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Recipes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Productions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_name",
                table: "Recipes",
                column: "name",
                unique: true,
                filter: "[name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Productions_name",
                table: "Productions",
                column: "name",
                unique: true,
                filter: "[name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Productions_recipeId",
                table: "Productions",
                column: "recipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productions_Recipes_recipeId",
                table: "Productions",
                column: "recipeId",
                principalTable: "Recipes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productions_Recipes_recipeId",
                table: "Productions");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_name",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Productions_name",
                table: "Productions");

            migrationBuilder.DropIndex(
                name: "IX_Productions_recipeId",
                table: "Productions");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Productions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9270), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9329), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Productions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9499), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9462), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9445), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9411), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9417), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9423), new DateTime(2024, 11, 8, 6, 50, 41, 60, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.CreateIndex(
                name: "IX_Productions_receipeId",
                table: "Productions",
                column: "receipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productions_Recipes_receipeId",
                table: "Productions",
                column: "receipeId",
                principalTable: "Recipes",
                principalColumn: "id");
        }
    }
}
