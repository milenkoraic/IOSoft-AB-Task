using Domain.Entities;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;

namespace Blazor.WebSPA.ViewModels
{
    public class HomeViewModel
    {
        public EditContext EditFormContext { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
        public Recipe Recipe { get; set; }
        public Dictionary<string, int> FruitQuantity { get; set; }
        public string ProductionResult { get; set; }
        public string StatusBG { get; set; }
        public string StatusFC { get; set; }
    }
}
