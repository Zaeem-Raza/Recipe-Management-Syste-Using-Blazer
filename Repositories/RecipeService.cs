using EAD_Assignment2.Interfaces;
using EAD_Assignment2.Models.Classes;
using System.Collections.Generic;
using System.Linq;

namespace EAD_Assignment2.Repositories
{
    public class RecipeService : IRecipeService
    {
        private List<Recipe> MyRecipes;
        

        public RecipeService()
        {
            MyRecipes = new List<Recipe>();

            // Populating with some random data
            MyRecipes.Add(new Recipe
            {
                Id = "klasf-2",
                Name = "Spaghetti Bolognese",
                Price = 12.99m,
                Description = "Classic Italian pasta dish",
                Ingredients = "Spaghetti, Ground Beef, Tomato Sauce",
                Category = "Breakfast"
            });
            MyRecipes.Add(new Recipe
            {
                Id = "safias,f-2",
                Name = "Caesar Salad",
                Price = 8.50m,
                Description = "Fresh Caesar Salad",
                Ingredients = "Lettuce, Croutons, Caesar Dressing",
                Category = "Lunch"
            });
            MyRecipes.Add(new Recipe
            {
                Id = "asklf,,2-f",
                Name = "Chocolate Cake",
                Price = 6.99m,
                Description = "Delicious chocolate cake",
                Ingredients = "Flour, Cocoa, Sugar, Eggs",
                Category = "Dinner"
            });
            
        }

        public void CreateRecipe(Recipe recipe)
        {
            Guid myGuid = Guid.NewGuid();
            recipe.Id = myGuid.ToString();
            MyRecipes.Add(recipe);
        }

        public void DeleteRecipe(string Id)
        {
            var recipe = MyRecipes.FirstOrDefault(r => r.Id == Id);
            if (recipe != null)
            {
                MyRecipes.Remove(recipe);
            }
        }

        public void UpdateRecipe(Recipe recipe)
        {
            var existingRecipe = MyRecipes.FirstOrDefault(r => r.Id == recipe.Id);
            if (existingRecipe != null)
            {
                existingRecipe.Name = recipe.Name;
                existingRecipe.Price = recipe.Price;
                existingRecipe.Description = recipe.Description;
                existingRecipe.Ingredients = recipe.Ingredients;
                existingRecipe.Category = recipe.Category;
            }
        }

        public List<Recipe> GetAllRecipes()
        {
            return MyRecipes;
        }

        public Recipe GetRecipes(string Id)
        {
            return MyRecipes.FirstOrDefault(r => r.Id == Id);
        }

        // search based on query
        public List<Recipe> Search(string query)
        {
            // Search recipes by name, description, or category
            return MyRecipes.Where(r =>
                r.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();  
        }
    }
}
