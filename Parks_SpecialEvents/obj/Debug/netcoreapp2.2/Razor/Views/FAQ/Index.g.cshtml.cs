#pragma checksum "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9806a9fe455285c7fa3cf4d47c726ad1255267b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9806a9fe455285c7fa3cf4d47c726ad1255267b", @"/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parks_SpecialEvents.Models.Question>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FAQ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 764, true);
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

   <title>FAQ</title>
   <center>
       <h2 style=""color:navy; font-weight:bold;"">Frequently Asked Questions</h2>
       <br />
       
       

       <!--
        SEARCH FOR SPECIFIC QUESTION OR TOPIC
    -->
       <div class=""d-flex justify-content-center mt-3"">
           ");
            EndContext();
            BeginContext(808, 274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9806a9fe455285c7fa3cf4d47c726ad1255267b4689", async() => {
                BeginContext(855, 220, true);
                WriteLiteral("\r\n               <strong><font size=\"5\">Search for a topic or question: </font></strong>\r\n               <input name=\"search\" />\r\n               <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" />\r\n           ");
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
            BeginContext(1082, 368, true);
            WriteLiteral(@"
       </div>
       <br />
   </center>

<!--
   PARKS WITH PERMITS TO HOLD SPECIFIC REQUIREMENTS:
    EX. PARKS THAT CAN HOLD ALCOHOL
    OR PARKS THAT CAN HOLD MUSIC FESTIVALS
-->



<!-- END OF DYNAMIC PERMITABLE PARKS-->

<!--
    DISPLAY ALL QUESTIONS:
     SINCE THIS IS THE INDEX PAGE
-->

<div class=""containter"">
    <div class=""row"">
");
            EndContext();
#line 62 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
          int counter = 1;

#line default
#line hidden
            BeginContext(1479, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 63 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
         foreach (Parks_SpecialEvents.Models.Question i in @ViewBag.storing.questions)
        {

#line default
#line hidden
            BeginContext(1578, 119, true);
            WriteLiteral("            <div class=\"col-sm-4 py-2\">\r\n                <div id=\"accordion\">\r\n                    <div class=\"card\">\r\n");
            EndContext();
#line 68 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                          
                            string c = counter.ToString();
                            string dataTarget = "#collapse" + c;
                            string idForCollapse = "collapse" + c;
                            string heading = "heading" + c;
                        

#line default
#line hidden
            BeginContext(2007, 48, true);
            WriteLiteral("                        <div class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2055, "", 2067, 1);
#line 74 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 2059, heading, 2059, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2067, 192, true);
            WriteLiteral(" style=\"height: 150px; background-color: navy\">\r\n                            <h5 class=\"mb-0\">\r\n                                <button class=\"btn btn-link\" data-toggle=\"collapse\" data-target=");
            EndContext();
            BeginContext(2260, 10, false);
#line 76 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                                                                                           Write(dataTarget);

#line default
#line hidden
            EndContext();
            BeginContext(2270, 21, true);
            WriteLiteral(" aria-expanded=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=", 2291, "", 2320, 1);
#line 76 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 2306, idForCollapse, 2306, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2320, 62, true);
            WriteLiteral(">\r\n                                    <font color=\"white\"><b>");
            EndContext();
            BeginContext(2383, 3, false);
#line 77 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                                                      Write(i.Q);

#line default
#line hidden
            EndContext();
            BeginContext(2386, 153, true);
            WriteLiteral("</b></font>\r\n                                </button>\r\n                            </h5>\r\n                        </div>\r\n\r\n                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=", 2539, "", 2557, 1);
#line 82 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 2543, idForCollapse, 2543, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2557, 22, true);
            WriteLiteral(" class=\"collapse hide\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=", 2579, "", 2604, 1);
#line 82 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
WriteAttributeValue("", 2596, heading, 2596, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2604, 116, true);
            WriteLiteral(" data-parent=\"#accordion\">\r\n                            <div class=\"card-body\">\r\n                                <p>");
            EndContext();
            BeginContext(2721, 8, false);
#line 84 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
                              Write(i.Answer);

#line default
#line hidden
            EndContext();
            BeginContext(2729, 146, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 90 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/FAQ/Index.cshtml"
            counter++;
        }

#line default
#line hidden
            BeginContext(2910, 159, true);
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
