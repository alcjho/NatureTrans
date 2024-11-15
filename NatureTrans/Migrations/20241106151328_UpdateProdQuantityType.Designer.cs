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
    [Migration("20241106151328_UpdateProdQuantityType")]
    partial class UpdateProdQuantityType
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
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6419),
                            name = "Matières premières",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6477)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6480),
                            name = "Ingredients",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6481)
                        },
                        new
                        {
                            id = 3,
                            active = true,
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6483),
                            name = "Outils",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6484)
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
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6643),
                            description = "Sac de 50Kg",
                            name = "Sucre Blanc",
                            prodState = "Good",
                            quantity = 0,
                            reference = "",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6644)
                        });
                });

            modelBuilder.Entity("NatureTrans.Data.Production", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<double>("prod_quantity")
                        .HasColumnType("float");

                    b.Property<int>("prod_state")
                        .HasColumnType("int");

                    b.Property<string>("prod_unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("production_value")
                        .HasColumnType("float");

                    b.Property<int?>("receipeId")
                        .HasColumnType("int");

                    b.Property<int>("recipeId")
                        .HasColumnType("int");

                    b.Property<double>("stock_value")
                        .HasColumnType("float");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("receipeId");

                    b.ToTable("Productions");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6682),
                            description = "Production de 20 gallons de sirop, saveur cerise",
                            name = "Gallon de sirop cerise",
                            price = 20.800000000000001,
                            prod_quantity = 100.0,
                            prod_state = 0,
                            prod_unit = "gallon",
                            production_value = 0.0,
                            recipeId = 1,
                            stock_value = 0.0,
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6683)
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
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6615),
                            name = "ACRA",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6616)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            address = "Autoroute de delmas 1111, Port-au-prince,Haiti",
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6620),
                            name = "Delimart",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6621)
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

            modelBuilder.Entity("NatureTrans.Data.Recipe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6663),
                            description = "12 grammes de sucre blanc, 1 gallon d'eau, 2 sacs de cerise",
                            name = "Sirop saveur cerise",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6665)
                        });
                });

            modelBuilder.Entity("NatureTrans.Data.RecipeIngredient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("ingredient_qty")
                        .HasColumnType("float");

                    b.Property<string>("ingredient_unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("recipeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("RecipeIngredients");
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
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6587),
                            name = "Admin",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6588)
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6592),
                            name = "Vendor",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6593)
                        },
                        new
                        {
                            id = 3,
                            active = true,
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6595),
                            name = "Tech",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6596)
                        },
                        new
                        {
                            id = 4,
                            active = true,
                            createdAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6597),
                            name = "User",
                            updatedAt = new DateTime(2024, 11, 6, 10, 13, 28, 601, DateTimeKind.Local).AddTicks(6598)
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

            modelBuilder.Entity("NatureTrans.Data.Production", b =>
                {
                    b.HasOne("NatureTrans.Data.Recipe", "recipe")
                        .WithMany()
                        .HasForeignKey("receipeId");

                    b.Navigation("recipe");
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
