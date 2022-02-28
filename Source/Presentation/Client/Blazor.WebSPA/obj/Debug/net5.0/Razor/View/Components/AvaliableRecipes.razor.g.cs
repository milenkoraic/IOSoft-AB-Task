#pragma checksum "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6627479ed405ea5c7f2e3b1d5372336a609a8ac"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.WebSPA.View.Components
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
using Blazor.WebSPA.View;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\_Imports.razor"
using Blazor.WebSPA.View.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
using Domain.Services;

#line default
#line hidden
#nullable disable
    public partial class AvaliableRecipes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Availible Recipes</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex justify-content-start");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
         if (recipes == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>There is no availible recipes!</em></p>");
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
             foreach (var recipe in recipes)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-4");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddAttribute(10, "style", "width: 18rem;");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
                                   recipe.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "class", "card-img-top");
            __builder.AddAttribute(14, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-body");
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "class", "card-title");
            __builder.AddContent(20, 
#nullable restore
#line 21 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
                                                    recipe.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            <hr>\r\n                            ");
            __builder.AddMarkupContent(22, "<h6 class=\"card-subtitle mb-2\">Price per glass:</h6>\r\n                            ");
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, 
#nullable restore
#line 24 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
                                recipe.PricePerGlass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " SEK");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.AddMarkupContent(27, "<h6 class=\"card-text\">Fruits needed per glass:</h6>\r\n                            ");
            __builder.OpenElement(28, "p");
            __builder.AddContent(29, 
#nullable restore
#line 26 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
                                recipe.ConsumptionPerGlass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " ");
            __builder.AddContent(31, 
#nullable restore
#line 26 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
                                                            recipe.AllowedFruit

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " (s)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\AvaliableRecipes.razor"
       
    private IEnumerable<Recipe> recipes;

    protected override async Task OnInitializedAsync()
    {
        recipes = await recipeService.GetAllAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService recipeService { get; set; }
    }
}
#pragma warning restore 1591
