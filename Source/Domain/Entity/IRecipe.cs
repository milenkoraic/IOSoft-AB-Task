using System;

namespace Domain.Entity
{
    public interface IRecipe
    {
        string Image { get; set; }
        string Name { get; set; }
        int PricePerGlass { get; set; }
        Type AllowedFruit { get; set; }
        decimal ConsumptionPerGlass { get; set; }
    }
}
