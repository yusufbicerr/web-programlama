#pragma checksum "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9ce80350bfac61f24c37fa971512261ab394f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_PersonelEkle), @"mvc.1.0.view", @"/Views/Personel/PersonelEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9ce80350bfac61f24c37fa971512261ab394f0a", @"/Views/Personel/PersonelEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b447d374dd694bf925f419bf722b6285132d8c67", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Personel_PersonelEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProje2.Models.Siniflar.AddProfileImage>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
  
    ViewBag.Title = "PersonelEkle";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<h2 style=\"color:darkred\">Yeni Personel Ekleme İşlemleri </h2>\n");
#nullable restore
#line 9 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
 using (Html.BeginForm("PersonelEkle", "Personel", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9ce80350bfac61f24c37fa971512261ab394f0a4701", async() => {
                WriteLiteral("\n    <p style=\"color:green\">Personel Adı </p>\n    ");
#nullable restore
#line 13 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
Write(Html.TextBoxFor(x => x.PersonelAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 14 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
Write(Html.ValidationMessageFor(x => x.PersonelAd, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <br />\n    <p style=\"color:green\">Personel Soyadı </p>\n    ");
#nullable restore
#line 17 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
Write(Html.TextBoxFor(x => x.PersonelSoyad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 18 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
Write(Html.ValidationMessageFor(x => x.PersonelSoyad, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <br />\n    <p style=\"color:green\">Personel Görseli </p>\n    <input type=\"file\" name=\"PersonelGorsel\" />\n    <br />\n    <p style=\"color:green\">Personel Departmanı </p>\n    ");
#nullable restore
#line 25 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
Write(Html.ValidationMessageFor(x => x.Departmanid, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 26 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
Write(Html.DropDownListFor(x => x.Departmanid, (List<SelectListItem>)ViewBag.dgr1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <br />\n    <button class=\"btn btn-info\">Personel Ekle</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 31 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\Personel\PersonelEkle.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProje2.Models.Siniflar.AddProfileImage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591