using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class production_mod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(type: "int", nullable: false),
                    recipeId = table.Column<int>(type: "int", nullable: false),
                    ingredient_unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ingredient_qty = table.Column<int>(type: "int", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recipeId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prod_quantity = table.Column<int>(type: "int", nullable: false),
                    prod_unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    production_value = table.Column<double>(type: "float", nullable: false),
                    stock_value = table.Column<double>(type: "float", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Productions_Recipes_receipeId",
                        column: x => x.receipeId,
                        principalTable: "Recipes",
                        principalColumn: "id");
                });

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

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "id", "description", "name", "price", "prod_quantity", "prod_unit", "production_value", "receipeId", "recipeId", "stock_value" },
                values: new object[] { 1, "Production de 20 gallons de sirop, saveur cerise", "Gallon de sirop cerise", 20.800000000000001, 100, "gallon", 0.0, null, 0, 0.0 });

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

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "id", "description", "name" },
                values: new object[] { 1, "12 grammes de sucre blanc, 1 gallon d'eau, 2 sacs de cerise", "Sirop saveur cerise" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Productions_receipeId",
                table: "Productions",
                column: "receipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productions");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4633), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4828), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4833), new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4834) });
        }
    }
}
