#pragma checksum "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc8c39f5b0bcb0ef07f51eace244c0b7c2ea2a9a"
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
#nullable restore
#line 18 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Faso.Blazor.SpinKit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/User")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Row>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Column>(2);
                __builder2.AddAttribute(3, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 4 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\User.razor"
                        ColumnSize.Is12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Heading>(5);
                    __builder3.AddAttribute(6, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.HeadingSize>(
#nullable restore
#line 5 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\User.razor"
                       HeadingSize.Is4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(8, "User Catalog");
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
