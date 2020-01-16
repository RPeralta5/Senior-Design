#pragma checksum "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad6058e516e0d1621283d4866e975653a9d6477a"
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
#line 1 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\_ViewImports.cshtml"
using Parks_SpecialEvents;

#line default
#line hidden
#line 2 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\_ViewImports.cshtml"
using Parks_SpecialEvents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad6058e516e0d1621283d4866e975653a9d6477a", @"/Views/FAQ/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad6058e516e0d1621283d4866e975653a9d6477a4366", async() => {
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
            BeginContext(528, 339, true);
            WriteLiteral(@"
</div>

<!--
   PARKS WITH PERMITS TO HOLD SPECIFIC REQUIREMENTS:
    EX. PARKS THAT CAN HOLD ALCOHOL
    OR PARKS THAT CAN HOLD MUSIC FESTIVALS
-->

<!-- DYNAMIC BUTTON FOR PERMIBABLE PARKS-->


<!-- END OF DYNAMIC PERMITABLE PARKS-->


<!-- DISPLAY SEARCHED QUESTIONS-->
<div class=""containter"">
    <div class=""row"">
");
            EndContext();
#line 44 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
          int counter = 1;

#line default
#line hidden
            BeginContext(896, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 45 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
         foreach (Parks_SpecialEvents.Models.Question i in @ViewBag.storing.questions)
        {

#line default
#line hidden
            BeginContext(995, 119, true);
            WriteLiteral("            <div class=\"col-sm-4 py-2\">\r\n                <div id=\"accordion\">\r\n                    <div class=\"card\">\r\n");
            EndContext();
#line 50 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
                          
                            string c = counter.ToString();
                            string dataTarget = "#collapse" + c;
                            string idForCollapse = "collapse" + c;
                            string heading = "heading" + c;
                        

#line default
#line hidden
            BeginContext(1424, 48, true);
            WriteLiteral("                        <div class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1472, "", 1484, 1);
#line 56 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
WriteAttributeValue("", 1476, heading, 1476, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1484, 192, true);
            WriteLiteral(" style=\"height: 150px; background-color: navy\">\r\n                            <h5 class=\"mb-0\">\r\n                                <button class=\"btn btn-link\" data-toggle=\"collapse\" data-target=");
            EndContext();
            BeginContext(1677, 10, false);
#line 58 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
                                                                                           Write(dataTarget);

#line default
#line hidden
            EndContext();
            BeginContext(1687, 21, true);
            WriteLiteral(" aria-expanded=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=", 1708, "", 1737, 1);
#line 58 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
WriteAttributeValue("", 1723, idForCollapse, 1723, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1737, 62, true);
            WriteLiteral(">\r\n                                    <font color=\"white\"><b>");
            EndContext();
            BeginContext(1800, 3, false);
#line 59 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
                                                      Write(i.Q);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 153, true);
            WriteLiteral("</b></font>\r\n                                </button>\r\n                            </h5>\r\n                        </div>\r\n\r\n                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=", 1956, "", 1974, 1);
#line 64 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
WriteAttributeValue("", 1960, idForCollapse, 1960, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1974, 22, true);
            WriteLiteral(" class=\"collapse hide\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=", 1996, "", 2021, 1);
#line 64 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
WriteAttributeValue("", 2013, heading, 2013, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2021, 113, true);
            WriteLiteral(" data-parent=\"#accordion\">\r\n                            <div class=\"card-body\">\r\n                                ");
            EndContext();
            BeginContext(2135, 8, false);
#line 66 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
                           Write(i.Answer);

#line default
#line hidden
            EndContext();
            BeginContext(2143, 142, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 72 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\FAQ\Search.cshtml"
            counter++;
        }

#line default
#line hidden
            BeginContext(2320, 140, true);
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
