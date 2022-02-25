using Domain.Entity;
using System.Collections.ObjectModel;

namespace Domain.Service
{
    public class FruitPressResult:IFruitPressService
    {
        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            throw new System.NotImplementedException();
        }
    }
}