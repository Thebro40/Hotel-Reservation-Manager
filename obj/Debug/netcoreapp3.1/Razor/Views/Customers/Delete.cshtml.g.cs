#pragma checksum "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26083265967d82a2bfbaa888a280e4f14e56d640"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Delete), @"mvc.1.0.view", @"/Views/Customers/Delete.cshtml")]
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
#line 1 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Rooms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Reservations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.ViewModels.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26083265967d82a2bfbaa888a280e4f14e56d640", @"/Views/Customers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2ac5192730e40aafc67085f36c7642116c721c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
  
    ViewData["Title"] = "Delete Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Are you sure you want to delete this customer?</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26083265967d82a2bfbaa888a280e4f14e56d6407090", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26083265967d82a2bfbaa888a280e4f14e56d6407360", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 11 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
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
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26083265967d82a2bfbaa888a280e4f14e56d6409065", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 12 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
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
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 14 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 15 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 18 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 19 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 22 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 23 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 26 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAdult));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 27 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayFor(model => model.IsAdult));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 30 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 31 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26083265967d82a2bfbaa888a280e4f14e56d64015536", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\it kariera\Module 13\Hotel-Reservation-Manager\Hotel-Reservation-Manager\Views\Customers\Delete.cshtml"
      
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