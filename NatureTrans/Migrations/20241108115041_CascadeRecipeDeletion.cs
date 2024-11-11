using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class CascadeRecipeDeletion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_RecipeIngredients_recipeId",
                table: "RecipeIngredients",
                column: "recipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipes_recipeId",
                table: "RecipeIngredients",
                column: "recipeId",
                principalTable: "Recipes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipes_recipeId",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_recipeId",
                table: "RecipeIngredients");

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
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6682), new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6683) });

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
    }
}
