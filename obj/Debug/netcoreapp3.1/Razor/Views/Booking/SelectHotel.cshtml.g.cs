#pragma checksum "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4d55e37f71db2cb6c39c4ed852e3aaa7841823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_SelectHotel), @"mvc.1.0.view", @"/Views/Booking/SelectHotel.cshtml")]
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
#line 1 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\_ViewImports.cshtml"
using RoyalTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\_ViewImports.cshtml"
using RoyalTravel.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4d55e37f71db2cb6c39c4ed852e3aaa7841823", @"/Views/Booking/SelectHotel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e58aeb9d30cbe84571f0e682d738db15534d61a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Booking_SelectHotel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoyalTravel.ViewModels.Booking.SelectedHotelViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TableSelectedHotel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
  
    ViewData["Title"] = "Hotel";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4d55e37f71db2cb6c39c4ed852e3aaa78418235895", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d4d55e37f71db2cb6c39c4ed852e3aaa78418236326", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d4d55e37f71db2cb6c39c4ed852e3aaa78418237503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4d55e37f71db2cb6c39c4ed852e3aaa78418239384", async() => {
                WriteLiteral(@"
        <div class=""container-fluid"">
            <div class=""icon-bar"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">Free Wifi</th>
                            <th scope=""col"">Free Breakfast</th>
                            <th scope=""col"">Free Parking</th>
                            <th scope=""col"">Restaurant On-site</th>
                            <th scope=""col"">Pool</th>
                            <th scope=""col"">Airport Shuttle</th>
                            <th scope=""col"">Local Shuttle</th>
                            <th scope=""col"">Fitness Center</th>
                            <th scope=""col"">Pet-Friendly</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td scope=""row"">
");
#nullable restore
#line 36 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.WiFi)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-wifi fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 39 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-wifi\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 43 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 46 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.Breakfast)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-coffee fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 49 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-coffee fa-3x\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 53 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 56 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.Parking)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-parking fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 59 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-parking fa-3x\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 63 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 66 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.Restaurant)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-utensils fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 69 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-utensils fa-3x\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 73 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 76 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.Pool)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-swimming-pool fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 79 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-swimming-pool fa-3x\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 83 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 86 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.AirportShuttle)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-plane-arrival fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 89 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-plane-arrival fa-3x\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 93 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 96 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.LocalShuttle)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-shuttle-van fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 99 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-shuttle-van fa-3x\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 103 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 106 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.FitnessCenter)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-dumbbell fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 109 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-dumbbell fa-3x\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 113 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 116 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                 if (Model.AllowPets)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-paw fa-3x\" style=\"color:#1B902E\"></i>\n");
#nullable restore
#line 119 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-paw fa-3x\" style=\"color:#9DA0A2\"></i>\n");
#nullable restore
#line 123 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </td>
                        </tr>

                    </tbody>
                </table>

            </div>
        </div>
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
");
#nullable restore
#line 135 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                     if (Model.RoomTypes.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Room Type</th>
                                    <th scope=""col"">Non-Smoking/Smoking</th>
                                    <th scope=""col"">Max Occupancy</th>
                                    <th scope=""col"">Description</th>
                                    <th scope=""col"">Price</th>
                                </tr>
                            </thead>
");
#nullable restore
#line 147 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                             foreach (var room in Model.RoomTypes)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tbody>\n                                    <tr>\n                                        <td>");
#nullable restore
#line 152 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                       Write(room.RoomType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 153 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                         if (room.Smoking)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>Smoking</td>\n");
#nullable restore
#line 156 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>Non-Smoking</td>\n");
#nullable restore
#line 160 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>");
#nullable restore
#line 161 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                       Write(room.MaxOccupancy);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        <td>
                                            <a id=""modal-892189"" href=""#modal-container-892189"" role=""button"" class=""btn"" data-toggle=""modal"">
                                                <i class=""fas fa-info-circle fa-2x"" style=""color:#6351ce""></i>
                                            </a>
                                            <div class=""modal fade"" id=""modal-container-892189"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                                                <div class=""modal-dialog"" role=""document"">
                                                    <div class=""modal-content"">
                                                        <div class=""modal-header"">
                                                            <h5 class=""modal-title text-center"" id=""myModalLabel"">
                                                                Room Details
                                                            </h");
                WriteLiteral(@"5>
                                                            <button type=""button"" class=""close"" data-dismiss=""modal"">
                                                                <span aria-hidden=""true"">×</span>
                                                            </button>
                                                        </div>
                                                        <div class=""modal-body"">
                                                            ");
#nullable restore
#line 178 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                                       Write(room.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </div>
                                                        <div class=""modal-footer"">
                                                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">
                                                                Close
                                                            </button>
                                                        </div>
                                                    </div>

                                                </div>

                                            </div>

                                        </td>
                                        <td>");
#nullable restore
#line 192 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                                       Write(room.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    </tr>\n                                </tbody>\n");
#nullable restore
#line 195 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </table>\n");
#nullable restore
#line 197 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                </div>
            </div>
        </div>
    
       
        <div class=""row"">
            <div class=""col-md-4"">
                <h2 class=""text-center"">
                    Property Info:
                </h2>
                <p>
                    ");
#nullable restore
#line 212 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
               Write(Model.Information);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </p>\n\n            </div>\n            <div class=\"col-md-4\">\n\n                <h2 class=\"text-center\">\n                    Description\n                </h2>\n                <p>\n                    ");
#nullable restore
#line 222 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </p>\n\n            </div>\n            <div class=\"col-md-4\">\n                <address>\n                    <br> ");
#nullable restore
#line 228 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\SelectHotel.cshtml"
                    Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>+961 649 269\n                </address>\n                \n            </div>\n        </div>\n        \n\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4d55e37f71db2cb6c39c4ed852e3aaa784182328607", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4d55e37f71db2cb6c39c4ed852e3aaa784182329705", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4d55e37f71db2cb6c39c4ed852e3aaa784182330803", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoyalTravel.ViewModels.Booking.SelectedHotelViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591