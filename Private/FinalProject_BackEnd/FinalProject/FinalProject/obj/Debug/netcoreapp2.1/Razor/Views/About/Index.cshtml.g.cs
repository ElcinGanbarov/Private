#pragma checksum "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b2e569f37b23f04795b02821733a1ddf01c7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
#line 1 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b2e569f37b23f04795b02821733a1ddf01c7af", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e5c561d98afc36755b0a6c471ba393de9054fb8", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(60, 902, true);
            WriteLiteral(@"

<!-- Breadcrumb Area Start Here -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <ol class=""breadcrumb breadcrumb-list"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Əsas səhifə</a>
            </li>
            <li class=""breadcrumb-item active"">Haqqımızda</li>
        </ol>
    </div>
</div>
<!-- Breadcrumb Area End Here -->
<!-- about start -->
<main id=""main-about"">
    <section id=""about-up"">
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-lg-12"">
                    <div class=""title-about"">
                        <p>Haqqımızda</p>
                    </div>
                </div>
            </div>

            <div class=""row mt-5 mb-5"">
                <div class=""col-lg-6"">
                    <div class=""img-about"">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 962, "\"", 1008, 2);
            WriteAttributeValue("", 968, "img/", 968, 4, true);
#line 34 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 972, Model.Abouts.FirstOrDefault().Image, 972, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1009, 168, true);
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"desc-about\">\r\n                        <p>");
            EndContext();
            BeginContext(1178, 51, false);
#line 39 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
                      Write(Html.Raw(Model.Abouts.FirstOrDefault().Description));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 455, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""about-down"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""title-about"">
                        <p>Idarə heyəti</p>
                    </div>
                </div>
            </div>

            <div class=""row mt-5 mb-5"">
");
            EndContext();
#line 57 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
                 foreach (var team in Model.TeamEmployees)
                {

#line default
#line hidden
            BeginContext(1763, 191, true);
            WriteLiteral("                    <div class=\"col-lg-3\">\r\n                        <div class=\"card img-fluid cart-list\" style=\"width:400px\">\r\n                            <img class=\"card-img-top img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1954, "\"", 1975, 2);
            WriteAttributeValue("", 1960, "img/", 1960, 4, true);
#line 61 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 1964, team.Image, 1964, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1976, 181, true);
            WriteLiteral(" alt=\"Card image\"\r\n                                 style=\"width:100%\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(2159, 28, false);
#line 64 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
                                                   Write(team.Name +" "+ team.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(2188, 60, true);
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
            EndContext();
            BeginContext(2249, 13, false);
#line 65 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
                                                Write(team.Position);

#line default
#line hidden
            EndContext();
            BeginContext(2262, 1306, true);
            WriteLiteral(@"</p>
                                <!-- Button to Open the Modal -->
                                <button type=""button"" class=""btn btn-primary but-team"" data-toggle=""modal""
                                        data-target=""#myModal"">
                                    Haqqında
                                </button>

                                <!-- The Modal -->
                                <div class=""modal fade"" id=""myModal"">
                                    <div class=""modal-dialog modal-lg"">
                                        <div class=""modal-content"">

                                            <!-- Modal Header -->
                                            <div class=""modal-header"">
                                                <h4 class=""modal-title"">Qısa məlumat</h4>
                                                <button type=""button"" class=""close""
                                                        data-dismiss=""modal"">
                          ");
            WriteLiteral(@"                          &times;
                                                </button>
                                            </div>

                                            <!-- Modal body -->
                                            <div class=""modal-body""> ");
            EndContext();
            BeginContext(3569, 26, false);
#line 87 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
                                                                Write(Html.Raw(team.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3595, 726, true);
            WriteLiteral(@" </div>

                                            <!-- Modal footer -->
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-secondary""
                                                        data-dismiss=""modal"">
                                                    Bağla
                                                </button>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 103 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\About\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4340, 89, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </section>\r\n</main>\r\n<!-- about end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
