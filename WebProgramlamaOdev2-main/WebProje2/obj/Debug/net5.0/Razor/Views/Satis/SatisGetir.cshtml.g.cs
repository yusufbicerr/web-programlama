#pragma checksum "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f250f50d69315e66ffc67208245cad8e89212c86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Satis_SatisGetir), @"mvc.1.0.view", @"/Views/Satis/SatisGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f250f50d69315e66ffc67208245cad8e89212c86", @"/Views/Satis/SatisGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b447d374dd694bf925f419bf722b6285132d8c67", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Satis_SatisGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProje2.Models.Siniflar.SatisHareket>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
  
    ViewBag.Title = "SatisGetir";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<h2>Satış İşlemi Güncelleme İşlemleri</h2>\n<br />\n\n");
#nullable restore
#line 12 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
 using (Html.BeginForm("SatisGuncelle", "Satis", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.HiddenFor(x => x.Satisid));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Ürün Adı</p>\n");
#nullable restore
#line 16 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.DropDownListFor(x => x.Urunid, (List<SelectListItem>)ViewBag.dgr1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Ürün Markası</p>\n");
#nullable restore
#line 19 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.TextBoxFor(x=>x.Urun.Marka, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Cari(Müşteri)</p>\n");
#nullable restore
#line 22 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.DropDownListFor(x => x.CarilerID, (List<SelectListItem>)ViewBag.dgr2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Personel (Satış Yapan)</p>\n");
#nullable restore
#line 25 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.DropDownListFor(x => x.Personelid, (List<SelectListItem>)ViewBag.dgr3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Ürün Adedi</p>\n");
#nullable restore
#line 28 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.TextBoxFor(x => x.Adet, new { @class = "form-control", @id = "txt1"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Birim Fiyatı</p>\n");
#nullable restore
#line 31 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.TextBoxFor(x => x.Fiyat, new { @class = "form-control", @id = "txt2", @onkeyup = "sum();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Toplam Tutar</p>\n");
#nullable restore
#line 34 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.TextBoxFor(x => x.ToplamTutar, new { @class = "form-control", @id = "txt3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Satış Tarihi</p>\n");
#nullable restore
#line 37 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
Write(Html.TextBoxFor(x => x.Tarih, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <button class=\"btn btn-warning\">Satış Bilgilerini Güncelle</button>\n");
#nullable restore
#line 40 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Satis\SatisGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function sum() {
        var sayi1 = document.getElementById('txt1').value;
        var sayi2 = document.getElementById('txt2').value;
        var sonuc = parseInt(sayi1) * parseInt(sayi2);
        if (!isNaN(sonuc)) {
            document.getElementById('txt3').value = sonuc;
        }
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProje2.Models.Siniflar.SatisHareket> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
