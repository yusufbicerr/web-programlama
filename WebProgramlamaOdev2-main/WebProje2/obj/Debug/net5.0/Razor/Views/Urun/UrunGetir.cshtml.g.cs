#pragma checksum "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd175237d1156048351234c05081f04ef56db536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urun_UrunGetir), @"mvc.1.0.view", @"/Views/Urun/UrunGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd175237d1156048351234c05081f04ef56db536", @"/Views/Urun/UrunGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b447d374dd694bf925f419bf722b6285132d8c67", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Urun_UrunGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProje2.Models.Siniflar.Urun>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
  
    ViewBag.Title = "UrunGetir";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<h2>Ürün Güncelleme İşlemleri</h2>\n<br />\n\n");
#nullable restore
#line 11 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
 using (Html.BeginForm("UrunGuncelle", "Urun", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.HiddenFor(x => x.UrunID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Ürün Adı</p>\n");
#nullable restore
#line 15 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.TextBoxFor(x => x.UrunAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.ValidationMessageFor(x => x.UrunAd, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Ürün Kategorisi</p>\n");
#nullable restore
#line 19 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.DropDownListFor(x => x.Kategoriid, (List<SelectListItem>)ViewBag.ktg1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Ürün Markası</p>\n");
#nullable restore
#line 22 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.TextBoxFor(x => x.Marka, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Ürün Stok Sayısı</p>\n");
#nullable restore
#line 25 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.TextBoxFor(x => x.Stok, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Alış Fiyatı</p>\n");
#nullable restore
#line 28 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.TextBoxFor(x => x.AlisFiyat, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Satış Fiyatı</p>\n");
#nullable restore
#line 31 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.TextBoxFor(x => x.SatisFiyat, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Ürün Görseli</p>\n");
#nullable restore
#line 34 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
Write(Html.TextBoxFor(x => x.UrunGorsel, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <button class=\"btn btn-warning\">Ürünü Güncelle</button>\n");
#nullable restore
#line 37 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Urun\UrunGetir.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProje2.Models.Siniflar.Urun> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
