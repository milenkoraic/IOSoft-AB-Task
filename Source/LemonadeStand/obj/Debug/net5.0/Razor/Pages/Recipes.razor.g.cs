#pragma checksum "C:\Users\Administrator\Desktop\IOSoft-AB-Task\Source\LemonadeStand\Pages\Recipes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a280c969de134b5801a54a2f9af566cf72cd813e"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipes")]
    public partial class Recipes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Tillgängliga recept</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"container mx-auto mt-4\"><div class=\"row\"><div class=\"col-md-4\"><div class=\"card\" style=\"width: 18rem;\"><img src=\"/img/recipes/Apple-Juice.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\"><h5 class=\"card-title\">Apple Lemonade</h5>\r\n                    <hr>\r\n                    <h6 class=\"card-subtitle mb-2\">Pris per glas:</h6>\r\n                    <p>10 SEK</p>\r\n                    <h6 class=\"card-text\">Frukt som behövs per glas:</h6>\r\n                    <p>2.5 Apple (s)</p>\r\n                    <a href=\"#\" class=\"btn mr-2 bg-warning\"><i class=\"fas fa-edit\"></i> Redigera</a>\r\n                    <a href=\"#\" class=\"btn bg-danger\"><i class=\"fa fa-minus-circle\"></i> Radera</a></div></div></div>\r\n        <div class=\"col-md-4\"><div class=\"card\" style=\"width: 18rem;\"><img src=\"/img/recipes/Melon-Juice.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\"><h5 class=\"card-title\">Melon Lemonade</h5>\r\n                    <hr>\r\n                    <h6 class=\"card-subtitle mb-2\">Pris per glas:</h6>\r\n                    <p>12 SEK</p>\r\n                    <h6 class=\"card-text\">Frukt som behövs per glas:</h6>\r\n                    <p>0.5 Melon (s)</p>\r\n                    <a href=\"#\" class=\"btn mr-2 bg-warning\"><i class=\"fas fa-edit\"></i> Redigera</a>\r\n                    <a href=\"#\" class=\"btn bg-danger\"><i class=\"fa fa-minus-circle\"></i> Radera</a></div></div></div>\r\n        <div class=\"col-md-4\"><div class=\"card\" style=\"width: 18rem;\"><img src=\"/img/recipes/Orange-Juice.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\"><h5 class=\"card-title\">Orange Lemonade</h5>\r\n                    <hr>\r\n                    <h6 class=\"card-subtitle mb-2\">Pris per glas:</h6>\r\n                    <p>9 SEK</p>\r\n                    <h6 class=\"card-text\">Frukt som behövs per glas:</h6>\r\n                    <p>1 Orange (s)</p>\r\n                    <a href=\"#\" class=\"btn mr-2 bg-warning\"><i class=\"fas fa-edit\"></i> Redigera</a>\r\n                    <a href=\"#\" class=\"btn bg-danger\"><i class=\"fa fa-minus-circle\"></i> Radera</a></div></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
