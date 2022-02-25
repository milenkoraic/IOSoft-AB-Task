using Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Service
{ 
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetRecipesAsync();
    }
}