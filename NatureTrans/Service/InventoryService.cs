using Microsoft.EntityFrameworkCore;
using NatureTrans.Data;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;

namespace NatureTrans.Service
{
    internal class InventoryService
    {
        private readonly NTContext _context;
        public InventoryService(NTContext context)
        {
            _context = context;
        }

        public List<Product> getProductList(int startIndex, int pageSize)
        {
            var query = from product in _context.Products
                        join category in _context.Categories on product.categoryId equals category.id
                        where category.active == true
                        orderby product.id
                        select product; // or select new { roduct.name, category.active 
                        
            var productList = query.ToList();

            return productList;
        }

        

        public async Task<int> AddProduct(Product product)
        {
            try
            {
                // Validate product data (ensure required fields are not null or empty)
                if (string.IsNullOrWhiteSpace(product.name)
                    && typeof(Product).GetProperty("categoryId") != null 
                    && product.GetType().GetProperty("categoryId").GetValue(product) != null
                    && Enum.IsDefined(typeof(Product.ProdState), product.prodState))
                {
                    Console.Error.WriteLine($"Wrong product - should have a name, a category and a state");
                    return -2;
                }

                // Check if product already exists by name
                var existingProduct = await _context.Products.FirstOrDefaultAsync(p => p.name == product.name);
                if (existingProduct != null)
                {
                    return 0;
                }

                // Add the product to the context
                await _context.Products.AddAsync(product);

                // Save changes to the database
                await _context.SaveChangesAsync();

                return 1;
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully (log errors, rethrow)
                Console.Error.WriteLine($"Error adding {product}: {ex.Message}");
                return -1; // Error occurred
            }
        }

        public async Task<int> UpdateProduct(Product product)
        {
            try
            {
                // Ensure product has an ID for update
                if (product.id == 0)
                {
                    return 0; // Product not found
                }

                // Find the product to update by its ID
                var existingProduct = await _context.Products.FindAsync(product.id);

                // Check if product exists
                if (existingProduct == null)
                {
                    return 0; // Product not found
                }

                // Update existing product properties
                existingProduct.name = product.name;
                existingProduct.prodState = product.prodState;
                existingProduct.description = product.description;
                existingProduct.quantity = product.quantity;
                existingProduct.categoryId = product.categoryId;

                // Update other properties as needed

                // Save changes to the database
                await _context.SaveChangesAsync();

                return 1; // Update successful
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully (log errors, rethrow)
                Console.Error.WriteLine($"Error updating product {product.id}: {ex.Message}");
                return -1; // Error occurred
            }
        }


        public Product getProductById(int id) 
        { 
            return _context.Products.Find(id);
        }


        public bool DeleteProductById(int id) 
        {
            var entityToDelete = _context.Products.Local.FirstOrDefault(x => x.id == id);
            if (entityToDelete == null)
            {
                entityToDelete = new Product { id = id };
                _context.Attach(entityToDelete);
            }
            _context.Products.Remove(entityToDelete);
            _context.SaveChanges();

            return true;

        }

        public List<Category> getCategoryList()
        {
            var categories = _context.Categories
                .OrderBy(p => p.name)
                .Where(p => p.active == true)
                .ToList();

            return categories;
        }

        public async Task<bool> AddCategory(Category category) 
        {
            var existingCategory = await _context.Categories.FirstOrDefaultAsync(c => c.name == category.name);
            if (existingCategory != null)
            {
                return false;
            }

            try
            {
                // Add the product to the context
                await _context.Categories.AddAsync(category);

                // Save changes to the database
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex) 
            {
                Console.Error.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteCategoryById(int id)
        {
            var entityToDelete = _context.Categories.Local.FirstOrDefault(x => x.id == id);
            if (entityToDelete == null)
            {
                entityToDelete = new Category { id = id };
                _context.Attach(entityToDelete);
            }
            _context.Categories.Remove(entityToDelete);
            _context.SaveChanges();

            return true;

        }

    }
}
