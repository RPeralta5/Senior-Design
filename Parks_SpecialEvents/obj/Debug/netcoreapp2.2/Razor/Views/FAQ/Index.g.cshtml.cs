#pragma checksum "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afbd4acdb5c6e9e0971163a4259c65eb51e20298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAQ_Index), @"mvc.1.0.view", @"/Views/FAQ/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FAQ/Index.cshtml", typeof(AspNetCore.Views_FAQ_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afbd4acdb5c6e9e0971163a4259c65eb51e20298", @"/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parks_SpecialEvents.Models.Question>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FAQ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Park", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ParkAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 664, true);
            WriteLiteral(@"
<style>
    .post-content {
        top: 0;
        left: 0;
        position: absolute;
    }

    .thumbnail {
        position: relative;
    }
</style>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
   <script>
       $(Document).ready(function () {
           $(""p"").each(function (index, value) {
               $(""p"").eq(index).html($(""p"").eq(index).text());
           });
       });
   </script>

<center>
    <h2>Frequently Asked Questions</h2>
</center>
<title>FAQ</title>

<!--
    SEARCH FOR SPECIFIC QUESTION OR TOPIC
-->
<div class=""d-flex justify-content-center mt-3"">
    ");
            EndContext();
            BeginContext(708, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afbd4acdb5c6e9e0971163a4259c65eb51e202985323", async() => {
                BeginContext(755, 131, true);
                WriteLiteral("\r\n        <strong>Search: </strong>\r\n        <input name=\"search\" />\r\n        <input type=\"submit\" class=\"btn btn-primary\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(893, 232, true);
            WriteLiteral("\r\n</div>\r\n\r\n<!--\r\n   PARKS WITH PERMITS TO HOLD SPECIFIC REQUIREMENTS:\r\n    EX. PARKS THAT CAN HOLD ALCOHOL\r\n    OR PARKS THAT CAN HOLD MUSIC FESTIVALS\r\n-->\r\n\r\n<!-- DYNAMIC BUTTON FOR PERMIBABLE PARKS-->\r\n    <p>\r\n        <center>\r\n");
            EndContext();
#line 49 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
             foreach (Parks_SpecialEvents.Models.Event e in ViewBag.storePermitables)
    {

#line default
#line hidden
            BeginContext(1219, 65, true);
            WriteLiteral("        <a class=\"btn btn-info btn-sm m-1\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1284, "\"", 1299, 2);
            WriteAttributeValue("", 1291, "#", 1291, 1, true);
#line 51 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 1292, e.Href, 1292, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1300, 83, true);
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n            ");
            EndContext();
            BeginContext(1384, 3, false);
#line 52 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
       Write(e.P);

#line default
#line hidden
            EndContext();
            BeginContext(1387, 16, true);
            WriteLiteral("\r\n        </a>\r\n");
            EndContext();
#line 54 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1406, 31, true);
            WriteLiteral("        </center>\r\n    </p>\r\n\r\n");
            EndContext();
#line 58 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
 foreach(Parks_SpecialEvents.Models.Event e in ViewBag.storePermitables) {


#line default
#line hidden
            BeginContext(1515, 25, true);
            WriteLiteral("    <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1540, "\"", 1552, 1);
#line 60 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 1545, e.Href, 1545, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1553, 83, true);
            WriteLiteral(">\r\n        <div class=\"card card-body\">\r\n            <center>\r\n                <h3>");
            EndContext();
            BeginContext(1637, 3, false);
#line 63 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
               Write(e.P);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 43, true);
            WriteLiteral("</h3>\r\n            </center>\r\n           \r\n");
            EndContext();
#line 66 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
             foreach (Parks_SpecialEvents.Models.Park p in ViewBag.storeParks.parks)
            {
                

#line default
#line hidden
#line 68 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                 if (p.Permitables == e.P)
                {

#line default
#line hidden
            BeginContext(1847, 69, true);
            WriteLiteral("                    <div class=\"thumbnail\">\r\n                        ");
            EndContext();
            BeginContext(1916, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afbd4acdb5c6e9e0971163a4259c65eb51e2029810787", async() => {
                BeginContext(1983, 59, true);
                WriteLiteral("\r\n                            <img height=\"300\" width=\"450\"");
                EndContext();
                BeginWriteAttribute("src", " src=", 2042, "", 2068, 1);
#line 72 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 2047, Url.Content(p.Image), 2047, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2068, 29, true);
                WriteLiteral(" />\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                                                                         WriteLiteral(p.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2101, 116, true);
            WriteLiteral("\r\n                        <div class=\"caption post-content\">\r\n                            <h3 style=\"color: white;\">");
            EndContext();
            BeginContext(2218, 10, false);
#line 75 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                                                 Write(p.ParkName);

#line default
#line hidden
            EndContext();
            BeginContext(2228, 67, true);
            WriteLiteral("</h3>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 78 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                }

#line default
#line hidden
#line 78 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(2329, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 83 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"

}

#line default
#line hidden
            BeginContext(2364, 170, true);
            WriteLiteral("\r\n<!-- END OF DYNAMIC PERMITABLE PARKS-->\r\n\r\n<!--\r\n    DISPLAY ALL QUESTIONS:\r\n     SINCE THIS IS THE INDEX PAGE\r\n-->\r\n\r\n<div class=\"containter\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 95 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
          int counter = 1;

#line default
#line hidden
            BeginContext(2563, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 96 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
         foreach (Parks_SpecialEvents.Models.Question i in @ViewBag.storing.questions)
        {

#line default
#line hidden
            BeginContext(2662, 119, true);
            WriteLiteral("            <div class=\"col-sm-4 py-2\">\r\n                <div id=\"accordion\">\r\n                    <div class=\"card\">\r\n");
            EndContext();
#line 101 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                          
                            string c = counter.ToString();
                            string dataTarget = "#collapse" + c;
                            string idForCollapse = "collapse" + c;
                            string heading = "heading" + c;
                        

#line default
#line hidden
            BeginContext(3091, 48, true);
            WriteLiteral("                        <div class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 3139, "", 3151, 1);
#line 107 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 3143, heading, 3143, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3151, 146, true);
            WriteLiteral(">\r\n                            <h5 class=\"mb-0\">\r\n                                <button class=\"btn btn-link\" data-toggle=\"collapse\" data-target=");
            EndContext();
            BeginContext(3298, 10, false);
#line 109 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                                                                                           Write(dataTarget);

#line default
#line hidden
            EndContext();
            BeginContext(3308, 21, true);
            WriteLiteral(" aria-expanded=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=", 3329, "", 3358, 1);
#line 109 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 3344, idForCollapse, 3344, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3358, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(3398, 3, false);
#line 110 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                               Write(i.Q);

#line default
#line hidden
            EndContext();
            BeginContext(3401, 142, true);
            WriteLiteral("\r\n                                </button>\r\n                            </h5>\r\n                        </div>\r\n\r\n                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=", 3543, "", 3561, 1);
#line 115 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 3547, idForCollapse, 3547, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3561, 22, true);
            WriteLiteral(" class=\"collapse hide\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=", 3583, "", 3608, 1);
#line 115 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 3600, heading, 3600, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3608, 116, true);
            WriteLiteral(" data-parent=\"#accordion\">\r\n                            <div class=\"card-body\">\r\n                                <p>");
            EndContext();
            BeginContext(3725, 8, false);
#line 117 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                              Write(i.Answer);

#line default
#line hidden
            EndContext();
            BeginContext(3733, 146, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 123 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
            counter++;
        }

#line default
#line hidden
            BeginContext(3914, 159, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<!-- CONTACT INFORMATION-->\r\n<address>\r\n    <strong>\r\n        <a href=\"mailto:EMAIL@gmail.com\">Contact</a>\r\n    </strong>\r\n</address>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parks_SpecialEvents.Models.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
