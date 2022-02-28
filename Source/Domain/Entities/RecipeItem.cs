using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Fruits
{
    public class RecipeItem : IRecipeItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
    }
}
