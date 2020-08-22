#pragma checksum "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73b67440e6d4d0dc6b373e0e90507c77df21078f"
// <auto-generated/>
#pragma warning disable 1591
namespace SoccerLeagueTransferApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using SoccerLeagueTransferApp.Shared;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
using SoccerLeagueTransferApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/club-detail")]
    public partial class ClubDetail : SoccerLeagueTransferApp.Pages.ClubDetailComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Club Detail");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 14 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                  canEdit==true

#line default
#line hidden
                ));
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                          Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(21);
                __builder2.AddAttribute(22, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                     getClubDetailsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SoccerLeagueTransferApp.Models.ConData.ClubDetail>(this, 
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                                                                                                 Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(27, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(29);
                    __builder3.AddAttribute(30, "Property", "TeamID");
                    __builder3.AddAttribute(31, "Title", "Team ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(33);
                    __builder3.AddAttribute(34, "Property", "TeamName");
                    __builder3.AddAttribute(35, "Title", "Team Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(37);
                    __builder3.AddAttribute(38, "Property", "HomeGround");
                    __builder3.AddAttribute(39, "Title", "Home Ground");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(41);
                    __builder3.AddAttribute(42, "Property", "RegisteredOfficeAddress");
                    __builder3.AddAttribute(43, "Title", "Registered Office Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(45);
                    __builder3.AddAttribute(46, "Property", "ContactEmail");
                    __builder3.AddAttribute(47, "Title", "Contact Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(49);
                    __builder3.AddAttribute(50, "Property", "ContactTelephone");
                    __builder3.AddAttribute(51, "Title", "Contact Telephone");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(53);
                    __builder3.AddAttribute(54, "Property", "ClubLogo");
                    __builder3.AddAttribute(55, "Title", "Club Logo");
                    __builder3.AddAttribute(56, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.ClubDetail>)((soccerLeagueTransferAppModelsConDataClubDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(57, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(58);
                        __builder4.AddAttribute(59, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                     soccerLeagueTransferAppModelsConDataClubDetail.ClubLogo

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(60, "style", "height: 50px; width: 50px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(63);
                    __builder3.AddAttribute(64, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 36 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                    false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 36 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                     false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(66, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 36 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(67, "Width", "70px");
                    __builder3.AddAttribute(68, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.ClubDetail>)((soccerLeagueTransferAppModelsConDataClubDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(69, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(70);
                        __builder4.AddAttribute(71, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(72, "Icon", "close");
                        __builder4.AddAttribute(73, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(74, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                               canEdit==true

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(75, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                                        (args) =>GridDeleteButtonClick(args, soccerLeagueTransferAppModelsConDataClubDetail)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(76, "onclick", 
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                                                                                                                                                         true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(79, (__value) => {
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<SoccerLeagueTransferApp.Models.ConData.ClubDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
