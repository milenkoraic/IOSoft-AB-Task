namespace Domain.Entity
{
    public class Recipe
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public int PricePerGlass { get; set; }
        public string AllowedFruit { get; set; }
        public decimal ConsumptionPerGlass { get; set; }
    }
}
