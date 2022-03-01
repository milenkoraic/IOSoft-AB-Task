using Domain.Recipes;

namespace Domain.Entities.Recipes.IceCream
{
    public class IceCreamRecipe : IRecipe
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int PricePerGlass { get; set; }
    }
}
