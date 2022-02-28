using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ItemQuantity : IItem
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
    }
}
