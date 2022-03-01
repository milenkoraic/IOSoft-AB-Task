using Domain.Entities.Recipes.Coctail;
using Domain.Entities.Recipes.Coffee;
using Domain.Entities.Recipes.Juice;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<CoctailRecipe>> GetAllCoctailsAsync();
        Task<IEnumerable<CofeeRecipe>> GetAllCoffeesAsync();
        Task<IEnumerable<JuiceRecipe>> GetAllJuicesAsync();
        Task<CoctailRecipe> GetCoctailByIdAsync(int id);
        Task<CofeeRecipe> GetCoffeeByIdAsync(int id);
        Task<JuiceRecipe> GetJuiceByIdAsync(int id);
    }
}