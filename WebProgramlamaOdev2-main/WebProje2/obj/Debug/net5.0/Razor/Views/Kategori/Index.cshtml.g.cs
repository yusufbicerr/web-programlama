#pragma checksum "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5689c6f99bcef49617af423c26c3abe8f20ef51e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategori_Index), @"mvc.1.0.view", @"/Views/Kategori/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\_ViewImports.cshtml"
using WebProje2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\_ViewImports.cshtml"
using WebProje2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5689c6f99bcef49617af423c26c3abe8f20ef51e", @"/Views/Kategori/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b447d374dd694bf925f419bf722b6285132d8c67", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Kategori_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Kategori>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<h2 style=\"color:darkred\">Kategoriler</h2>\n<table class=\"table table-bordered\" style=\"margin-top:20px\">\n    <tr>\n        <th>Kategori Adı</th>\n        <th>Sil</th>\n        <th>Güncelle</th>\n    </tr>\n");
#nullable restore
#line 18 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
     foreach (var k in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 22 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
           Write(k.KategoriAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 576, 2);
            WriteAttributeValue("", 541, "/Kategori/KategoriSil/", 541, 22, true);
#nullable restore
#line 24 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
WriteAttributeValue("", 563, k.KategoriID, 563, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 632, "\"", 676, 2);
            WriteAttributeValue("", 639, "/Kategori/KategoriGetir/", 639, 24, true);
#nullable restore
#line 25 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
WriteAttributeValue("", 663, k.KategoriID, 663, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\n        </tr>\n");
#nullable restore
#line 27 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
#nullable restore
#line 29 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, sayfa => Url.Action("Index", new { sayfa })
, new X.PagedList.Web.Common.PagedListRenderOptions
{
    LiElementClasses = new List<string>
    {"page-link"}
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<a href=\"/Kategori/KategoriEkle\" class=\"btn btn-primary\">Kategori Ekle</a>\n<p></p>\n");
#nullable restore
#line 37 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
 if (TempData["added"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <strong style=\"color:darkgreen\">");
#nullable restore
#line 39 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
                               Write(TempData["added"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n");
#nullable restore
#line 40 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
 if (TempData["deleted"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <strong style=\"color:red\">");
#nullable restore
#line 43 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
                         Write(TempData["deleted"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n");
#nullable restore
#line 44 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
 if (TempData["updated"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <strong style=\"color:darkblue\">");
#nullable restore
#line 47 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
                              Write(TempData["updated"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n");
#nullable restore
#line 48 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Kategori\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Kategori>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
