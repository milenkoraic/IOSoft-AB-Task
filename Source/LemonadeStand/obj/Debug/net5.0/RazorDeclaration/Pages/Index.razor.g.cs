// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LemonadeStand.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using LemonadeStand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\_Imports.razor"
using LemonadeStand.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Pages\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Pages\Index.razor"
       
    private OrderModel model = new OrderModel();
    private EditContext editContext;

    protected override void OnInitialized()
    {
        editContext = new EditContext(model);
    }

    private void HandleValidSubmit()
    {
        var modelJson = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
        JSRuntime.InvokeVoidAsync("alert", $"SUCCESS!! :-)\n\n{modelJson}");
    }

    private void HandleReset()
    {
        model = new OrderModel();
        editContext = new EditContext(model);
    }

    private interface IFruit
    {
        public string Name { get; }
    }

    private class Fruit:IFruit
    {
        public string Name { get; }
    }

    private interface IRecipe
    {
        string Name { get; }
        Type AllowedFruit { get; }
        decimal ConsumptionPerGlass { get; }
        int PricePerGlass { get; }
    }

    private interface IFruitPressService
    {
       
    }


    private class OrderModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must select some recipe!")]
        [Display(Name = "Recipe Name ")]
        public string RecipeName { get; set; }

        [Required]
        [Display(Name = "Order Quantity")]
        public int OrderQuantity { get; set; }

        [Required]
        [Display(Name = "Money Paid")]
        public int MoneyPaid { get; set; }

        [Required]
        [Display(Name = "Apples Added")]
        public int ApplesAdded { get; set; }

        [Required]
        [Display(Name = "Melons Added")]
        public int MelonsAdded { get; set; }

        [Required]
        [Display(Name = "Oranges Added")]
        public int OrangesAdded { get; set; }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
