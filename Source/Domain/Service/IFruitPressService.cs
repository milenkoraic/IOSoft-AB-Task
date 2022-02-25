using Domain.Entity;
using System.Collections.ObjectModel;

namespace Domain.Service
{
    public interface IFruitPressService
    {
        FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity);
    }
}