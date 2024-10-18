using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureTrans.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductAndRoleTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_roleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_userId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_userId",
                table: "UserRole",
                newName: "IX_UserRole_userId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_roleId",
                table: "UserRole",
                newName: "IX_UserRole_roleId");

            migrationBuilder.AddColumn<int>(
                name: "roleId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                column: "id");

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
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 10, 12, 12, 56, 52, 644, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_roleId",
                table: "Products",
                column: "roleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Roles_roleId",
                table: "Products",
                column: "roleId",
                principalTable: "Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Roles_roleId",
                table: "UserRole",
                column: "roleId",
                principalTable: "Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Users_userId",
                table: "UserRole",
                column: "userId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Roles_roleId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Roles_roleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Users_userId",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_Products_roleId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "roleId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_userId",
                table: "UserRoles",
                newName: "IX_UserRoles_userId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_roleId",
                table: "UserRoles",
                newName: "IX_UserRoles_roleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "id");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9148), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9114), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 10, 12, 12, 41, 16, 783, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_roleId",
                table: "UserRoles",
                column: "roleId",
                principalTable: "Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_userId",
                table: "UserRoles",
                column: "userId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
