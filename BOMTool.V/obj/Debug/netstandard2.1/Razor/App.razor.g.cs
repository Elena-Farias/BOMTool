#pragma checksum "C:\Code\BOMToolVS\BOMTool\BOMTool.V\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2048e2c8ec24f5f49df3df61c05add344e5aa4ea"
// <auto-generated/>
#pragma warning disable 1591
namespace BOMTool.V
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using BOMTool.V;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using BOMTool.V.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Fluxor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using BOMTool.M;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using BOMTool.V.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using BOMTool.M.DTOs;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Fluxor.Blazor.Web.StoreInitializer>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(4);
                __builder2.AddAttribute(5, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 3 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 5 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 5 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
#nullable restore
#line 7 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\App.razor"
                     if (!context.User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<BOMTool.V.Shared.RedirectToLogin>(11);
                        __builder4.CloseComponent();
#nullable restore
#line 10 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\App.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(12, "<p>You are not authorized to access this resource.</p>");
#nullable restore
#line 14 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\App.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(13, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(14);
                    __builder3.AddAttribute(15, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 19 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(17, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
