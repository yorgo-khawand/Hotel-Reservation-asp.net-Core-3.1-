#pragma checksum "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd3d38568ef54dc23b46a5d756ea602a993914e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Confirm), @"mvc.1.0.view", @"/Views/Booking/Confirm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd3d38568ef54dc23b46a5d756ea602a993914e", @"/Views/Booking/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e58aeb9d30cbe84571f0e682d738db15534d61a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Booking_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoyalTravel.ViewModels.Booking.ConfrimResViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
  
    ViewData["Title"] = "Confirm";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""></script>


<div class=""alert alert-success"" role=""alert"">
    <h4 class=""alert-heading text-center"">Thank you for making a reservation for <span class=""font-weight-bold"">");
#nullable restore
#line 11 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                                                                                           Write(Model.HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>!</h4>\n    <h4 class=\"text-center\">Your reservation has been confirmed!</h4>\n    <h4 class=\"alert-heading text-center\">Your confirmation number is: <span class=\"font-weight-bold\">");
#nullable restore
#line 13 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                                                                                 Write(Model.ConfirmationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h4>
    <hr>
    <p class=""mb-0 text-center"">Charges my apply for local amenities like safe warranties and telephone access. Modifications to the nummber of nights can change the rate! Check with our front desk for information!</p>
    <p class=""mb-0 text-center"">You can click on the <span class=""font-weight-bold"">Details</span> button below for additional information.</p>
</div>

<button data-toggle=""collapse"" data-target=""#details"" class=""btn btn-primary btn-lg btn-block"">Details</button>

<div id=""details"" class=""collapse"">
    <div class=""row font-weight-bold"">
        <div class=""card col-sm"" style=""width: 18rem;"">
            <ul class=""list-group list-group-flush text-center"">
                <li class=""list-group-item"">Hotel: ");
#nullable restore
#line 25 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                              Write(Model.HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\">Check In Time: ");
#nullable restore
#line 26 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                                      Write(Model.CheckInTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" h</li>\n                <li class=\"list-group-item\">Check Out Time: ");
#nullable restore
#line 27 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                                       Write(Model.CheckOutTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" h</li>\n            </ul>\n        </div>\n        <div class=\"card col-sm\" style=\"width: 18rem;\">\n            <ul class=\"list-group list-group-flush text-center\">\n                <li class=\"list-group-item\">Check In: ");
#nullable restore
#line 32 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                                 Write(Model.CheckIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\">Check Out: ");
#nullable restore
#line 33 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                                  Write(Model.CheckOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\">Nights: ");
#nullable restore
#line 34 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                               Write(Model.Nights);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ul>\n        </div>\n        <div class=\"card col-sm\" style=\"width: 18rem;\">\n            <ul class=\"list-group list-group-flush text-center\">\n                <li class=\"list-group-item\">Adults: ");
#nullable restore
#line 39 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                               Write(Model.Adults);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\">Children: ");
#nullable restore
#line 40 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                                 Write(Model.Children);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\">Booking Number: ");
#nullable restore
#line 41 "C:\Users\adam_\Desktop\Royal-Travel-master\RoyalTravel\Views\Booking\Confirm.cshtml"
                                                       Write(Model.ConfirmationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ul>\n        </div>\n\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoyalTravel.ViewModels.Booking.ConfrimResViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
