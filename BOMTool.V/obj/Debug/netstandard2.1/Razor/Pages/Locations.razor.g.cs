#pragma checksum "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac51fc36cd43af2c43ff06bd0cd4512f42ffb31e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Location")]
    public partial class Locations : Fluxor.Blazor.Web.Components.FluxorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
 if (LocationsState.Value.IsLoading)
{
    // <SpinKitPulse />
}

else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n            ");
                __builder2.AddMarkupContent(4, "<p> Sorry Not Authenticate Try Again</p>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.AddContent(6, "        ");
            __builder.OpenComponent<Blazorise.Column>(7);
            __builder.AddAttribute(8, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 18 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                            ColumnSize.Is12

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Blazorise.Heading>(11);
                __builder2.AddAttribute(12, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.HeadingSize>(
#nullable restore
#line 19 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                           HeadingSize.Is4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Location Catalog");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.AddContent(17, "        ");
            __builder.OpenComponent<Blazorise.DataGrid.DataGrid<Location>>(18);
            __builder.AddAttribute(19, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Location>>(
#nullable restore
#line 23 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                         LocationsState.Value.Currents

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "ShowPager", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                            20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<Location>>(26);
                __builder2.AddAttribute(27, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                     nameof(Location.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Caption", "Id");
                __builder2.AddAttribute(29, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                                                                 false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<Location>>(31);
                __builder2.AddAttribute(32, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                     nameof(Location.Name)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Caption", "Plant Name");
                __builder2.AddAttribute(34, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<Location>>(36);
                __builder2.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                     nameof(Location.Code)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Caption", "Location Code");
                __builder2.AddAttribute(39, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<Location>>(41);
                __builder2.AddAttribute(42, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                     nameof(Location.Active)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Caption", "Active");
                __builder2.AddAttribute(44, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                                                                         false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridCommandColumn<Location>>(46);
                __builder2.AddAttribute(47, "EditCommandAllowed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "EditCommandTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Blazorise.DataGrid.CommandContext<Location>>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n                    ");
                    __builder3.OpenComponent<Blazorise.Button>(50);
                    __builder3.AddAttribute(51, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 34 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                   Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 34 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                             () => ShowModal((context.Item as Location), false)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(54, "Edit");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\r\n                ");
                }
                ));
                __builder2.AddAttribute(56, "NewCommandTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Blazorise.DataGrid.CommandContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(57, "\r\n                    ");
                    __builder3.OpenComponent<Blazorise.Button>(58);
                    __builder3.AddAttribute(59, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 37 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                   Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 37 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                             () => ShowModal(new Location(), true)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(62, "New");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.AddContent(66, "        ");
            __builder.OpenComponent<Blazorise.Modal>(67);
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.OpenComponent<Blazorise.ModalBackdrop>(70);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenComponent<Blazorise.ModalContent>(72);
                __builder2.AddAttribute(73, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ModalSize>(
#nullable restore
#line 44 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                ModalSize.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "IsCentered", "true");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "\r\n                ");
                    __builder3.OpenComponent<Blazorise.ModalHeader>(77);
                    __builder3.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(79, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.ModalTitle>(80);
                        __builder4.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(82, "Location Data");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(83, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(84);
                        __builder4.AddAttribute(85, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 47 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                            () => modalRef.Hide()

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(86, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n                ");
                    __builder3.OpenComponent<Blazorise.ModalBody>(88);
                    __builder3.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(90, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.Field>(91);
                        __builder4.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(93, "\r\n                        ");
                            __builder5.OpenComponent<Blazorise.FieldLabel>(94);
                            __builder5.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(96, "Name");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(97, "\r\n                        ");
                            __builder5.OpenComponent<Blazorise.TextEdit>(98);
                            __builder5.AddAttribute(99, "Placeholder", "Name...");
                            __builder5.AddAttribute(100, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                                     selected.Name

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(101, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selected.Name = __value, selected.Name))));
                            __builder5.AddAttribute(102, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => selected.Name));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(103, "\r\n                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(104, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.Field>(105);
                        __builder4.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(107, "\r\n                        ");
                            __builder5.OpenComponent<Blazorise.FieldLabel>(108);
                            __builder5.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(110, "Location Code");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(111, "\r\n                        ");
                            __builder5.OpenComponent<Blazorise.TextEdit>(112);
                            __builder5.AddAttribute(113, "Placeholder", "Location code..");
                            __builder5.AddAttribute(114, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                                             selected.Code

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(115, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selected.Code = __value, selected.Code))));
                            __builder5.AddAttribute(116, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => selected.Code));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(117, "\r\n                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(118, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.Field>(119);
                        __builder4.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(121, "\r\n                        ");
                            __builder5.OpenComponent<Blazorise.Check<bool>>(122);
                            __builder5.AddAttribute(123, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 59 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                             selected.Active

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(124, "CheckedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selected.Active = __value, selected.Active))));
                            __builder5.AddAttribute(125, "CheckedExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => selected.Active));
                            __builder5.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(127, "Active");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(128, "\r\n                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(129, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.ModalFooter>(130);
                        __builder4.AddAttribute(131, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(132, "\r\n                        ");
                            __builder5.OpenComponent<Blazorise.Button>(133);
                            __builder5.AddAttribute(134, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 62 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                       Color.Light

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(135, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 62 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                               () => AddLocation()

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(136, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(137, "Save");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(138, "\r\n                        ");
                            __builder5.OpenComponent<Blazorise.Button>(139);
                            __builder5.AddAttribute(140, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 63 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                       Color.Warning

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(141, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 63 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                                                                 () => modalRef.Hide()

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(142, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(143, "Cancel");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(144, "\r\n                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(145, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(147, "\r\n        ");
            }
            ));
            __builder.AddComponentReferenceCapture(148, (__value) => {
#nullable restore
#line 42 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"
                     modalRef = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(149, "\r\n");
#nullable restore
#line 68 "C:\Code\BOMToolVS\BOMTool\BOMTool.V\Pages\Locations.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
