#pragma checksum "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f406b7375d7a64fc93fb1b99fb8e87e9c52049f"
// <auto-generated/>
#pragma warning disable 1591
namespace BOMTool.V.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1><p><fore color=\"DarkBlue\"> BOM TOOL  !</fore></p></h1>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        Hello, ");
                __builder2.AddContent(4, 
#nullable restore
#line 8 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Index.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(5, "!\r\n        Here is the list of your claims:\r\n        ");
                __builder2.OpenElement(6, "ul");
#nullable restore
#line 11 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Index.razor"
             foreach (var claim in context.User.Claims)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(7, "li");
                __builder2.OpenElement(8, "b");
                __builder2.AddContent(9, 
#nullable restore
#line 13 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Index.razor"
                        claim.Type

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(10, ":");
                __builder2.AddContent(11, 
#nullable restore
#line 13 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Index.razor"
                                        claim.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 14 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(12, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "<p> Sorry Not Authenticate Try Again</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
