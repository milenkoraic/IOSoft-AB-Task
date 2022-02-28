using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface IFruitPressService
    {
        List<string> Produce(Recipe recipe, Dictionary<string, decimal> fruits, int moneyPaid, int orderedGlassQuantity);
    }
}