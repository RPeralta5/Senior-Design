#pragma checksum "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\Music\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cc09f3ef848c6b3b5ce4680609882a828de2946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music_Search), @"mvc.1.0.razor-page", @"/Views/Music/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Music/Search.cshtml", typeof(AspNetCore.Views_Music_Search), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cc09f3ef848c6b3b5ce4680609882a828de2946", @"/Views/Music/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Music_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 81, true);
            WriteLiteral("<h2>Search Music</h2>\n\n<table>\r\n    <tr>Artist</tr>\r\n    <tr>Active From</tr>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\Music\Search.cshtml"
     foreach (Parks_SpecialEvents.Models.Item item in ViewBag.storing.items)
    {

#line default
#line hidden
            BeginContext(176, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(199, 15, false);
#line 13 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\Music\Search.cshtml"
       Write(item.ArtistName);

#line default
#line hidden
            EndContext();
            BeginContext(214, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(234, 15, false);
#line 14 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\Music\Search.cshtml"
       Write(item.ActiveFrom);

#line default
#line hidden
            EndContext();
            BeginContext(249, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 16 "C:\Users\rpera\Documents\Cal State LA\2019-2020\Senior-Design\Parks_SpecialEvents\Views\Music\Search.cshtml"
    }

#line default
#line hidden
            BeginContext(274, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Music_Search> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Music_Search> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Music_Search>)PageContext?.ViewData;
        public Views_Music_Search Model => ViewData.Model;
    }
}
#pragma warning restore 1591
