using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Web;
using System.DirectoryServices;
using System.Threading;
using System.Windows.Forms;
using NatureTrans.Types;
using Microsoft.Extensions.Logging;

namespace NatureTrans.Data
{
    internal class NTContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Production> Productions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=NTDB;")
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                    e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).updatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).createdAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<Product>()
                .Property(e => e.prodState)
                .HasColumnType("varchar (10)");
            modelBuilder.Entity<Product>()
                .Property(e => e.prodState)
                .HasConversion<string>(
                v => Enum.GetName(typeof(Product.ProdState), v),
                v => (Product.ProdState)Enum.Parse(typeof(Product.ProdState), v));
            modelBuilder.Entity<Recipe>()
                .HasIndex(r => r.name)
                .IsUnique();
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.recipeId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<RecipeIngredient>()
                .Property(e => e.ingredient_unit)
                .HasConversion<string>(
                    v => Enum.GetName(typeof(Unit), v),
                    v => (Unit)Enum.Parse(typeof(Unit), v));
            modelBuilder.Entity<Production>()
                .HasOne(pr => pr.Recipe)
                .WithMany(r => r.Productions)
                .HasForeignKey(pr => pr.recipeId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Production>()
                .HasIndex(p => p.name)
                .IsUnique();
            modelBuilder.Entity<Production>()
                .Property(e => e.prod_unit)
                .HasConversion<string>(
                    v => Enum.GetName(typeof(Unit), v),
                    v => (Unit)Enum.Parse(typeof(Unit), v));
            modelBuilder.Entity<Production>()
                .Property(e => e.prod_unit)
                .HasConversion<string>(
                    v => Enum.GetName(typeof(Unit), v),
                    v => (Unit)Enum.Parse(typeof(Unit), v));

            // Empty existing tables
            modelBuilder.Entity<Role>().HasData(Enumerable.Empty<Role>());
            modelBuilder.Entity<User>().HasData(Enumerable.Empty<User>());
            modelBuilder.Entity<Product>().HasData(Enumerable.Empty<Product>());
            modelBuilder.Entity<Provider>().HasData(Enumerable.Empty<Provider>());
            modelBuilder.Entity<Category>().HasData(Enumerable.Empty<Category>());
            modelBuilder.Entity<Production>().HasData(Enumerable.Empty<Production>());
            modelBuilder.Entity<Recipe>().HasData(Enumerable.Empty<Recipe>());
            //modelBuilder.Entity<PurchaseOrder>().HasData(Enumerable.Empty<PurchaseOrder>());

            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, name = "Matières premières", active = true },
                new Category { id = 2, name = "Ingredients", active = true },
                new Category { id = 3, name = "Outils", active = true }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { id = 1, name = "Admin", active = true },
                new Role { id = 2, name = "Vendor", active = true },
                new Role { id = 3, name = "Tech", active = true },
                new Role { id = 4, name = "User", active = true }
            );


            modelBuilder.Entity<Provider>().HasData(
                new Provider { id = 1, name = "ACRA", address = "Autoroute de delmas 2333, Port-au-prince,Haiti", active = true },
                new Provider { id = 2, name = "Delimart", address = "Autoroute de delmas 1111, Port-au-prince,Haiti", active = true }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { id = 1, categoryId = 1, name = "Sucre Blanc", description = "Sac de 50Kg", prodState = Product.ProdState.Good }
            );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { id = 1, name = "Sirop saveur cerise", description = "12 grammes de sucre blanc, 1 gallon d'eau, 2 sacs de cerise" }
            );

            modelBuilder.Entity<Production>().HasData(
                new Production { id = 1, recipeId = 1, name = "Gallon de sirop cerise", price = 20.80, prod_quantity = 100, prod_unit = Unit.gallon, description = "Production de 20 gallons de sirop, saveur cerise" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
