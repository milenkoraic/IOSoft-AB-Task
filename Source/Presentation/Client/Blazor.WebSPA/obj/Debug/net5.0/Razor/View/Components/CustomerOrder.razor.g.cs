#pragma checksum "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dcff7034424829ca89ce74fcd39aabfb8198bfc"
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
#line 2 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
using Domain.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
using Blazor.WebSPA.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class CustomerOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Customer Order</h3>\r\n\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "form-container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                            homeViewModel.EditFormContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                                                                                       HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", " form-group col");
                __builder2.OpenElement(10, "ul");
                __builder2.AddAttribute(11, "class", "validation-errors bg-light");
                __builder2.AddAttribute(12, "style", "background-color:" + " " + (
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                                                             homeViewModel.StatusBG

#line default
#line hidden
#nullable disable
                ) + " !important;" + " border:none;");
                __builder2.OpenElement(13, "li");
                __builder2.AddAttribute(14, "class", "validation-message");
                __builder2.AddAttribute(15, "style", "color:" + (
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                                            homeViewModel.StatusFC

#line default
#line hidden
#nullable disable
                ) + " !important;");
                __builder2.AddContent(16, 
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                                                                                 homeViewModel.ProductionResult

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", " form-group col");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(22);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group col");
                __builder2.AddMarkupContent(26, "<label>Select recipe:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateInputSelect_0(__builder2, 27, 28, 
#nullable restore
#line 24 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                            ()=>covModel.Id

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 24 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                                                              (int id) => OnValueChanged(id)

#line default
#line hidden
#nullable disable
                ), 30, "form-control", 31, (__builder3) => {
#nullable restore
#line 25 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                 if (homeViewModel.Recipes != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                     foreach (var recipe in homeViewModel.Recipes)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(32, "option");
                    __builder3.AddAttribute(33, "value", 
#nullable restore
#line 29 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                        recipe.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(34, 
#nullable restore
#line 29 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                                    recipe.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 30 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                     
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 33 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      () => covModel.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group col");
                __builder2.AddMarkupContent(41, "<label>Order quantity:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateInputNumber_2(__builder2, 42, 43, "1", 44, "form-control", 45, 
#nullable restore
#line 37 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      covModel.OrderQuantity

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => covModel.OrderQuantity = __value, covModel.OrderQuantity)), 47, () => covModel.OrderQuantity);
                __builder2.AddMarkupContent(48, "\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateValidationMessage_3(__builder2, 49, 50, 
#nullable restore
#line 38 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      () => covModel.OrderQuantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group col");
                __builder2.AddMarkupContent(54, "<label>Money paid</label>\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateInputNumber_4(__builder2, 55, 56, "0", 57, "form-control", 58, 
#nullable restore
#line 42 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      covModel.MoneyAmountReceived

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => covModel.MoneyAmountReceived = __value, covModel.MoneyAmountReceived)), 60, () => covModel.MoneyAmountReceived);
                __builder2.AddMarkupContent(61, "\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateValidationMessage_5(__builder2, 62, 63, 
#nullable restore
#line 43 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      () => covModel.MoneyAmountReceived

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group col");
                __builder2.AddMarkupContent(67, "<label>Apples added:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateInputNumber_6(__builder2, 68, 69, "0.0", 70, "0.5", 71, "form-control", 72, 
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      covModel.AppleQuantity

#line default
#line hidden
#nullable disable
                , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => covModel.AppleQuantity = __value, covModel.AppleQuantity)), 74, () => covModel.AppleQuantity);
                __builder2.AddMarkupContent(75, "\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateValidationMessage_7(__builder2, 76, 77, 
#nullable restore
#line 48 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      () => covModel.AppleQuantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group col");
                __builder2.AddMarkupContent(81, "<label>Melons added:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateInputNumber_8(__builder2, 82, 83, "0.0", 84, "0.5", 85, "form-control", 86, 
#nullable restore
#line 52 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      covModel.MelonQuantity

#line default
#line hidden
#nullable disable
                , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => covModel.MelonQuantity = __value, covModel.MelonQuantity)), 88, () => covModel.MelonQuantity);
                __builder2.AddMarkupContent(89, "\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateValidationMessage_9(__builder2, 90, 91, 
#nullable restore
#line 53 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      () => covModel.MelonQuantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n        ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group col");
                __builder2.AddMarkupContent(95, "<label>Oranges added:</label>\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateInputNumber_10(__builder2, 96, 97, "0.0", 98, "0.5", 99, "form-control", 100, 
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      covModel.OrangeQuantity

#line default
#line hidden
#nullable disable
                , 101, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => covModel.OrangeQuantity = __value, covModel.OrangeQuantity)), 102, () => covModel.OrangeQuantity);
                __builder2.AddMarkupContent(103, "\r\n            ");
                __Blazor.Blazor.WebSPA.View.Components.CustomerOrder.TypeInference.CreateValidationMessage_11(__builder2, 104, 105, 
#nullable restore
#line 58 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
                                      () => covModel.OrangeQuantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n\r\n        \r\n\r\n        ");
                __builder2.AddMarkupContent(107, "<div class=\"text-left\"><button type=\"submit\" class=\"btn btn-success mr-1\">PROCESS ORDER</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\Presentation\Client\Blazor.WebSPA\View\Components\CustomerOrder.razor"
       

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

    private void ResetFieledValues()
    {
        covModel.Id = 1;
        covModel.MoneyAmountReceived = 0;
        covModel.OrderQuantity = 1;
        covModel.AppleQuantity = 0;
        covModel.MelonQuantity = 0;
        covModel.OrangeQuantity = 0;
    }

    private void HandleValidSubmit()
    {
        Dictionary<string, decimal> fruits = new();
        fruits.Add("Apple", covModel.AppleQuantity);
        fruits.Add("Melon", covModel.MelonQuantity);
        fruits.Add("Orange", covModel.OrangeQuantity);

        var result = fruitPressService.Produce(homeViewModel.Recipe, fruits, covModel.MoneyAmountReceived, covModel.OrderQuantity);

        if (result.FirstOrDefault().Substring(0, 1) == "E")
        {
            homeViewModel.StatusBG = "#F8D7DA";
            homeViewModel.StatusFC = "#A22029";
        }
        else
        {
            homeViewModel.StatusBG = "#C2F5C7";
            homeViewModel.StatusFC = "green";
        }

        homeViewModel.ProductionResult = String.Join("\n", result.ToArray());
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
namespace __Blazor.Blazor.WebSPA.View.Components.CustomerOrder
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ValueExpression", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "step", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "step", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "step", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
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
