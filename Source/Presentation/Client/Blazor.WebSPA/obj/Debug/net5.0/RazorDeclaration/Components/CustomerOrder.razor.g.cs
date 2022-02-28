// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.WebSPA.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Blazor.WebSPA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Blazor.WebSPA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Blazor.WebSPA.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Components\CustomerOrder.razor"
using Domain.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Components\CustomerOrder.razor"
using Blazor.WebSPA.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class CustomerOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Components\CustomerOrder.razor"
       

    Dictionary<string, object> HandyFunction(string fruitName)
    {
        var dictionary = new Dictionary<string, object>();
        dictionary.Add(fruitName, covModel.ItemQuantity);
        return dictionary;
    }

    protected override async Task OnInitializedAsync()
    {
        homeViewModel.Recipes = await recipeService.GetAllAsync();
        homeViewModel.Recipe = await recipeService.GetByIdAsync(covModel.Id);
    }

    protected override void OnInitialized()
    {
        homeViewModel.EditFormContext = new EditContext(covModel);
    }

    private async Task OnValueChanged(int id)
    {
        homeViewModel.Recipe = await recipeService.GetByIdAsync(id);
    }

    private void HandleValidSubmit()
    {
        Dictionary<string, decimal> fruitQuantity = new();
        fruitQuantity.Add("Apple", covModel.AppleQuantity);
        fruitQuantity.Add("Melon", covModel.MelonQuantity);
        fruitQuantity.Add("Orange", covModel.OrangeQuantity);

        var result = fruitPressService.Produce(homeViewModel.Recipe, fruitQuantity, covModel.MoneyAmountReceived, covModel.OrderQuantity);
        homeViewModel.ProductionResult = String.Join(", ", result.ToArray());
        Console.WriteLine(homeViewModel.ProductionResult);
    }

    private void HandleReset()
    {
        homeViewModel.EditFormContext = new EditContext(covModel);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFruitPressService fruitPressService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService recipeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerOrderViewModel covModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HomeViewModel homeViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
