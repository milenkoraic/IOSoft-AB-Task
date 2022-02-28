using System;

namespace Domain
{
    public interface IRecipe
    {
        int Id { get; set; }
        string Image { get; set; }
        string Name { get; set; }
        int PricePerGlass { get; set; }
        Type AllowedFruit { get; set; }
        decimal ConsumptionPerGlass { get; set; }
    }
}
