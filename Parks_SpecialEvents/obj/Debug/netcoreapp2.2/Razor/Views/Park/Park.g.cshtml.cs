#pragma checksum "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d7ce5071ab0eeeb0a83ec23dd54bfeacbf81f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Park_Park), @"mvc.1.0.view", @"/Views/Park/Park.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Park/Park.cshtml", typeof(AspNetCore.Views_Park_Park))]
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
#line 1 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/_ViewImports.cshtml"
using Parks_SpecialEvents;

#line default
#line hidden
#line 2 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/_ViewImports.cshtml"
using Parks_SpecialEvents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d7ce5071ab0eeeb0a83ec23dd54bfeacbf81f1", @"/Views/Park/Park.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Park_Park : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2, 268, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d7ce5071ab0eeeb0a83ec23dd54bfeacbf81f13280", async() => {
                BeginContext(8, 255, true);
                WriteLiteral("\r\n    <style>\r\n        /* Set the size of the div element that contains the map */\r\n        #map {\r\n            height: 400px; /* The height is 400 pixels */\r\n            width: 100%; /* The width is the width of the web page */\r\n        }\r\n    </style>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(270, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(272, 5079, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d7ce5071ab0eeeb0a83ec23dd54bfeacbf81f14709", async() => {
                BeginContext(278, 109, true);
                WriteLiteral("\r\n    <!-- QUICK NAVS-->\r\n    <div>\r\n        <center>\r\n            <h3 style=\"color:navy; font-weight:bold;\">");
                EndContext();
                BeginContext(388, 24, false);
#line 15 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
                                                 Write(Model.AzurePark.ParkName);

#line default
#line hidden
                EndContext();
                BeginContext(412, 517, true);
                WriteLiteral(@"</h3>
            <br />


            <nav>
                <a class=""btn btn-light"" href=""#Amenities"" style=""button"">Amenities</a>
                <a class=""btn btn-light"" href=""#Hours"">Hours</a>
                <a class=""btn btn-light"" href=""#CalendarEvents"">Calendar Events</a>
            </nav>
        </center>
    </div>
    <br />

    <!-- START OF CAROUSEL -->

    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
");
                EndContext();
#line 32 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
              
        int count = 0;
            

#line default
#line hidden
                BeginContext(984, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 35 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
             foreach (string image in Model.AzureParkImages.ImagesPaths)
            {

            if (count == 0)
            {

#line default
#line hidden
                BeginContext(1119, 71, true);
                WriteLiteral("            <li data-target=\"#carouselExampleIndicators\" data-slide-to=");
                EndContext();
                BeginContext(1191, 5, false);
#line 40 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
                                                                  Write(count);

#line default
#line hidden
                EndContext();
                BeginContext(1196, 23, true);
                WriteLiteral(" class=\"active\"></li>\r\n");
                EndContext();
#line 41 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1267, 71, true);
                WriteLiteral("            <li data-target=\"#carouselExampleIndicators\" data-slide-to=");
                EndContext();
                BeginContext(1339, 5, false);
#line 44 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
                                                                  Write(count);

#line default
#line hidden
                EndContext();
                BeginContext(1344, 8, true);
                WriteLiteral("></li>\r\n");
                EndContext();
#line 45 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
            }
            count++;
            }

#line default
#line hidden
                BeginContext(1404, 55, true);
                WriteLiteral("        </ol>\r\n\r\n        <div class=\"carousel-inner\">\r\n");
                EndContext();
#line 51 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
              
                int c = 0;
            

#line default
#line hidden
                BeginContext(1518, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 55 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
             foreach (string image in Model.AzureParkImages.ImagesPaths)
            {
                if (c == 0)
                {

#line default
#line hidden
                BeginContext(1657, 106, true);
                WriteLiteral("                    <div class=\"carousel-item active\">\r\n                        <img class=\"d-block w-100\"");
                EndContext();
                BeginWriteAttribute("src", " src=", 1763, "", 1787, 1);
#line 60 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
WriteAttributeValue("", 1768, Url.Content(image), 1768, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1787, 64, true);
                WriteLiteral(" alt=\"First slide\" height=\"570\" />\r\n                    </div>\r\n");
                EndContext();
#line 62 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1911, 99, true);
                WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img class=\"d-block w-100\"");
                EndContext();
                BeginWriteAttribute("src", " src=", 2010, "", 2034, 1);
#line 66 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
WriteAttributeValue("", 2015, Url.Content(image), 2015, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2034, 65, true);
                WriteLiteral(" alt=\"Second slide\" height=\"570\" />\r\n                    </div>\r\n");
                EndContext();
#line 68 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
                }
                c++;
            }

#line default
#line hidden
                BeginContext(2155, 783, true);
                WriteLiteral(@"
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

    <!-- END OF CAROUSEL -->
    <!-- START OF PARK AMENITIES-->
    <br />
    <br />
    <br />

    <div>
        <left>
            <text style=""color:black;"">Address: </text>
            <text style=""color:navy; font-weight:bold;"">");
                EndContext();
                BeginContext(2939, 23, false);
#line 92 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
                                                   Write(Model.AzurePark.Address);

#line default
#line hidden
                EndContext();
                BeginContext(2962, 522, true);
                WriteLiteral(@"</text>
            <br />
            <text style=""color:black;"">Phone Number: </text>
            <!--


        <h5 style=""color:navy; font-weight:bold;"">Phone Number: Unavailable</h5>



        <h5 style=""color:navy; font-weight:bold;""></h5>

    -->
            <br />

        </left>
    </div>


    <div>
        <center>
            <h4 id=""Amenities"" style=""color:navy; font-weight:bold;"">Special Event Amenities</h4>
            <br />

        </center>
        <div class=""row"">

");
                EndContext();
#line 119 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
             foreach (Parks_SpecialEvents.Models.Amenity amenity in Model.Amenitys)
            {

#line default
#line hidden
                BeginContext(3584, 124, true);
                WriteLiteral("                <div class=\"col col-2\">\r\n                    <center>\r\n                        <img width=\"150\" height=\"100\"");
                EndContext();
                BeginWriteAttribute("src", " src=", 3708, "", 3740, 1);
#line 123 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
WriteAttributeValue("", 3713, Url.Content(amenity.Image), 3713, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3740, 37, true);
                WriteLiteral(" />\r\n                        <strong>");
                EndContext();
                BeginContext(3778, 12, false);
#line 124 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
                           Write(amenity.Amen);

#line default
#line hidden
                EndContext();
                BeginContext(3790, 98, true);
                WriteLiteral("</strong>\r\n                        <br />\r\n                    </center>\r\n                </div>\r\n");
                EndContext();
#line 128 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
            }

#line default
#line hidden
                BeginContext(3903, 247, true);
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <!-- END OF PARK AMENITIES-->\r\n    <!--The div element for the map -->\r\n    <div id=\"map\"></div>\r\n    <script>\r\n// Initialize and add the map\r\nfunction initMap() {\r\n  // The location of Uluru\r\n  var uluru = {lat: ");
                EndContext();
                BeginContext(4151, 19, false);
#line 139 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
               Write(Model.AzurePark.Lat);

#line default
#line hidden
                EndContext();
                BeginContext(4170, 7, true);
                WriteLiteral(", lng: ");
                EndContext();
                BeginContext(4178, 19, false);
#line 139 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
                                          Write(Model.AzurePark.Lng);

#line default
#line hidden
                EndContext();
                BeginContext(4197, 584, true);
                WriteLiteral(@"};
  // The map, centered at Uluru
  var map = new google.maps.Map(
      document.getElementById('map'), {zoom: 15, center: uluru});
  // The marker, positioned at Uluru
  var marker = new google.maps.Marker({position: uluru, map: map});
}
    </script>
    <!--Load the API from the specified URL
    * The async attribute allows the browser to render the page while the API loads
    * The key parameter will contain your own API key (which is not needed for this tutorial)
    * The callback parameter executes the initMap() function
    -->

    <script async defer");
                EndContext();
                BeginWriteAttribute("src", "\r\n            src=\"", 4781, "\"", 4881, 3);
                WriteAttributeValue("", 4800, "https://maps.googleapis.com/maps/api/js?key=", 4800, 44, true);
#line 154 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Park/Park.cshtml"
WriteAttributeValue("", 4844, ViewData["api_key"], 4844, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 4864, "&callback=initMap", 4864, 17, true);
                EndWriteAttribute();
                BeginContext(4882, 462, true);
                WriteLiteral(@"></script>

    <!-- GOOGLE CALENDAR -->
    <iframe src=""https://calendar.google.com/calendar/embed?height=600&amp;wkst=1&amp;bgcolor=%23ffffff&amp;ctz=America%2FLos_Angeles&amp;src=cWg0YzYyMThscm12bzkwcjM3ZnBiajRyaW9AZ3JvdXAuY2FsZW5kYXIuZ29vZ2xlLmNvbQ&amp;src=ZW4udXNhI2hvbGlkYXlAZ3JvdXAudi5jYWxlbmRhci5nb29nbGUuY29t&amp;color=%23A87070&amp;color=%231F753C"" style=""border: solid 1px #777"" width=""1100"" height=""800"" frameborder=""0"" scrolling=""no""></iframe>
");
                EndContext();
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
            EndContext();
            BeginContext(5351, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(5532, 20, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
