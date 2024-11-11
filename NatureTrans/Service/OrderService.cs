using Microsoft.EntityFrameworkCore;
using NatureTrans.Data;
using NatureTrans.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.Service
{
    internal class OrderService
    {
        private readonly NTContext _context;
        public OrderService(NTContext context) 
        { 
            _context = context;
        }

        public List<Provider> FilterProvider(string searchString, int startIndex = 0, int endIndex = 20)
        {

            if (searchString.Length >= 3)
            {
                var query = from provider in _context.Providers
                            where !string.IsNullOrEmpty(searchString) && EF.Functions.Like(provider.name, "%" + searchString + "%")
                            select provider; // or select new { roduct.name, category.active 

                return query.ToList();
            }
            else
            {
                return new List<Provider>();
            }
        }

        public async Task<PurchaseOrder> GetPurchaseOrderById(int id) 
        {
            return await _context.PurchaseOrders.FindAsync(id);
        }

        public List<PurchaseOrder> GetOrdersList(int startIndex = 0, int endIndex = 20)
        {
            var query = from purchaseOrder in _context.PurchaseOrders
                        orderby purchaseOrder.updatedAt
                        select purchaseOrder;

            var ordersList = query.Skip(startIndex).Take(endIndex - startIndex).ToList();

            return ordersList;
        }

        public List<Provider> GetProviderList(int startIndex, int pageSize = 20)
        {
            var query = from provider in _context.Providers
                        where provider.active == true
                        orderby provider.name
                        select provider; // or select new { roduct.name, category.active 

            var providerList = query.Skip(startIndex).Take(pageSize - startIndex).ToList();

            return providerList;
        }

        public string GetProductNameById(int Id)
        {
                var product = _context.Products.FirstOrDefault(p => p.id == Id);
                if (product != null)
                {
                    return product.name;
                }
            return null;
        }

        public string GetProviderNameById(int Id)
        {
            var result = _context.Providers.FirstOrDefault(p => p.id == Id);
            return result.name;
        }

        /**
         * @Desc :  update existing purchase order 
         * @Params: PurchaseOrder
         * @Return : int (-1, 0, 1)
         * 
         **/
        public async Task<int> UpdatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            try
            {
                if (purchaseOrder.id == 0)
                {
                    return 0; // Product not found
                }

                // Find the product to update by its ID
                var existingPO = await _context.PurchaseOrders.FindAsync(purchaseOrder.id);

                // Check if product exists
                if (existingPO == null )
                {
                    return 0;
                }
                else 
                {
                    _context.Entry(existingPO).State = EntityState.Detached;
                }

                purchaseOrder.createdAt = existingPO.createdAt;
                purchaseOrder.updatedAt = DateTime.Now;

                _context.PurchaseOrders.Attach(purchaseOrder);
                _context.Entry(purchaseOrder).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return 1; // Update successful
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully (log errors, rethrow)
                Console.Error.WriteLine($"Error updating Purchase Order {purchaseOrder.id}: {ex.Message}");
                return -1; // Error occurred
            }
        }

        public async Task<PurchaseOrder> AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            try
            {
                
                if (purchaseOrder.GetType().GetProperty("productId").GetValue(purchaseOrder) == null ||
                    purchaseOrder.GetType().GetProperty("providerId").GetValue(purchaseOrder) == null ||
                    purchaseOrder.GetType().GetProperty("price").GetValue(purchaseOrder) == null)
                {
                    Console.Error.WriteLine($"Wrong order - should have a product, a provider and a price");
                    return new PurchaseOrder();
                }

                // Add the product to the context
                await _context.PurchaseOrders.AddAsync(purchaseOrder);

                // Save changes to the database
                await _context.SaveChangesAsync();
                return purchaseOrder;
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully (log errors, rethrow)
                Console.Error.WriteLine($"Error adding {purchaseOrder}: {ex.Message}");
                return null; // Error occurred
            }
        }

        public bool RemovePO(int id)
        {
            var entityToDelete = _context.PurchaseOrders.Local.FirstOrDefault(x => x.id == id);
            if (entityToDelete == null)
            {
                entityToDelete = new PurchaseOrder { id = id };
                _context.Attach(entityToDelete);
            }
            
            _context.PurchaseOrders.Remove(entityToDelete);
            _context.SaveChanges();

            return true;
        }
    }
}
