using System;

namespace Domain.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int PricePerGlass { get; set; }
        public string AllowedFruit { get; set; }
        public decimal ConsumptionPerGlass { get; set; }
    }
}
