#pragma checksum "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98edb383a0cf5253c12806be0960b4df9d095b50"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.WebSPA.Pages
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
#line 3 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
using Domain.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
using Domain.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
using Blazor.WebSPA.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 b-8weqfyq497>Lemonade Stand Code Test</h2>\r\n<hr b-8weqfyq497>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3 b-8weqfyq497>Availible Recipes</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "d-flex justify-content-start");
            __builder.AddAttribute(4, "b-8weqfyq497");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddAttribute(7, "b-8weqfyq497");
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
         if (recipes == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p b-8weqfyq497><em b-8weqfyq497>There is no availible recipes!</em></p>");
#nullable restore
#line 22 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
             foreach (var recipe in recipes)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-4");
            __builder.AddAttribute(11, "b-8weqfyq497");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card");
            __builder.AddAttribute(14, "style", "width: 18rem;");
            __builder.AddAttribute(15, "b-8weqfyq497");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 29 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                   recipe.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "class", "card-img-top");
            __builder.AddAttribute(19, "alt", "...");
            __builder.AddAttribute(20, "b-8weqfyq497");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.AddAttribute(24, "b-8weqfyq497");
            __builder.OpenElement(25, "h5");
            __builder.AddAttribute(26, "class", "card-title");
            __builder.AddAttribute(27, "b-8weqfyq497");
            __builder.AddContent(28, 
#nullable restore
#line 31 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                                    recipe.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            <hr b-8weqfyq497>\r\n                            ");
            __builder.AddMarkupContent(30, "<h6 class=\"card-subtitle mb-2\" b-8weqfyq497>Price per glass:</h6>\r\n                            ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "b-8weqfyq497");
            __builder.AddContent(33, 
#nullable restore
#line 34 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                recipe.PricePerGlass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " SEK");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.AddMarkupContent(36, "<h6 class=\"card-text\" b-8weqfyq497>Fruits needed per glass:</h6>\r\n                            ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "b-8weqfyq497");
            __builder.AddContent(39, 
#nullable restore
#line 36 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                recipe.ConsumptionPerGlass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, " ");
            __builder.AddContent(41, 
#nullable restore
#line 36 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                                            recipe.AllowedFruit

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(42, " (s)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.AddMarkupContent(44, "<h3 b-8weqfyq497>Customer Order</h3>\r\n\r\n");
            __builder.OpenElement(45, "section");
            __builder.AddAttribute(46, "class", "form-container");
            __builder.AddAttribute(47, "b-8weqfyq497");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "production-result");
            __builder.AddAttribute(50, "b-8weqfyq497");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row" + " " + (
#nullable restore
#line 49 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                         classStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "b-8weqfyq497");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col");
            __builder.AddAttribute(56, "b-8weqfyq497");
            __builder.OpenElement(57, "span");
            __builder.AddAttribute(58, "b-8weqfyq497");
            __builder.AddContent(59, 
#nullable restore
#line 51 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                        productionResult

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(61);
            __builder.AddAttribute(62, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 55 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                            editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 55 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                                        HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(64, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                                                                     HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(66);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group col");
                __builder2.AddAttribute(70, "b-8weqfyq497");
                __builder2.AddMarkupContent(71, "<label b-8weqfyq497>Select recipe:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateInputSelect_0(__builder2, 72, 73, "form-control", 74, 
#nullable restore
#line 59 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      customerOrderViewModel.RecipeName

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customerOrderViewModel.RecipeName = __value, customerOrderViewModel.RecipeName)), 76, () => customerOrderViewModel.RecipeName, 77, (__builder3) => {
                    __builder3.AddMarkupContent(78, "<option value selected b-8weqfyq497></option>");
#nullable restore
#line 61 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                 if (recipes != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                     foreach (var recipe in recipes)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(79, "option");
                    __builder3.AddAttribute(80, "value", 
#nullable restore
#line 65 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                        recipe.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(81, "b-8weqfyq497");
                    __builder3.AddContent(82, 
#nullable restore
#line 65 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                                      recipe.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 66 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                     
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(83, "\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateValidationMessage_1(__builder2, 84, 85, 
#nullable restore
#line 69 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      () => customerOrderViewModel.RecipeName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group col");
                __builder2.AddAttribute(89, "b-8weqfyq497");
                __builder2.AddMarkupContent(90, "<label b-8weqfyq497>Order quantity:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateInputNumber_2(__builder2, 91, 92, "form-control", 93, 
#nullable restore
#line 73 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      customerOrderViewModel.OrderQuantity

#line default
#line hidden
#nullable disable
                , 94, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customerOrderViewModel.OrderQuantity = __value, customerOrderViewModel.OrderQuantity)), 95, () => customerOrderViewModel.OrderQuantity);
                __builder2.AddMarkupContent(96, "\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateValidationMessage_3(__builder2, 97, 98, 
#nullable restore
#line 74 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      () => customerOrderViewModel.OrderQuantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group col");
                __builder2.AddAttribute(102, "b-8weqfyq497");
                __builder2.AddMarkupContent(103, "<label b-8weqfyq497>Money paid</label>\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateInputNumber_4(__builder2, 104, 105, "form-control", 106, 
#nullable restore
#line 78 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      customerOrderViewModel.MoneyPaid

#line default
#line hidden
#nullable disable
                , 107, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customerOrderViewModel.MoneyPaid = __value, customerOrderViewModel.MoneyPaid)), 108, () => customerOrderViewModel.MoneyPaid);
                __builder2.AddMarkupContent(109, "\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateValidationMessage_5(__builder2, 110, 111, 
#nullable restore
#line 79 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      () => customerOrderViewModel.MoneyPaid

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n        ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group col");
                __builder2.AddAttribute(115, "b-8weqfyq497");
                __builder2.AddMarkupContent(116, "<label b-8weqfyq497>Apples added:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateInputNumber_6(__builder2, 117, 118, "form-control", 119, 
#nullable restore
#line 83 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      customerOrderViewModel.ApplesAdded

#line default
#line hidden
#nullable disable
                , 120, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customerOrderViewModel.ApplesAdded = __value, customerOrderViewModel.ApplesAdded)), 121, () => customerOrderViewModel.ApplesAdded);
                __builder2.AddMarkupContent(122, "\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateValidationMessage_7(__builder2, 123, 124, 
#nullable restore
#line 84 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      () => customerOrderViewModel.ApplesAdded

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n        ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "form-group col");
                __builder2.AddAttribute(128, "b-8weqfyq497");
                __builder2.AddMarkupContent(129, "<label b-8weqfyq497>Melons added:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateInputNumber_8(__builder2, 130, 131, "form-control", 132, 
#nullable restore
#line 88 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      customerOrderViewModel.MelonsAdded

#line default
#line hidden
#nullable disable
                , 133, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customerOrderViewModel.MelonsAdded = __value, customerOrderViewModel.MelonsAdded)), 134, () => customerOrderViewModel.MelonsAdded);
                __builder2.AddMarkupContent(135, "\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateValidationMessage_9(__builder2, 136, 137, 
#nullable restore
#line 89 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      () => customerOrderViewModel.MelonsAdded

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n        ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "form-group col");
                __builder2.AddAttribute(141, "b-8weqfyq497");
                __builder2.AddMarkupContent(142, "<label b-8weqfyq497>Oranges added:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateInputNumber_10(__builder2, 143, 144, "form-control", 145, 
#nullable restore
#line 93 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      customerOrderViewModel.OrangesAdded

#line default
#line hidden
#nullable disable
                , 146, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customerOrderViewModel.OrangesAdded = __value, customerOrderViewModel.OrangesAdded)), 147, () => customerOrderViewModel.OrangesAdded);
                __builder2.AddMarkupContent(148, "\r\n            ");
                __Blazor.Blazor.WebSPA.Pages.Index.TypeInference.CreateValidationMessage_11(__builder2, 149, 150, 
#nullable restore
#line 94 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
                                      () => customerOrderViewModel.OrangesAdded

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n        ");
                __builder2.AddMarkupContent(152, "<div class=\"text-left\" b-8weqfyq497><button type=\"submit\" class=\"btn btn-success mr-1\" b-8weqfyq497>PROCESS ORDER</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\Pages\Index.razor"
       
    private IEnumerable<Recipe> recipes;
    private EditContext editContext;

    private string productionResult;
    private string classStatus = "";

    private IRecipe recipe;
    private string recipePrice { get; set; }
    private Collection<IFruit> fruits;
    private int moneyPaid;
    private int orderedGlassQuantity;

    protected override async Task OnInitializedAsync()
    {
        recipes = await recipeService.GetRecipesAsync();
    }

    protected override void OnInitialized()
    {
        editContext = new EditContext(customerOrderViewModel);
    }

    private void HandleValidSubmit()
    {
        //fruitPressService.Produce(recipe, fruits, moneyPaid, orderedGlassQuantity);
        JSRuntime.InvokeVoidAsync("alert", $"SUCCESS!! :-)\n\n{JsonSerializer.Serialize(customerOrderViewModel, new JsonSerializerOptions { WriteIndented = true })}");
        productionResult= "SUCCES";
    }

    private void HandleReset()
    {
        editContext = new EditContext(customerOrderViewModel);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService recipeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFruitPressService fruitPressService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerOrderViewModel customerOrderViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Blazor.WebSPA.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591