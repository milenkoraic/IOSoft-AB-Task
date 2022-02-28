using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Blazor.WebSPA.ViewModels
{
    public class CustomerOrderViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "The order number cannot be 0. A maximum of 100 glasses is allowed per order!")]
        public int OrderQuantity { get; set; } = 1;

        [Required]
        [Range(1, 1500, ErrorMessage = "The received money amount cannot be 0. The maximum cash allowance is 1500 SEK!")]
        public int MoneyAmountReceived { get; set; }

        [Range(0, 250, ErrorMessage = "The maximum number of apples to order is 250. Your current business concept cannot handle larger quantities at the moment!")]
        public decimal AppleQuantity { get; set; }

        [Range(0, 50, ErrorMessage = "The maximum number of melons to order is 50. Your current business concept cannot handle larger quantities at the moment!")]
        public decimal MelonQuantity { get; set; }

        [Range(0, 100, ErrorMessage = "The maximum number of oranges to order is 250. Your current business concept cannot handle larger quantities at the moment!")]
        public decimal OrangeQuantity { get; set; }
    }
}
