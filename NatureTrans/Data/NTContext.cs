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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=NTDB;");

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

        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    foreach (var entry in ChangeTracker.Entries<Product>())
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            // Get the last product with a valid reference
        //            var lastProduct = await Products
        //                                  .Where(p => p.reference != null)
        //                                  .OrderByDescending(p => p.reference)
        //                                  .FirstOrDefaultAsync();

        //            int lastNumber = 0;
        //            if (lastProduct != null && lastProduct.reference != null)
        //            {
        //                // Extract numeric part from the reference and increment
        //                var lastRefNumber = lastProduct.reference.Substring(2); // Skip 'NT'
        //                int.TryParse(lastRefNumber, out lastNumber);
        //            }

        //            // If no last product, start from NT0001
        //            var newReferenceNumber = lastNumber + 1;
        //            entry.Entity.reference = $"NT{newReferenceNumber:D4}";
        //            MessageBox.Show($"Generated reference: {entry.Entity.reference}");
        //        }
        //    }


        //    return await base.SaveChangesAsync(cancellationToken);
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Category>()
            //    .HasMany(e => e.Products)
            //    .WithOne()
            //    .HasForeignKey(e => e.categoryId)
            //    .IsRequired(false);
            modelBuilder
                .Entity<Product>()
                .Property(e => e.prodState)
                .HasColumnType("varchar (10)");
            modelBuilder.Entity<Product>()
                .Property(e => e.prodState)
                .HasConversion<string>(
                v => Enum.GetName(typeof(Product.ProdState), v),
                v => (Product.ProdState)Enum.Parse(typeof(Product.ProdState), v));
            //modelBuilder.Entity<UserRole>()
            //    .HasOne(ur => ur.User)
            //    .WithMany()
            //    .HasForeignKey(ur => ur.userId)
            //    .IsRequired(false);
            //modelBuilder.Entity<UserRole>()
            //    .HasOne(ur => ur.Role)
            //    .WithMany()
            //    .HasForeignKey(ur => ur.roleId)
            //    .IsRequired(false);
            //modelBuilder.Entity<User>()
            //    .HasMany(r => r.Roles)
            //    .WithMany()
            //    .UsingEntity<UserRole>();
            //modelBuilder.Entity<PurchaseOrder>()
            //    .HasOne(e => e.Provider)
            //    .WithMany()
            //    .HasForeignKey(e => e.providerId)
            //    .IsRequired(false);
            //modelBuilder.Entity<PurchaseOrder>()
            //    .HasOne(e => e.User)
            //    .WithMany()
            //    .HasForeignKey(e => e.userId)
            //    .IsRequired(false);
            //modelBuilder.Entity<PurchaseOrder>()
            //    .HasOne(e => e.Product)
            //    .WithMany()
            //    .HasForeignKey(e => e.productId)
            //    .OnDelete(DeleteBehavior.Cascade)
            //    .IsRequired(false);


            // Empty existing tables
            modelBuilder.Entity<Role>().HasData(Enumerable.Empty<Role>());
            modelBuilder.Entity<User>().HasData(Enumerable.Empty<User>());
            modelBuilder.Entity<Product>().HasData(Enumerable.Empty<Product>());
            modelBuilder.Entity<Provider>().HasData(Enumerable.Empty<Provider>());
            modelBuilder.Entity<Category>().HasData(Enumerable.Empty<Category>());
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



            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        id = 1,
            //        username = "ajhonny",
            //        email = "louis.jhonny@gmail.com",
            //        password = "pass1234",
            //        saltPassword = "",
            //        hashAlgo = "sha512"
            //    });


            //modelBuilder.Entity<UserRole>().HasData(
            //    new UserRole
            //    {
            //        id = 1,
            //        userId = 1,
            //        roleId = 1,
            //    });




            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        id = 1,
            //        categoryId = 1,
            //        reference = "NT0001",
            //        name = "Sucre Blanc",
            //        quantity = 20,
            //        description = "Sac de 50Kg",
            //        prodState = Product.ProdState.Good
            //    });

            //modelBuilder.Entity<Provider>().HasData(
            //    new Provider
            //    {
            //        id = 1,
            //        name = "ACRA",
            //        address = "Autoroute de delmas 2333, Port-au-prince,Haiti",
            //        active = true
            //    });

            //modelBuilder.Entity<PurchaseOrder>().HasData(
            //    new PurchaseOrder
            //    {
            //        id = 1,
            //        userId = 1,
            //        productId = 1,
            //        providerId = 1,
            //        price = 22.10,
            //        quantity = 20,
            //        comment = "new product from acra factory",
            //    });
            base.OnModelCreating(modelBuilder);
        }
    }
}
