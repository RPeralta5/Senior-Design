#pragma checksum "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2ab8c710e4ad6b35b42927f23f220c0cbde0a20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateParkRazor), @"mvc.1.0.view", @"/Views/Admin/UpdateParkRazor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateParkRazor.cshtml", typeof(AspNetCore.Views_Admin_UpdateParkRazor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2ab8c710e4ad6b35b42927f23f220c0cbde0a20", @"/Views/Admin/UpdateParkRazor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateParkRazor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 224, true);
            WriteLiteral("\r\n<link href=\"https://gitcdn.github.io/bootstrap-toggle/2.2.2/css/bootstrap-toggle.min.css\" rel=\"stylesheet\">\r\n<script src=\"https://gitcdn.github.io/bootstrap-toggle/2.2.2/js/bootstrap-toggle.min.js\"></script>\r\n\r\n<h2>Update ");
            EndContext();
            BeginContext(225, 16, false);
#line 5 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
      Write(ViewBag.ParkName);

#line default
#line hidden
            EndContext();
            BeginContext(241, 40, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"container\">\r\n\r\n    ");
            EndContext();
            BeginContext(281, 913, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2ab8c710e4ad6b35b42927f23f220c0cbde0a204586", async() => {
                BeginContext(332, 27, true);
                WriteLiteral("\r\n        <h3>Events</h3>\r\n");
                EndContext();
#line 11 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
          
            List<Event> events = new List<Event>();
        

#line default
#line hidden
                BeginContext(435, 33, true);
                WriteLiteral("        <div class=\"container\">\r\n");
                EndContext();
#line 15 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
             foreach(Parks_SpecialEvents.Models.Event e in ViewBag.Events)
            {

#line default
#line hidden
                BeginContext(559, 48, true);
                WriteLiteral("                <br />\r\n                <strong>");
                EndContext();
                BeginContext(608, 3, false);
#line 18 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
                   Write(e.P);

#line default
#line hidden
                EndContext();
                BeginContext(611, 11, true);
                WriteLiteral("</strong>\r\n");
                EndContext();
#line 19 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
                 if(e.Flag == 1)
                {

#line default
#line hidden
                BeginContext(675, 71, true);
                WriteLiteral("                    <input type=\"checkbox\" checked data-toggle=\"toggle\"");
                EndContext();
                BeginWriteAttribute("name", " name=\'", 746, "\'", 760, 1);
#line 21 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
WriteAttributeValue("", 753, e.Href, 753, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(761, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 22 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
                    events.Add(new Event(e.P, "", 1));
                } else
                {

#line default
#line hidden
                BeginContext(862, 63, true);
                WriteLiteral("                    <input type=\"checkbox\" data-toggle=\"toggle\"");
                EndContext();
                BeginWriteAttribute("name", " name=", 925, "", 938, 1);
#line 25 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
WriteAttributeValue("", 931, e.Href, 931, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(938, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 26 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
                    events.Add(new Event(e.P, "", 0));
                }

#line default
#line hidden
#line 27 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
                 
            }

#line default
#line hidden
                BeginContext(1030, 44, true);
                WriteLiteral("        </div>\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1074, "", 1088, 1);
#line 30 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateParkRazor.cshtml"
WriteAttributeValue("", 1081, events, 1081, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1088, 99, true);
                WriteLiteral(" name=\"events\" />\r\n        <input type=\"submit\" value=\"Update Park\" class=\"btn btn-success\"/>\r\n    ");
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
            BeginContext(1194, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
