#pragma checksum "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "959d3b3c2d04dda670c19e6fe8aead4270ce245f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locator_Index), @"mvc.1.0.view", @"/Views/Locator/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Locator/Index.cshtml", typeof(AspNetCore.Views_Locator_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959d3b3c2d04dda670c19e6fe8aead4270ce245f", @"/Views/Locator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec7d3c09867ddf3f0c242438b59d6cdc99e72cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Locator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2181, true);
            WriteLiteral(@"<style>
    .post-content {
        top: 0;
        left: 0;
        position: absolute;
    }

    .row {
        display: flex;
        flex-wrap: wrap;
        padding: 0 4px;
    }
    /* Create two equal columns that sits next to each other */
    .column {
        flex: 50%;
        padding: 0 4px;
    }

        .column img {
            margin-top: 8px;
            vertical-align: middle;
        }
    /*
        .column {
          float: left;
          width: 48%;
          padding: 5px;
        }
        .row::after {
              content: """";
              clear: both;
              display: table;
        }
    /* Clear floats after image containers */
    .thumbnail {
        position: relative;
    }

    .dropbtn {
        background-color: #4CAF50;
        color: white;
        padding: 16px;
        font-size: 16px;
        border: none;
        cursor: pointer;
    }

    .dropdown {
        position: relative;
        display: inline-block");
            WriteLiteral(@";
    }

    .dropdown-content {
        display: none;
        position: absolute;
        right: 0;
        background-color: #f9f9f9;
        min-width: 160px;
        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 1;
    }

        .dropdown-content a {
            color: black;
            padding: 12px 16px;
            text-decoration: none;
            display: block;
        }

            .dropdown-content a:hover {
                background-color: #f1f1f1;
            }

    .dropdown:hover .dropdown-content {
        display: block;
    }

    .dropdown:hover .dropbtn {
        background-color: #3e8e41;
    }
</style>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script>$(Document).ready(function () {
        $(""p"").each(function (index, value) {
            $(""p"").eq(index).html($(""p"").eq(index).text());
        });
    });</script>

<title>Park Locator</title>
<center>
    <h2 style=""color:na");
            WriteLiteral("vy; font-weight:bold;\">Park Locator</h2>\r\n    <br />\r\n</center>\r\n\r\n\r\n<!-- DYNAMIC BUTTON FOR PERMIBABLE PARKS-->\r\n<p>\r\n    <center>\r\n");
            EndContext();
#line 100 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
         foreach (Parks_SpecialEvents.Models.Event e in ViewBag.storePermitables)
        {

#line default
#line hidden
            BeginContext(2275, 69, true);
            WriteLiteral("            <a class=\"btn btn-info btn-sm m-1\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2344, "\"", 2359, 2);
            WriteAttributeValue("", 2351, "#", 2351, 1, true);
#line 102 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
WriteAttributeValue("", 2352, e.Href, 2352, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2360, 87, true);
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n                ");
            EndContext();
            BeginContext(2448, 3, false);
#line 103 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
           Write(e.E);

#line default
#line hidden
            EndContext();
            BeginContext(2451, 20, true);
            WriteLiteral("\r\n            </a>\r\n");
            EndContext();
#line 105 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2482, 58, true);
            WriteLiteral("    </center>\r\n</p>\r\n<br />\r\n<br />\r\n\r\n<p>\r\n    <center>\r\n");
            EndContext();
#line 113 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
         foreach (Parks_SpecialEvents.Models.EventType e in ViewBag.eventInfo)
        {
            string noSpace = e.Name.Replace(" ", "");

#line default
#line hidden
            BeginContext(2686, 69, true);
            WriteLiteral("            <a class=\"btn btn-info btn-sm m-1\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2755, "\"", 2771, 2);
            WriteAttributeValue("", 2762, "#", 2762, 1, true);
#line 116 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
WriteAttributeValue("", 2763, noSpace, 2763, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2772, 117, true);
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\" style=\"background-color:navy\">\r\n                ");
            EndContext();
            BeginContext(2890, 6, false);
#line 117 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
           Write(e.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2896, 22, true);
            WriteLiteral("\r\n\r\n            </a>\r\n");
            EndContext();
#line 120 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2929, 142, true);
            WriteLiteral("        <div class=\"dropdown\">\r\n            <button class=\"dropbtn\">List of past events</button>\r\n            <div class=\"dropdown-content\">\r\n");
            EndContext();
#line 124 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
                 foreach (Parks_SpecialEvents.Models.Event e2 in ViewBag.storePermitables)
                {


#line default
#line hidden
            BeginContext(3184, 45, true);
            WriteLiteral("                    <a data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3229, "\"", 3245, 2);
            WriteAttributeValue("", 3236, "#", 3236, 1, true);
#line 127 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
WriteAttributeValue("", 3237, e2.Href, 3237, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3246, 81, true);
            WriteLiteral(" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n                        ");
            EndContext();
            BeginContext(3328, 4, false);
#line 128 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
                   Write(e2.E);

#line default
#line hidden
            EndContext();
            BeginContext(3332, 28, true);
            WriteLiteral("\r\n                    </a>\r\n");
            EndContext();
#line 130 "/Users/jginvincible/git/Senior-Design/Parks_SpecialEvents/Views/Locator/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3379, 55, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </center>\r\n</p>");
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
