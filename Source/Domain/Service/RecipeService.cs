using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class RecipeService : IRecipeService
    {
        private static readonly HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:44323")
        };

        private string JsonUrlPath { get; } = "/api/recipes.json";

        public async Task<IEnumerable<Recipe>> GetRecipesAsync()
        {
            using var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, JsonUrlPath));
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Recipe>>();
        }
    }
}
