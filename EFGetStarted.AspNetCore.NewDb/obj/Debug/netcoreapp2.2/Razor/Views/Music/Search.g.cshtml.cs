#pragma checksum "/Users/jginvincible/Projects/EFGetStarted.AspNetCore.NewDb/Views/Music/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81c4bf922a826055f0a48d766556755adec64b9d"
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
#line 1 "/Users/jginvincible/Projects/EFGetStarted.AspNetCore.NewDb/Views/_ViewImports.cshtml"
using EFGetStarted.AspNetCore.NewDb;

#line default
#line hidden
#line 2 "/Users/jginvincible/Projects/EFGetStarted.AspNetCore.NewDb/Views/_ViewImports.cshtml"
using EFGetStarted.AspNetCore.NewDb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81c4bf922a826055f0a48d766556755adec64b9d", @"/Views/Music/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cb27665797f39a67346b5bbf3aa4027c4dccc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Music_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 81, true);
            WriteLiteral("<h2>Search Music</h2>\n\n<table>\r\n    <tr>Artist</tr>\r\n    <tr>Active From</tr>\r\n\r\n");
            EndContext();
#line 10 "/Users/jginvincible/Projects/EFGetStarted.AspNetCore.NewDb/Views/Music/Search.cshtml"
     foreach (EFGetStarted.AspNetCore.NewDb.Models.Item item in ViewBag.storing.items)
    {

#line default
#line hidden
            BeginContext(186, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(209, 15, false);
#line 13 "/Users/jginvincible/Projects/EFGetStarted.AspNetCore.NewDb/Views/Music/Search.cshtml"
       Write(item.ArtistName);

#line default
#line hidden
            EndContext();
            BeginContext(224, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(244, 15, false);
#line 14 "/Users/jginvincible/Projects/EFGetStarted.AspNetCore.NewDb/Views/Music/Search.cshtml"
       Write(item.ActiveFrom);

#line default
#line hidden
            EndContext();
            BeginContext(259, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 16 "/Users/jginvincible/Projects/EFGetStarted.AspNetCore.NewDb/Views/Music/Search.cshtml"
    }

#line default
#line hidden
            BeginContext(284, 8, true);
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
