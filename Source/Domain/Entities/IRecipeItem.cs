namespace Domain.Entities
{
    public interface IRecipeItem
    {
        int Id{ get; set; }
        string Name{ get; set; }
        string Quantity {get; set; }
        void AddItem(){}
    }
}
