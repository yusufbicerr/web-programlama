#pragma checksum "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f284b8da5b81064690256fc63a14a26206ff6012"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CariPanel_KargoTakip), @"mvc.1.0.view", @"/Views/CariPanel/KargoTakip.cshtml")]
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
#line 1 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f284b8da5b81064690256fc63a14a26206ff6012", @"/Views/CariPanel/KargoTakip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b447d374dd694bf925f419bf722b6285132d8c67", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CariPanel_KargoTakip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KargoDetay>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
  
    ViewData["Title"] = "KargoTakip";
    Layout = "~/Views/Shared/_CariLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n");
#nullable restore
#line 10 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
 using (Html.BeginForm("KargoTakip", "CariPanel", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        Takip Kodu : ");
#nullable restore
#line 13 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
                Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <input type=\"submit\" value=\"Ara\" />\n    </p>\n");
#nullable restore
#line 16 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<table class=\"table table-bordered\" style=\"margin-top:20px\">\n    <tr>\n        <th>Takip Kodu</th>\n        <th>Personel</th>\n        <th>Alıcı</th>\n        <th>Tarih</th>\n        <th>Detaylar</th>\n    </tr>\n");
#nullable restore
#line 26 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
     foreach (var k in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 30 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
           Write(k.TakipKodu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 33 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
           Write(k.Personel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 36 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
           Write(k.Alici);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 39 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
           Write(k.Tarih.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 886, "\"", 927, 2);
            WriteAttributeValue("", 893, "/CariPanel/KargoDetay/", 893, 22, true);
#nullable restore
#line 41 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
WriteAttributeValue("", 915, k.TakipKodu, 915, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Detaylar</a></td>\n        </tr>\n");
#nullable restore
#line 43 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\KargoTakip.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KargoDetay>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591