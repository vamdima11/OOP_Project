#pragma checksum "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Shared\CenteredCardLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10dc0d62e51c2d0ad55d1b18edf137865b19d48c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    public partial class CenteredCardLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-8");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddAttribute(7, "style", "width:500px");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.AddMarkupContent(9, "<div class=\"col-12\">\n                <img src=\"../img/BfiechIS.jpg\">\n            </div>\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.AddContent(13, 
#nullable restore
#line 11 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Shared\CenteredCardLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
