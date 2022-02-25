using System.ComponentModel.DataAnnotations;

namespace Blazor.WebSPA.ViewModels
{
    public class CustomerOrderViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must select some recipe!")]
        public string RecipeName { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "A maximum of 100 glasses is allowed per order!")]
        public int OrderQuantity { get; set; }

        [Required]
        [Range(1, 1500, ErrorMessage = "The received money amount cannot be 0. The maximum cash allowance is 1500 SEK!")]
        public int MoneyPaid { get; set; }

        [Range(0, 250, ErrorMessage = "You can not add more than 250 apples per order!")]
        public int ApplesAdded { get; set; }

        [Range(0, 10, ErrorMessage = "You can not add more than 100 melons per order!")]
        public int MelonsAdded { get; set; }

        [Range(0, 150, ErrorMessage = "You can not add more than 150 oranges per order!")]
        public int OrangesAdded { get; set; }
    }
}
