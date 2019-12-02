#pragma checksum "C:\Users\airsh\Documents\GitHub\Senior-Design\Parks_SpecialEvents\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd5d418c2721e25375f1c8ea1db6a33ed0bd1dae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registration.cshtml", typeof(AspNetCore.Views_Home_Registration))]
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
#line 1 "C:\Users\airsh\Documents\GitHub\Senior-Design\Parks_SpecialEvents\Views\_ViewImports.cshtml"
using Parks_SpecialEvents;

#line default
#line hidden
#line 2 "C:\Users\airsh\Documents\GitHub\Senior-Design\Parks_SpecialEvents\Views\_ViewImports.cshtml"
using Parks_SpecialEvents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd5d418c2721e25375f1c8ea1db6a33ed0bd1dae", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\airsh\Documents\GitHub\Senior-Design\Parks_SpecialEvents\Views\Home\Registration.cshtml"
  
    ViewData["Title"] = "Registration";

#line default
#line hidden
            BeginContext(50, 5275, true);
            WriteLiteral(@"
<center>
    <h1>Los Angeles County Department of Parks and Recreation</h1>

    <h3>COMMERCIAL/SPECIAL EVENT APPLICATION</h3>
</center>

<h4>
    THE FOLLOWING INFORMATION IS NEEDED BY PARK STAFF IN ORDER TO PROCESS THE COMMERCIAL/SPECIAL EVENT APPLICATION AND QUOTE THE FEES AND INSURANCE REQUIRED FOR THE EVENT. THIS COMMERCIAL/SPECIAL EVENT APPLICATION WILL BE SUBMITTED TO THE SUPERINTENDENT WITH APPROVAL FROM THE COUNTY OF LOS ANGELES. THIS FORM MUST BE COMPLETED (90) NINTY DAYS
    PRIOR TO THE EVENT. IF NOT, YOUR EVENT MAY BE DENIED. BE RETURNED FOR COMPLETION.
</h4>

<div>

    <h4>Applicant Information</h4>

    <p>1) Named Insured is a:</p>

    <div class=""row"">
        <div class=""col-md-3"">
            <input type=""radio"" name=""insured"" /> Individual <br />
            <input type=""radio"" name=""insured"" /> Corporation <br />
            <input type=""radio"" name=""insured"" /> Trust or Estate <br />
            <input type=""radio"" name=""insured"" /> Unincorporated Association <b");
            WriteLiteral(@"r />
            <input type=""radio"" name=""insured"" /> General Partnership <br />
        </div>
        <div class=""col-md-3"">
            <input type=""radio"" name=""insured"" /> LLC or LLP <br />
            <input type=""radio"" name=""insured"" /> Public Agency <br />
            <input type=""radio"" name=""insured"" /> Labor Union <br />
            <input type=""radio"" name=""insured"" /> Informal Group or Committee <br />
        </div>
        <div class=""col-mid-3"">
            <input type=""radio"" name=""insured"" /> Limited Partnership <br />
            <input type=""radio"" name=""insured"" /> Not-for-Profit <br />
            <input type=""radio"" name=""insured"" /> Religious Organization <br />
            <input type=""radio"" name=""insured"" /> Joint Venture <br />
            <input type=""radio"" name=""insured"" /> Other: <input />
        </div>
    </div>

    <br />
    2) Named Insured (as it is to appear on the policy): <input name=""nameInsuredPolicy"" /> <br />

    <br />
    3) Doing Busin");
            WriteLiteral(@"ess as (DBA): <input name=""dba"" /> <br />

    <br />
    4) Mailing Address: <input name=""address"" /> <br />

    <br />
    5) City: <input name=""city"" /> State: <input name=""state"" /> Zip: <input name=""zip"" />
    <br />

    <br />
    6) Contact Person: <input name=""contactPerson"" /> <br />

    <br />
    7) E-Mail Address: <input name=""email"" /> <br />

    <br />
    8) Telephone Number (Home): <input name=""phoneNumber"" value=""(xxx) xxx-xxxx"" /> <br />

    <br />
    9) Telephone Number (Business): <input name=""businessNumber"" value=""(xxx) xxx-xxxx"" /> <br />

    <br />
    10) Fax Number: <input name=""fax"" /> <br />

    <br />
    11) Web Site Address: <input name=""website"" /> <br />
</div>

<br />
<div>
    <h4>Event Information</h4>
    1) Name of Event: <input name=""eventName"" /> <br />

    <br />
    2) List each date the event will be held, the hours the event is open on each day and the total expected attendance. Include event set up, take down and clean up");
            WriteLiteral(@" days. Indicate if alcoholic beverages will be sold or served for each day.
    (Attach a separate page if necessary.)
    <div class=""row"">
        <div class=""col-md-3"">
            Date
            <br /> ------------------------------ <br />
            <input /> <br />
            <input /> <br />
            <input /> <br />
            <input /> <br />
        </div>
        <div class=""col-md-3"">
            Event Hours
            <br /> ------------------------------ <br />
            <input /> <br />
            <input /> <br />
            <input /> <br />
            <input /> <br />
        </div>

        <div class=""col-md-3"">
            Attendence (Expected)
            <br /> ------------------------------ <br />
            <input /> <br />
            <input /> <br />
            <input /> <br />
            <input /> <br />
        </div>
        <div class=""col-md-3"">
            Alcoholic Beverages
            <br /> ---Serverd--------Sold----- <br />
  ");
            WriteLiteral(@"          <input type=""radio"" name=""r1served"" /> Yes <input type=""radio"" name=""r1served"" /> No <input type=""radio"" name=""r1sold"" /> Yes <input type=""radio"" name=""r1sold"" /> No <br />
            <input type=""radio"" name=""r2served"" /> Yes <input type=""radio"" name=""r2served"" /> No <input type=""radio"" name=""r2sold"" /> Yes <input type=""radio"" name=""r2sold"" /> No <br />
            <input type=""radio"" name=""r3served"" /> Yes <input type=""radio"" name=""r3served"" /> No <input type=""radio"" name=""r3sold"" /> Yes <input type=""radio"" name=""r3sold"" /> No <br />
            <input type=""radio"" name=""r4served"" /> Yes <input type=""radio"" name=""r4served"" /> No <input type=""radio"" name=""r4sold"" /> Yes <input type=""radio"" name=""r4sold"" /> No <br />
        </div>

    </div>

    <br />
    3) Describe the event and list all activities. Attach a separate page if necessary.
    If the event is more than one day, include the date(s) each activity occurs.
    <br />

    <textarea></textarea>

    <br />
    4) Is th");
            WriteLiteral("e Named Insured the: <br />\r\n\r\n    Business Owner: <input type=\"radio\" name=\"businessOwner\" /> Yes <input type=\"radio\" name=\"businessOwner\" /> No\r\n\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
