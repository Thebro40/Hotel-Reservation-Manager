#pragma checksum "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "420d16bb5b9759c9ec2b43e6f88bdae8a53dd6ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Rooms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Reservations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420d16bb5b9759c9ec2b43e6f88bdae8a53dd6ed", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea676a86219aaca145fa09ff95ff2c5fdba0b5b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Customer Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div class=\"row\">\n    <div class=\"col-md-4\">\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 12 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReservationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 13 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReservationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 16 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 17 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 20 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 21 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 24 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 25 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 28 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAdult));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 29 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAdult));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 32 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 33 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "420d16bb5b9759c9ec2b43e6f88bdae8a53dd6ed10783", async() => {
                WriteLiteral("<i class=\"fa-solid fa-pen-to-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "420d16bb5b9759c9ec2b43e6f88bdae8a53dd6ed13038", async() => {
                WriteLiteral("<i class=\"fa-solid fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <section>\n");
#nullable restore
#line 41 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
         if (Model.History.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h4>
                Reservations history: 
            </h4>
            <table class=""table table-striped table-hover ""
               style=""border-radius: 10px; overflow: hidden;"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Accommodation Date</th>
                        <th>Leave Date</th>
                        <th>Price</th>
                        <th>Room</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 57 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
                     foreach (var history in Model.History)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 61 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model=>history.ResAccomDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 64 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model=>history.ResLeaveDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 67 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model=>history.ResPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 70 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model=>history.ResRoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 73 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n");
#nullable restore
#line 76 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\n</div>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "420d16bb5b9759c9ec2b43e6f88bdae8a53dd6ed18899", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 84 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Customers\Details.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
