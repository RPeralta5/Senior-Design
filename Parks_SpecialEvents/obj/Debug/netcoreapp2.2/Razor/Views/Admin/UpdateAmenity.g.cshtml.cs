#pragma checksum "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cfc9eadf7df0f644df3148581b3d0cdd2cc1120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateAmenity), @"mvc.1.0.view", @"/Views/Admin/UpdateAmenity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateAmenity.cshtml", typeof(AspNetCore.Views_Admin_UpdateAmenity))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfc9eadf7df0f644df3148581b3d0cdd2cc1120", @"/Views/Admin/UpdateAmenity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateAmenity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "EMPTY", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 26, true);
            WriteLiteral("\n<h2>Update Amenity</h2>\n\n");
            EndContext();
            BeginContext(26, 2137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfc9eadf7df0f644df3148581b3d0cdd2cc11204408", async() => {
                BeginContext(75, 627, true);
                WriteLiteral(@"

    <a class=""btn btn-light"" data-toggle=""collapse"" href=""#singleAmenity"" role=""button"" aria-expanded=""false"" aria-controls=""singleAmenity"">
        Update a single Amenity
    </a>
    <a class=""btn btn-light"" data-toggle=""collapse"" href=""#allAmenity"" role=""button"" aria-expanded=""false"" aria-controls=""allAmenity"">
        Update all Amenities Named
    </a>

    <!-- UPDATE A SINGLE AMENITY -->
    <div class=""collapse"" id=""singleAmenity"">
        <div class=""card card-body"">
            <h3>Update a single Amenity</h3>
            <!-- SELECT A PARK -->
            <select name=""park"">
                ");
                EndContext();
                BeginContext(702, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfc9eadf7df0f644df3148581b3d0cdd2cc11205441", async() => {
                    BeginContext(724, 5, true);
                    WriteLiteral("Parks");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(738, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 20 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                 foreach (Parks_SpecialEvents.Models.Park park in ViewBag.Parks.parks)
                {

#line default
#line hidden
                BeginContext(847, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(867, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfc9eadf7df0f644df3148581b3d0cdd2cc11207245", async() => {
                    BeginContext(876, 13, false);
#line 22 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                       Write(park.ParkName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(898, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                }

#line default
#line hidden
                BeginContext(919, 146, true);
                WriteLiteral("            </select>\r\n\r\n            <br />\r\n\r\n            <!-- SELECT AN AMENITY -->\r\n            <select name=\"singleAmenity\">\r\n                ");
                EndContext();
                BeginContext(1065, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfc9eadf7df0f644df3148581b3d0cdd2cc11209030", async() => {
                    BeginContext(1087, 9, true);
                    WriteLiteral("Amenities");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1105, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                 foreach (Parks_SpecialEvents.Models.Amenity amenity in ViewBag.Amenities.amenities)
                {

#line default
#line hidden
                BeginContext(1228, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1248, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfc9eadf7df0f644df3148581b3d0cdd2cc112010856", async() => {
                    BeginContext(1257, 12, false);
#line 33 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                       Write(amenity.Amen);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1278, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                }

#line default
#line hidden
                BeginContext(1299, 505, true);
                WriteLiteral(@"            </select>

            <!-- SET NEW VALUES FOR THAT AMENITY-->
            Set Name: <input name=""setSingleName""/>
            Set Quanity: <input name=""setSingleQuanity""/>
        </div>
    </div>

    <!-- UPDATE ALL AMENITIES NAME = ""AMENITY NAME"" -->
    <div class=""collapse"" id=""allAmenity"">
        <div class=""card card-body"">
            <h3>Update all Amenities Named</h3>
            <!-- SELECT AN AMENITY -->
            <select name=""allAmenityNamed"">
                ");
                EndContext();
                BeginContext(1804, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfc9eadf7df0f644df3148581b3d0cdd2cc112013004", async() => {
                    BeginContext(1826, 9, true);
                    WriteLiteral("Amenities");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1844, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 50 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                 foreach (Parks_SpecialEvents.Models.Amenity amenity in ViewBag.Amenities.amenities)
                {

#line default
#line hidden
                BeginContext(1967, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1987, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfc9eadf7df0f644df3148581b3d0cdd2cc112014831", async() => {
                    BeginContext(1996, 12, false);
#line 52 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                       Write(amenity.Amen);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2017, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Admin/UpdateAmenity.cshtml"
                }

#line default
#line hidden
                BeginContext(2038, 118, true);
                WriteLiteral("            </select>\r\n        </div>\n    </div>\n\n    <input class=\"btn btn-warning\" type=\"submit\" value=\"UPDATE\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2163, 1, true);
            WriteLiteral("\n");
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
