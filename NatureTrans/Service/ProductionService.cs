using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NatureTrans.Data;
using NatureTrans.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.Service
{
    internal class ProductionService
    {
        public readonly NTContext _context;
        public ProductionService(NTContext context)
        { 
            _context = context;
        }
        public int GetLastProductionId()
        {
            var lastProduction = _context.Productions.OrderByDescending(p => p.id).FirstOrDefault();
            return lastProduction?.id ?? 0;
        }

        public async Task<Production> createProduction(Production production)
        {
            Console.WriteLine("adding " + production);
            try
            {
                await _context.Productions.AddAsync(production);
                await _context.SaveChangesAsync();
                return production;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error adding {production}: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> AddRecipeToProduction(Production production, int? recipeId)
        {
            try
            {
                if (production.id == 0) 
                { 
                    return false;
                }
                
                var previousEntity = await _context.Productions.FindAsync(production.id);
                if (previousEntity != null)
                {
                    _context.Entry(previousEntity).State = EntityState.Detached;
                }

                _context.Attach(production);
                _context.Entry(production).State = EntityState.Modified;
                production.recipeId = recipeId;
                await _context.SaveChangesAsync();

                return true;

            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public  List<Production> GetProductions(int startIndex, int endIndex, string searchStr = "") 
        {

            var productions = _context.Productions
                              .Where(p => EF.Functions.Like(p.name, $"%{searchStr}%"))
                              .OrderByDescending(p => p.id)
                              .Select(p => new Production
                              {
                                  id = p.id,
                                  name = p.name,
                                  recipeId = p.recipeId, // Get product name
                                  prod_quantity = p.prod_quantity,   // Get recipe name
                                  prod_unit = p.prod_unit,
                                  price = p.price,
                                  description = p.description
                              })
                              
                              
                              .ToList<Production>();

            return productions;
        }

        public async Task<dynamic> UpdateProduction(Production production)
        {
            if(production == null || production?.id == 0) 
            {
                return null;
            }
            try
            {
                var existingProd = await _context.Productions.FindAsync(production.id);
                if (existingProd != null)
                {
                    if(production.recipeId > 0)
                    {
                        existingProd.recipeId = production.recipeId;
                    }
                    existingProd.price = production.price;
                    existingProd.name = production.name;
                    existingProd.description = production.description;
                    existingProd.prod_quantity = production.prod_quantity;
                    existingProd.prod_unit = production.prod_unit;
                    existingProd.prod_state = production.prod_state;
                    _context.SaveChangesAsync();
                    return existingProd;
                }
                return null;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }

        public async Task<bool> RemoveRecipeFromProduction(int recipeId)
        {
            if (recipeId == null)
            {
                return false;
            }

            try
            {
                var existingProd = await _context.Productions.FirstOrDefaultAsync(p => p.recipeId == recipeId);
                if (existingProd == null)
                {
                    return false;
                }

                existingProd.recipeId = null;
                _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.Error.WriteLine($"Error removing recipe from production: {ex.Message}");
                return false;
            }
        }

        public Production GetProductionById(int productionId)
        {
            var selectedProd = _context.Productions
            .Where(p => p.id == productionId)
            .Select(prod => new Production
                {
                    id = prod.id,
                    recipeId = prod.recipeId,
                    name = prod.name,
                    prod_quantity = prod.prod_quantity,
                    prod_unit = prod.prod_unit,
                    prod_state = prod.prod_state,
                    price = prod.price,
                    description = prod.description
                })
            .FirstOrDefault();

            if (selectedProd != null)
            {
                return selectedProd;
            }

            return new Production();
        }
    }
}
