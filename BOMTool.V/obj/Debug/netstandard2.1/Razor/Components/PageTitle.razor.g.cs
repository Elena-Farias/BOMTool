#pragma checksum "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e9d8cf534394dd32caa0baede160edc3b8d01e8"
// <auto-generated/>
#pragma warning disable 1591
namespace BOMTool.V.Components
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
    public partial class PageTitle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Row>(0);
            __builder.AddAttribute(1, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 1 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
              Padding.Is4.OnAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Column>(3);
                __builder2.AddAttribute(4, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 2 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                        ColumnSize.Is8

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Heading>(6);
                    __builder3.AddAttribute(7, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.HeadingSize>(
#nullable restore
#line 3 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                       HeadingSize.Is4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Icon>(9);
                        __builder4.AddAttribute(10, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                         Icon

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(11, "\r\n            ");
                        __builder4.AddContent(12, 
#nullable restore
#line 5 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
             Text

#line default
#line hidden
#nullable disable
                        );
#nullable restore
#line 6 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
             if (IsLoading)
            {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(13, "<i class=\"fas fa-spin fa-spinner\" style=\"margin-left: 10px;\"></i>");
#nullable restore
#line 9 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(15);
                __builder2.AddAttribute(16, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 12 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                        ColumnSize.Is4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Display", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentDisplay>(
#nullable restore
#line 13 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                     Display.Inline

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Container>(19);
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(21, 
#nullable restore
#line 15 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
             ChildContent

#line default
#line hidden
#nullable disable
                        );
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
#nullable restore
#line 20 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
       
    [Parameter]
    public string Text { get; set; }

    [Parameter]
    public IconName Icon { get; set; }
    [Parameter]
    public bool IsLoading { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
