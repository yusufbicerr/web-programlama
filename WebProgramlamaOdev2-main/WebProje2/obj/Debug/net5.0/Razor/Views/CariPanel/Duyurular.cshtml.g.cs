#pragma checksum "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CariPanel_Duyurular), @"mvc.1.0.view", @"/Views/CariPanel/Duyurular.cshtml")]
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
#line 1 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83081cd0d95eb077ab8b765bd0c237d2c12c9f7c", @"/Views/CariPanel/Duyurular.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b447d374dd694bf925f419bf722b6285132d8c67", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CariPanel_Duyurular : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mesajlar>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/plugins/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/dist/css/adminlte.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-user-img img-fluid img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/dist/img/user4-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/plugins/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/dist/js/adminlte.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/dist/js/demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
  
    ViewData["Title"] = "Duyurular";
    Layout = "~/Views/Shared/_CariLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c8226", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">

    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">

    <title>ASahin V1.0.3 | Profilim</title>

    <!-- Tell the browser to be responsive to screen width -->

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Font Awesome -->

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c8794", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Ionicons -->\n\n    <link rel=\"stylesheet\" href=\"https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css\">\n\n    <!-- Theme style -->\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c10136", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Google Font: Source Sans Pro -->\n\n    <link href=\"https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700\" rel=\"stylesheet\">\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c12180", async() => {
                WriteLiteral(@"

    <div class=""wrapper"">

        <!-- Navbar -->
        <!-- /.navbar -->
        <!-- Content Wrapper. Contains page content -->
        <!-- Content Header (Page header) -->

        <section class=""content-header"">

            <div class=""container-fluid"">

                <div class=""row mb-2"">

                    <div class=""col-sm-6"">

                        <h1>Profile</h1>

                    </div>



                </div>

            </div><!-- /.container-fluid -->

        </section>

        <!-- Main content -->

        <section class=""content"">

            <div class=""container-fluid"">

                <div class=""row"">

                    <div class=""col-md-3"">

                        <!-- Profile Image -->

                        <div class=""card card-primary card-outline"">

                            <div class=""card-body box-profile"">

                                <div class=""text-center"">

                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c13439", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                                </div>\n\n\n                                <h3 class=\"profile-username text-center\">");
#nullable restore
#line 99 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                                    Write(ViewBag.d4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n\n                                <p class=\"text-muted text-center\">");
#nullable restore
#line 101 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                             Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n                                <ul class=\"list-group list-group-unbordered mb-3\">\n\n                                    <li class=\"list-group-item\">\n\n                                        <b>Toplam Satış :</b> <a class=\"float-right\">");
#nullable restore
#line 107 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                                                Write(ViewBag.d1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n\n                                    </li>\n\n                                    <li class=\"list-group-item\">\n\n                                        <b>Toplam Satış Tutarı :</b> <a class=\"float-right\" style=\"color:darkgreen\">");
#nullable restore
#line 113 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                                                                               Write(ViewBag.d2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</a>\n\n                                    </li>\n\n                                    <li class=\"list-group-item\">\n\n                                        <b>Toplam Ürün Sayısı :</b> <a class=\"float-right\">");
#nullable restore
#line 119 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                                                      Write(ViewBag.d3);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Adet</a>

                                    </li>

                                </ul>

                                <a href=""/CariPanel/KargoTakip/"" class=""btn btn-primary btn-block""><b>Kargo Takip</b></a>

                            </div>

                            <!-- /.card-body -->

                        </div>

                        <!-- /.card -->
                        <!-- About Me Box -->

                        <div class=""card card-primary"">

                            <div class=""card-header"">

                                <h3 class=""card-title"">Hakkımda</h3>

                            </div>

                            <!-- /.card-header -->
                            <div class=""card-body"">

                                <strong><i class=""fas fa-book mr-1""></i> Veri Dairesi</strong>

                                <p class=""text-muted"">

                                    ----

                                </p>

                                <hr>

           ");
                WriteLiteral("                     <strong><i class=\"fas fa-map-marker-alt mr-1\"></i>Şehir</strong>\n\n                                <p class=\"text-muted\">");
#nullable restore
#line 159 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                 Write(ViewBag.d5);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                <hr>
                                <strong><i class=""far fa-file-alt mr-1""></i> Versiyon Bilgileri</strong>

                                <p class=""text-muted"" style=""color:red"">V1.0.3 Cari Yönetim Sistemi</p>

                            </div>

                            <!-- /.card-body -->

                        </div>

                        <!-- /.card -->

                    </div>

                    <!-- /.col -->

                    <div class=""col-md-9"">

                        <div class=""card"">

                            <div class=""card-header p-2"">

                                <ul class=""nav nav-pills"">

                                    <li class=""nav-item""><a class=""nav-link"" href=""/CariPanel/Index/"">Mesajlar</a></li>

                                    <li class=""nav-item""><a class=""nav-link active"" href=""#duyurular"" data-toggle=""tab"">Duyurular</a></li>

                                    <li class=""nav-item""><a class=""nav-link"" hre");
                WriteLiteral(@"f=""/CariPanel/CariBilgilerim/"">Kullanıcı Ayarları</a></li>

                                </ul>

                            </div><!-- /.card-header -->

                            <div class=""card-body"">

                                <div class=""tab-content"">

                                    <!-- /.tab-pane -->

                                    <div class=""active tab-pane"" id=""duyurular"">

                                        <!-- The timeline -->
");
#nullable restore
#line 204 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                         foreach (var x in Model)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <div class=""timeline timeline-inverse"">

                                                <!-- timeline time label -->

                                                <div class=""time-label"">

                                                    <span class=""bg-danger"">

                                                        ");
#nullable restore
#line 214 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                   Write(x.Tarih.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                                    </span>

                                                </div>

                                                <!-- /.timeline-label -->
                                                <!-- timeline item -->

                                                <div>

                                                    <i class=""fas fa-envelope bg-primary""></i>

                                                    <div class=""timeline-item"">

                                                        <span class=""time""><i class=""far fa-clock""></i> ");
#nullable restore
#line 229 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                                                                   Write(x.Tarih);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n\n                                                        <h3 class=\"timeline-header\"><a href=\"#\">");
#nullable restore
#line 231 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                                                           Write(x.Gonderici);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a> Bir duyuru yayınladı !</h3>\n\n                                                        <div class=\"timeline-body\">\n\n                                                            <h5 style=\"color:red\">");
#nullable restore
#line 235 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                                             Write(x.Konu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                                                            ");
#nullable restore
#line 236 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                                       Write(x.Icerik);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                                                        </div>\n\n\n                                                    </div>\n\n                                                </div>\n\n                                            </div>\n");
#nullable restore
#line 246 "C:\Users\yusuf\OneDrive\Masaüstü\WebProgramlamaOdev2-main\WebProje2\Views\CariPanel\Duyurular.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </div>


                                </div>

                                <!-- /.nav-tabs-custom -->

                            </div>

                            <!-- /.col -->

                        </div>

                        <!-- /.row -->

                    </div><!-- /.container-fluid -->

        </section>

        <!-- /.content -->

    </div>

    <!-- /.content-wrapper -->


    <!-- Control Sidebar -->

    <aside class=""control-sidebar control-sidebar-dark"">

        <!-- Control sidebar content goes here -->

    </aside>

    <!-- /.control-sidebar -->
    <!-- ./wrapper -->
    <!-- jQuery -->

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c24757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Bootstrap 4 -->\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c25885", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- AdminLTE App -->\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c27014", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- AdminLTE for demo purposes -->\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83081cd0d95eb077ab8b765bd0c237d2c12c9f7c28157", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mesajlar>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
