using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class updateRoleAndProduct2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Roles_roleId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_Userid",
                table: "Roles");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Userid",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Products_roleId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Roles");

            migrationBuilder.AddColumn<int>(
                name: "roleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5818), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5946), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5952), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5955), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5958), new DateTime(2024, 10, 12, 13, 35, 21, 418, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_roleId",
                table: "Users",
                column: "roleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_roleId",
                table: "Users",
                column: "roleId",
                principalTable: "Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_roleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_roleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "roleId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserRole_Roles_roleId",
                        column: x => x.roleId,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8173), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8249), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8556), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Userid", "createdAt", "updatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Userid", "createdAt", "updatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Userid", "createdAt", "updatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Userid", "createdAt", "updatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Userid",
                table: "Roles",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_roleId",
                table: "Products",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_roleId",
                table: "UserRole",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_userId",
                table: "UserRole",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Roles_roleId",
                table: "Products",
                column: "roleId",
                principalTable: "Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_Userid",
                table: "Roles",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id");
        }
    }
}
