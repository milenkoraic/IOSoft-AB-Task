#pragma checksum "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "739e870d97d08ea4c4930ca111bd324e46000528"
// <auto-generated/>
#pragma warning disable 1591
namespace LemonadeStand.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-bck3t4qk15");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"/\" b-bck3t4qk15>Lemonade Stand AB</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-bck3t4qk15");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-bck3t4qk15></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-bck3t4qk15");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-bck3t4qk15");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-bck3t4qk15");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<i class=\"fab fa-houzz\" style=\"font-size:22px;\" b-bck3t4qk15></i>");
                __builder2.AddMarkupContent(26, "<span class=\"nav-link-text\" b-bck3t4qk15>Hemsida</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddAttribute(30, "b-bck3t4qk15");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "glass");
            __builder.AddEventPreventDefaultAttribute(34, "onclick", true);
            __builder.AddAttribute(35, "style", "opacity:0.75;");
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "<i class=\"fas fa-ice-cream\" style=\"font-size:22px;\" b-bck3t4qk15></i>");
                __builder2.AddMarkupContent(38, "<span class=\"nav-link-text\" b-bck3t4qk15>Glass</span><i class=\"fas fa-lock\" style=\"font-size:14px; margin-left:10px;\" b-bck3t4qk15></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "nav-item px-3");
            __builder.AddAttribute(42, "b-bck3t4qk15");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "nav-link");
            __builder.AddAttribute(45, "href", "coktail");
            __builder.AddEventPreventDefaultAttribute(46, "onclick", true);
            __builder.AddAttribute(47, "style", "opacity:0.75;");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(49, "<i class=\"fas fa-cocktail\" style=\"font-size:22px;\" b-bck3t4qk15></i>");
                __builder2.AddMarkupContent(50, "<span class=\"nav-link-text\" b-bck3t4qk15>Cocktail</span><i class=\"fas fa-lock\" style=\"font-size:14px; margin-left:10px;\" b-bck3t4qk15></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "li");
            __builder.AddAttribute(53, "class", "nav-item px-3");
            __builder.AddAttribute(54, "b-bck3t4qk15");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
            __builder.AddAttribute(56, "class", "nav-link");
            __builder.AddAttribute(57, "href", "juice");
            __builder.AddEventPreventDefaultAttribute(58, "onclick", true);
            __builder.AddAttribute(59, "style", "opacity:0.75;");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(61, "<i class=\"fas fa-blender\" style=\"font-size:22px;\" b-bck3t4qk15></i>");
                __builder2.AddMarkupContent(62, "<span class=\"nav-link-text\" b-bck3t4qk15>Juice</span><i class=\"fas fa-lock\" style=\"font-size:14px; margin-left:10px;\" b-bck3t4qk15></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "li");
            __builder.AddAttribute(65, "class", "nav-item px-3");
            __builder.AddAttribute(66, "b-bck3t4qk15");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(67);
            __builder.AddAttribute(68, "class", "nav-link");
            __builder.AddAttribute(69, "href", "recipes");
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "<i class=\"fas fa-receipt\" style=\"font-size:22px;\" b-bck3t4qk15></i>");
                __builder2.AddMarkupContent(72, "<span class=\"nav-link-text\" b-bck3t4qk15>Recepthantering</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.OpenElement(74, "li");
            __builder.AddAttribute(75, "class", "nav-item px-3");
            __builder.AddAttribute(76, "b-bck3t4qk15");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(77);
            __builder.AddAttribute(78, "class", "nav-link");
            __builder.AddAttribute(79, "href", "kundorder");
            __builder.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(81, "<i class=\"fas fa-cash-register\" style=\"font-size:22px;\" b-bck3t4qk15></i>");
                __builder2.AddMarkupContent(82, "<span class=\"nav-link-text\" b-bck3t4qk15>Kundorder</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
            __builder.AddMarkupContent(84, "<div class=\"provider-branding\" b-bck3t4qk15><span style=\"font-size:12px;\" b-bck3t4qk15>POWERED BY</span>\r\n    <img src=\"/img/brand/provider/iosoft-logo.png\" class=\"provider-logo\" b-bck3t4qk15></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591