#pragma checksum "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0fbbfeda8acdd188b690dbfbcaf50d5335e06c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Administration_AllReservations), @"mvc.1.0.view", @"/Areas/Administration/Views/Administration/AllReservations.cshtml")]
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
#line 1 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\_ViewImports.cshtml"
using RoyalTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\_ViewImports.cshtml"
using RoyalTravel.Areas.Administration.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0fbbfeda8acdd188b690dbfbcaf50d5335e06c", @"/Areas/Administration/Views/Administration/AllReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76afdf25e4759eb10ba83e52bacbb23ab81e29ab", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administration_Views_Administration_AllReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RoyalTravel.Areas.Administration.ViewModels.ReservationsViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelRes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
  
    ViewData["Title"] = "AllReservations";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <table class=""table table-borderless"">
        <thead class=""text-center"">
            <tr>
                <th scope=""col"">Confirmation Number</th>
                <th scope=""col"">Booked On</th>
                <th scope=""col"">Money Spend</th>
                <th scope=""col"">Arrival Date</th>
                <th scope=""col"">Departure Date</th>
                <th scope=""col"">Price/night</th>
                <th scope=""col"">Total Price</th>
                <th scope=""col"">Points Earned</th>
                <th scope=""col"">Hotel Name</th>
                <th scope=""col"">Username</th>
                <th scope=""col"">Adults</th>
                <th scope=""col"">Children</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
             foreach (var res in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\n                    <td>");
#nullable restore
#line 28 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.ConfirmationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.BookedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 30 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.MoneySpend);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 31 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.ArrivalDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.DepartureDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 33 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.PricePerNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 34 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 35 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.PointsEarned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 36 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 37 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 38 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.Adults);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 39 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                   Write(res.Children);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n");
#nullable restore
#line 41 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                         if (@res.Darrival <= res.BookedOn)
                        {
                            
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab0fbbfeda8acdd188b690dbfbcaf50d5335e06c10890", async() => {
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab0fbbfeda8acdd188b690dbfbcaf50d5335e06c11179", async() => {
                    WriteLiteral("Cancel<span class=\"ml-1\"><i class=\"fas fa-times\"></i></span>\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-stayId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                                   WriteLiteral(res.StayId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["stayId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-stayId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["stayId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n");
#nullable restore
#line 52 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n            </tr>\n");
#nullable restore
#line 55 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Areas\Administration\Views\Administration\AllReservations.cshtml"
           
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n    <a class=\"text-center btn btn-outline-danger\" href=\"##\" onClick=\"history.go(-1); return false;\"> Go Back</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RoyalTravel.Areas.Administration.ViewModels.ReservationsViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
