#pragma checksum "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f76e54936b9fe18768ede23db8c3cc86c6d7afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f76e54936b9fe18768ede23db8c3cc86c6d7afe", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea676a86219aaca145fa09ff95ff2c5fdba0b5b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "User Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row d-flex justify-content-center align-items-center h-100"">
    <div class=""col-lg-8 col-xl-6"">
        <h1 class=""text-center"">Details</h1>
        <div class=""card rounded-3"" style=""background-color:#F0F2F5"">
            <div class=""card-body p-4 p-md-5"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f76e54936b9fe18768ede23db8c3cc86c6d7afe7910", async() => {
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f76e54936b9fe18768ede23db8c3cc86c6d7afe8186", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 14 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f76e54936b9fe18768ede23db8c3cc86c6d7afe9928", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 15 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 17 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 18 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 21 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 22 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 25 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 26 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 29 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 30 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 33 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 34 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 37 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 38 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 41 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.UCN));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 42 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.UCN));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 45 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.HireDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 46 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.HireDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 49 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 50 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f76e54936b9fe18768ede23db8c3cc86c6d7afe18732", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-pen-to-square\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f76e54936b9fe18768ede23db8c3cc86c6d7afe21103", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-trash\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
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
                WriteLiteral("\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f76e54936b9fe18768ede23db8c3cc86c6d7afe24528", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
#line 66 "D:\it kariera\Module 13\HotelReservationManager\Hotel-Reservation-Manager-Overhaul1\Hotel-Reservation-Manager\Views\Users\Details.cshtml"
      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
