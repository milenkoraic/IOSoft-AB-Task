using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class RecipeService : IRecipeService
    {
        private static readonly HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:44323/")
        };

        private readonly string ApiPath = "api/";

        private string JsonTemplate{ get; } = "/recipes.json";

        public async Task<IEnumerable<Recipe>> GetAllAsync()
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var request = new HttpRequestMessage(HttpMethod.Get, ApiPath + JsonTemplate);
            using var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var recipes = await response.Content.ReadFromJsonAsync<IEnumerable<Recipe>>();
            return recipes;
        }

        public async Task<Recipe> GetByIdAsync(int id)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var request = new HttpRequestMessage(HttpMethod.Get, ApiPath + id + JsonTemplate);
            using var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var recipes = await response.Content.ReadFromJsonAsync<List<Recipe>>();

            Recipe recipe = new (){
                Id = recipes[0].Id,
                Name = recipes[0].Name,
                Image = recipes[0].Image,
                PricePerGlass = recipes[0].PricePerGlass,
                ConsumptionPerGlass = recipes[0].ConsumptionPerGlass,
                AllowedFruit = recipes[0].AllowedFruit
            };

            return recipe;
        }
    }
}
