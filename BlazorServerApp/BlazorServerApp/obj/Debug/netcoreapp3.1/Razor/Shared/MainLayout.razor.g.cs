#pragma checksum "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d29c1b10f3a821e2ea0f8781854ae19fe2f2c524"
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
#nullable restore
#line 1 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Shared\MainLayout.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "nav");
            __builder.AddAttribute(4, "class", "navbar navbar-light bg-light");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-fluid");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.AddMarkupContent(9, "<a class=\"navbar-brand\" href=\"#\" style=\"font-weight:bold\">\n                <img src=\"../img/BfiechIS.jpg\" alt width=\"50\" height=\"30\" class=\"d-inline-block align-text-top\">\n                Young Publisher\n            </a>\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\n                    ");
                __builder2.AddMarkupContent(13, @"<div class=""navbardiv"" style=""font-size:17px"">
                        <ul style=""display:flex"">
                            <li><a href=""index"">Main</a></li>
                            <li><a href=""authors"">Author</a></li>
                            <li><a href=""publishers"">Publisher</a></li>
                            <li><a href=""books"">Book</a></li>
                            <li><a href=""bookusers"">Return page</a></li>
                        </ul>
                    </div>
                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "form");
            __builder.AddAttribute(16, "class", "d-flex");
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(18);
            __builder.AddAttribute(19, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "\n                            ");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "href", "/");
                __builder2.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Shared\MainLayout.razor"
                                                  (() => Logout())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(24, "Logout");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n                        ");
            }
            ));
            __builder.AddAttribute(26, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(27, "\n                            ");
                __builder2.AddMarkupContent(28, "<a href=\"/\">Login</a>\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "content px-4");
            __builder.AddMarkupContent(35, "\n        ");
            __builder.AddContent(36, 
#nullable restore
#line 45 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Shared\MainLayout.razor"
      
    public async Task Logout()
    {
        await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsLoggedOut();
        NavigationManager.NavigateTo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591