#pragma checksum "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b4392a6a804b9189c8d57eadf68cca1f40be08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAQ_Search), @"mvc.1.0.view", @"/Views/FAQ/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FAQ/Search.cshtml", typeof(AspNetCore.Views_FAQ_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b4392a6a804b9189c8d57eadf68cca1f40be08", @"/Views/FAQ/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 343, true);
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

<center>
    <h2>Frequently Asked Questions</h2>
</center>

<!--
    SEARCH FOR SPECIFIC QUESTION OR TOPIC
-->
<div class=""d-flex justify-content-center mt-3"">
    ");
            EndContext();
            BeginContext(343, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b4392a6a804b9189c8d57eadf68cca1f40be084972", async() => {
                BeginContext(390, 131, true);
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
            BeginContext(528, 232, true);
            WriteLiteral("\r\n</div>\r\n\r\n<!--\r\n   PARKS WITH PERMITS TO HOLD SPECIFIC REQUIREMENTS:\r\n    EX. PARKS THAT CAN HOLD ALCOHOL\r\n    OR PARKS THAT CAN HOLD MUSIC FESTIVALS\r\n-->\r\n\r\n<!-- DYNAMIC BUTTON FOR PERMIBABLE PARKS-->\r\n    <p>\r\n        <center>\r\n");
            EndContext();
#line 38 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
             foreach (Parks_SpecialEvents.Models.Event e in ViewBag.storePermitables)
    {

#line default
#line hidden
            BeginContext(854, 65, true);
            WriteLiteral("        <a class=\"btn btn-info btn-sm m-1\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 919, "\"", 934, 2);
            WriteAttributeValue("", 926, "#", 926, 1, true);
#line 40 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
WriteAttributeValue("", 927, e.Href, 927, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(935, 83, true);
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n            ");
            EndContext();
            BeginContext(1019, 3, false);
#line 41 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
       Write(e.P);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 16, true);
            WriteLiteral("\r\n        </a>\r\n");
            EndContext();
#line 43 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
}

#line default
#line hidden
            BeginContext(1041, 31, true);
            WriteLiteral("        </center>\r\n    </p>\r\n\r\n");
            EndContext();
#line 47 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
 foreach(Parks_SpecialEvents.Models.Event e in ViewBag.storePermitables) {


#line default
#line hidden
            BeginContext(1150, 25, true);
            WriteLiteral("    <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1175, "\"", 1187, 1);
#line 49 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
WriteAttributeValue("", 1180, e.Href, 1180, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1188, 83, true);
            WriteLiteral(">\r\n        <div class=\"card card-body\">\r\n            <center>\r\n                <h3>");
            EndContext();
            BeginContext(1272, 3, false);
#line 52 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
               Write(e.P);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 43, true);
            WriteLiteral("</h3>\r\n            </center>\r\n           \r\n");
            EndContext();
#line 55 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
             foreach (Parks_SpecialEvents.Models.Park p in ViewBag.storeParks.parks)
            {
                

#line default
#line hidden
#line 57 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
                 if (p.Permitables == e.P)
                {

#line default
#line hidden
            BeginContext(1482, 83, true);
            WriteLiteral("                    <div class=\"thumbnail col-sm-4 py-2\">\r\n                        ");
            EndContext();
            BeginContext(1565, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b4392a6a804b9189c8d57eadf68cca1f40be0810451", async() => {
                BeginContext(1632, 59, true);
                WriteLiteral("\r\n                            <img height=\"300\" width=\"450\"");
                EndContext();
                BeginWriteAttribute("src", " src=", 1691, "", 1704, 1);
#line 61 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
WriteAttributeValue("", 1696, p.Image, 1696, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1704, 29, true);
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
#line 60 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
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
            BeginContext(1737, 116, true);
            WriteLiteral("\r\n                        <div class=\"caption post-content\">\r\n                            <h3 style=\"color: white;\">");
            EndContext();
            BeginContext(1854, 10, false);
#line 64 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
                                                 Write(p.ParkName);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 67, true);
            WriteLiteral("</h3>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 67 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
                }

#line default
#line hidden
#line 67 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1965, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 72 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"

}

#line default
#line hidden
            BeginContext(2000, 132, true);
            WriteLiteral("\r\n<!-- END OF DYNAMIC PERMITABLE PARKS-->\r\n\r\n\r\n<!-- DISPLAY SEARCHED QUESTIONS-->\r\n<div class=\"containter\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 81 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
          int counter = 1;

#line default
#line hidden
            BeginContext(2161, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 82 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
         foreach (Parks_SpecialEvents.Models.Question i in @ViewBag.storing.questions)
        {

#line default
#line hidden
            BeginContext(2260, 119, true);
            WriteLiteral("            <div class=\"col-sm-4 py-2\">\r\n                <div id=\"accordion\">\r\n                    <div class=\"card\">\r\n");
            EndContext();
#line 87 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
                          
                            string c = counter.ToString();
                            string dataTarget = "#collapse" + c;
                            string idForCollapse = "collapse" + c;
                            string heading = "heading" + c;
                        

#line default
#line hidden
            BeginContext(2689, 48, true);
            WriteLiteral("                        <div class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2737, "", 2749, 1);
#line 93 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
WriteAttributeValue("", 2741, heading, 2741, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2749, 146, true);
            WriteLiteral(">\r\n                            <h5 class=\"mb-0\">\r\n                                <button class=\"btn btn-link\" data-toggle=\"collapse\" data-target=");
            EndContext();
            BeginContext(2896, 10, false);
#line 95 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
                                                                                           Write(dataTarget);

#line default
#line hidden
            EndContext();
            BeginContext(2906, 21, true);
            WriteLiteral(" aria-expanded=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=", 2927, "", 2956, 1);
#line 95 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
WriteAttributeValue("", 2942, idForCollapse, 2942, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2956, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(2996, 3, false);
#line 96 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
                               Write(i.Q);

#line default
#line hidden
            EndContext();
            BeginContext(2999, 142, true);
            WriteLiteral("\r\n                                </button>\r\n                            </h5>\r\n                        </div>\r\n\r\n                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=", 3141, "", 3159, 1);
#line 101 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
WriteAttributeValue("", 3145, idForCollapse, 3145, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3159, 22, true);
            WriteLiteral(" class=\"collapse hide\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=", 3181, "", 3206, 1);
#line 101 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
WriteAttributeValue("", 3198, heading, 3198, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3206, 113, true);
            WriteLiteral(" data-parent=\"#accordion\">\r\n                            <div class=\"card-body\">\r\n                                ");
            EndContext();
            BeginContext(3320, 8, false);
#line 103 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
                           Write(i.Answer);

#line default
#line hidden
            EndContext();
            BeginContext(3328, 142, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 109 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Search.cshtml"
            counter++;
        }

#line default
#line hidden
            BeginContext(3505, 140, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<address>\r\n    <strong>\r\n        <a href=\"mailto:josejesusgarciajr@gmail.com\">Contact</a>\r\n    </strong>\r\n</address>\r\n");
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