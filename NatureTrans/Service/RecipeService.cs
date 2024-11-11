using Microsoft.EntityFrameworkCore;
using NatureTrans.Data;
using NatureTrans.DTOs;
using NatureTrans.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.Service
{
    internal class RecipeService
    {
        public readonly NTContext _context;
        public RecipeService(NTContext context) { _context = context; }

        public async Task<Recipe> createRecipe(Recipe recipe)
        {
            try
            {
                await _context.Recipes.AddAsync(recipe);
                await _context.SaveChangesAsync();
                return recipe;
            }
            catch (Exception ex) 
            {
                Console.Error.WriteLine($"Error adding {recipe}: {ex.Message}");
                return null;
            }
        }

        public int GetLastRecipeId()
        {
            var lastRecipe = _context.Recipes.OrderByDescending(p => p.id).FirstOrDefault();
            return lastRecipe?.id ?? 0;
        }

        public async Task<bool> AddIngredient(Recipe recipe, int productId)
        {
            RecipeIngredient recipeIngredient = new RecipeIngredient
            {
                productId = productId,
                recipeId = recipe.id,
                ingredient_unit = Types.Unit.gr,
                ingredient_qty = 1
            };

            try
            {
                await _context.RecipeIngredients.AddAsync(recipeIngredient);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error adding {recipeIngredient}: {ex.Message}");
                return false;
            }
        }

        public List<IngredientDTO> GetRecipeIngredients(int recipeId)
        {
            var query = from ingredient in _context.RecipeIngredients
                        join product in _context.Products on ingredient.productId equals product.id
                        join recipe in _context.Recipes on ingredient.recipeId equals recipe.id
                        where recipe.id == recipeId
                        orderby product.name descending

                        select new IngredientDTO
                        {
                            id = ingredient.id,
                            Ingredient = product.name, // Get product name
                            Recette = recipe.name,   // Get recipe name
                            Quantité = ingredient.ingredient_qty,
                            Unité = ingredient.ingredient_unit,
                            Note = ingredient.note,
                        };

            return query.ToList();
        }

        public List<Recipe> GetRecipes(int startIndex = 0, int endIndex = 20)
        {
            var recipes = _context.Recipes
                .OrderByDescending(rcp => rcp.id)
                .Skip(startIndex).Take(endIndex - startIndex);

            return recipes.ToList<Recipe>();
        }

        public Recipe GetRecipeById(int recipeId)
        {
            return _context.Recipes.Find(recipeId);
        }


        public async Task<bool> UpdateRecipeIngredient(RecipeIngredient ingredient)
        {
            try
            {
                if (ingredient.id == 0)
                {
                    return false;
                }
                // Detach any existing instance with the same primary key
                var trackedEntity = await _context.RecipeIngredients.FindAsync(ingredient.id);
                if (trackedEntity != null)
                {
                    _context.Entry(trackedEntity).State = EntityState.Detached;
                }

                _context.RecipeIngredients.Attach(ingredient);
                _context.Entry(ingredient).State = EntityState.Modified;

                // Exclude specific properties from being tracked for update
                _context.Entry(ingredient).Property(x => x.productId).IsModified = false;
                _context.Entry(ingredient).Property(x => x.recipeId).IsModified = false;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully (log errors, rethrow)
                Console.Error.WriteLine($"Error updating Ingredient Order {ingredient.id}: {ex.Message}");
                return false; // Error occurred
            }
        }

        public async Task<bool> UpdateRecipe(Recipe recipe)
        {
            try
            {
                if (recipe.id == 0)
                {
                    return false;
                }
                // Detach any existing instance with the same primary key
                var trackedEntity = await _context.Recipes.FindAsync(recipe.id);
                if (trackedEntity != null)
                {
                    _context.Entry(trackedEntity).State = EntityState.Detached;
                }

                _context.Recipes.Attach(recipe);
                _context.Entry(recipe).State = EntityState.Modified;

                // Exclude specific properties from being tracked for update
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully (log errors, rethrow)
                Console.Error.WriteLine($"Error updating Recipe {recipe.id}: {ex.Message}");
                return false; // Error occurred
            }
        }

        public async Task UpdateIngredientsRecipe(int recipeId, string newName)
        {
            var trackedRecipe = await _context.Recipes.FindAsync(recipeId);
            trackedRecipe.name = newName;

            _context.Recipes.Attach(trackedRecipe);
            _context.Entry(trackedRecipe).State = EntityState.Modified;

            // Exclude specific properties from being tracked for update
            await _context.SaveChangesAsync();
        }

        public bool RemoveIngredient(int id)
        {
            var entityToDelete = _context.RecipeIngredients.Local.FirstOrDefault(x => x.id == id);
            if (entityToDelete == null)
            {
                entityToDelete = new RecipeIngredient { id = id };
                _context.Attach(entityToDelete);
            }

            _context.RecipeIngredients.Remove(entityToDelete);
            _context.SaveChanges();

            return true;
        }
    }
}
