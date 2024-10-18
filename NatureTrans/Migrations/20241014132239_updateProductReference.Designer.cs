﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NatureTrans.Data;

#nullable disable

namespace NatureTrans.Migrations
{
    [DbContext(typeof(NTContext))]
    [Migration("20241014132239_updateProductReference")]
    partial class updateProductReference
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NatureTrans.Data.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            active = true,
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7052),
                            name = "Matières premières",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7107)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7117),
                            name = "Ingredients",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7118)
                        },
                        new
                        {
                            id = 3,
                            active = true,
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7121),
                            name = "Outils",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7123)
                        });
                });

            modelBuilder.Entity("NatureTrans.Data.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("prodState")
                        .HasColumnType("int");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("reference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("stock_value")
                        .HasColumnType("float");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            categoryId = 1,
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7376),
                            description = "Sac de 50Kg",
                            name = "Sucre Blanc",
                            prodState = 0,
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7377)
                        });
                });

            modelBuilder.Entity("NatureTrans.Data.Provider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Providers");

                    b.HasData(
                        new
                        {
                            id = 1,
                            active = true,
                            address = "Autoroute de delmas 2333, Port-au-prince,Haiti",
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7342),
                            name = "ACRA",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7344)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            address = "Autoroute de delmas 1111, Port-au-prince,Haiti",
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7354),
                            name = "Delimart",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7355)
                        });
                });

            modelBuilder.Entity("NatureTrans.Data.PurchaseOrder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("providerId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productId");

                    b.HasIndex("providerId");

                    b.HasIndex("userId");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("NatureTrans.Data.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            id = 1,
                            active = true,
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7301),
                            name = "Admin",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7303)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7308),
                            name = "Vendor",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7310)
                        },
                        new
                        {
                            id = 3,
                            active = true,
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7312),
                            name = "Tech",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7314)
                        },
                        new
                        {
                            id = 4,
                            active = true,
                            createdAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7316),
                            name = "User",
                            updatedAt = new DateTime(2024, 10, 14, 9, 22, 39, 418, DateTimeKind.Local).AddTicks(7317)
                        });
                });

            modelBuilder.Entity("NatureTrans.Data.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hashAlgo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isLogged")
                        .HasColumnType("bit");

                    b.Property<DateTime>("lastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("saltPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NatureTrans.Data.Product", b =>
                {
                    b.HasOne("NatureTrans.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NatureTrans.Data.PurchaseOrder", b =>
                {
                    b.HasOne("NatureTrans.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NatureTrans.Data.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("providerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NatureTrans.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Provider");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NatureTrans.Data.User", b =>
                {
                    b.HasOne("NatureTrans.Data.Role", "Role")
                        .WithMany()
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
