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
#nullable restore
#line 20 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\_Imports.razor"
using Faso.Blazor.SpinKit;

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
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(4);
                __builder2.AddAttribute(5, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 2 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                        ColumnSize.Is8

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.Heading>(8);
                    __builder3.AddAttribute(9, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.HeadingSize>(
#nullable restore
#line 3 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                       HeadingSize.Is4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(11, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Icon>(12);
                        __builder4.AddAttribute(13, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                         Icon

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(14, "\r\n            ");
                        __builder4.AddContent(15, 
#nullable restore
#line 5 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
             Text

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(16, "\r\n");
#nullable restore
#line 6 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
             if (IsLoading)
            {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(17, "                <i class=\"fas fa-spin fa-spinner\" style=\"margin-left: 10px;\"></i>\r\n");
#nullable restore
#line 9 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
            }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(18, "        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(21);
                __builder2.AddAttribute(22, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 12 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                        ColumnSize.Is4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Display", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentDisplay>(
#nullable restore
#line 13 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
                     Display.Inline

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.Container>(26);
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(28, "\r\n            ");
                        __builder4.AddContent(29, 
#nullable restore
#line 15 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Components\PageTitle.razor"
             ChildContent

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(30, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n");
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
