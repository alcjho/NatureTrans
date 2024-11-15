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
    [Migration("20241027015911_AddReceivedToPurchaseOrder")]
    partial class AddReceivedToPurchaseOrder
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
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4574),
                            name = "Matières premières",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4626)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4630),
                            name = "Ingredients",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4631)
                        },
                        new
                        {
                            id = 3,
                            active = true,
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4633),
                            name = "Outils",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4634)
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

                    b.Property<string>("prodState")
                        .HasColumnType("varchar (10)");

                    b.Property<int>("quantity")
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
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4877),
                            description = "Sac de 50Kg",
                            name = "Sucre Blanc",
                            prodState = "Good",
                            quantity = 0,
                            reference = "",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4878)
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
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4855),
                            name = "ACRA",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4856)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            address = "Autoroute de delmas 1111, Port-au-prince,Haiti",
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4861),
                            name = "Delimart",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4862)
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

                    b.Property<bool>("received")
                        .HasColumnType("bit");

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
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4821),
                            name = "Admin",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4823)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4828),
                            name = "Vendor",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4829)
                        },
                        new
                        {
                            id = 3,
                            active = true,
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4831),
                            name = "Tech",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4832)
                        },
                        new
                        {
                            id = 4,
                            active = true,
                            createdAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4833),
                            name = "User",
                            updatedAt = new DateTime(2024, 10, 26, 21, 59, 10, 631, DateTimeKind.Local).AddTicks(4834)
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
