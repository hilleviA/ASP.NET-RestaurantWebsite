#pragma checksum "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa20927eedaad0e4eee01ec7509ab47da37d5e3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Details), @"mvc.1.0.view", @"/Views/Bookings/Details.cshtml")]
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
#line 1 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\_ViewImports.cshtml"
using ThePlate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\_ViewImports.cshtml"
using ThePlate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa20927eedaad0e4eee01ec7509ab47da37d5e3b", @"/Views/Bookings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aa012081fe4694df0ed6f9972ab7bca645ab80d", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThePlate.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("crudLinks"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"infoSection sectionWidth\">\r\n    <h2>Överblick</h2>\r\n    <div class=\"detailView\">\r\n        <h3>Bokning</h3>\r\n        <h4>");
#nullable restore
#line 11 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 12 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
      Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n        <h4>");
#nullable restore
#line 14 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 15 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
      Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n        <h4>");
#nullable restore
#line 17 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
      Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <h4>");
#nullable restore
#line 20 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 21 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
      Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <h4>");
#nullable restore
#line 23 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 24 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
      Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <h4>");
#nullable restore
#line 26 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DinnerTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 27 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
      Write(Html.DisplayFor(model => model.DinnerTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <h4>");
#nullable restore
#line 29 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.guestAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 30 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
      Write(Html.DisplayFor(model => model.guestAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n    <div class=\"backLink\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa20927eedaad0e4eee01ec7509ab47da37d5e3b8663", async() => {
                WriteLiteral("Redigera");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Reserv\ThePlate\ThePlate\Views\Bookings\Details.cshtml"
                                                 WriteLiteral(Model.BookingId);

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
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa20927eedaad0e4eee01ec7509ab47da37d5e3b10946", async() => {
                WriteLiteral("Tillbaka");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThePlate.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
