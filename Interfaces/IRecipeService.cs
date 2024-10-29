using EAD_Assignment2.Models.Classes;

namespace EAD_Assignment2.Interfaces
{
    public interface IRecipeService
    {
         void CreateRecipe(Recipe recipe);
         void DeleteRecipe(string Id);
         void UpdateRecipe(Recipe recipe);
         List<Recipe> GetAllRecipes();
         Recipe GetRecipes(string Id);

         List<Recipe> Search(string query);


    }
}
