#pragma checksum "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03cc4e46a8347dd273a1b0857d5839aab0232798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03cc4e46a8347dd273a1b0857d5839aab0232798", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e5c561d98afc36755b0a6c471ba393de9054fb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(57, 433, true);
            WriteLiteral(@"



<!-- Breadcrumb Area Start Here -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <ol class=""breadcrumb breadcrumb-list"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Əsas səhifə</a>
            </li>
            <li class=""breadcrumb-item active"">Bizimlə əlaqə</li>
        </ol>
    </div>
</div>
<!-- Breadcrumb Area End Here -->


<main id=""main-contact""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 490, "\"", 645, 9);
            WriteAttributeValue("", 498, "height:", 498, 7, true);
            WriteAttributeValue(" ", 505, "450px;", 506, 7, true);
            WriteAttributeValue(" ", 512, "background-image:", 513, 18, true);
            WriteAttributeValue(" ", 530, "url(\'img/", 531, 10, true);
#line 23 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 540, Model.BackImage, 540, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 556, "\');background-size:cover;background-position:", 556, 45, true);
            WriteAttributeValue(" ", 601, "center", 602, 7, true);
            WriteAttributeValue(" ", 608, "center;background-repeat:", 609, 26, true);
            WriteAttributeValue(" ", 634, "no-repeat;", 635, 11, true);
            EndWriteAttribute();
            BeginContext(646, 162, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"title-desc\">\r\n                    <h3>");
            EndContext();
            BeginContext(809, 11, false);
#line 28 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(820, 56, true);
            WriteLiteral("</h3>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(877, 27, false);
#line 30 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                   Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(904, 140, true);
            WriteLiteral("\r\n                    </p>\r\n                    <div class=\"mobile-contact mt-5\">\r\n                        <span class=\"fas fa-mobile-alt\"> ");
            EndContext();
            BeginContext(1045, 17, false);
#line 33 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                                                    Write(Model.MobilePhone);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 137, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"phone-contact\">\r\n                        <span class=\"fas fa-phone\">");
            EndContext();
            BeginContext(1200, 15, false);
#line 36 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                                              Write(Model.HomePhone);

#line default
#line hidden
            EndContext();
            BeginContext(1215, 141, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"email-contact\">\r\n                        <span class=\"fas fa-envelope\"> ");
            EndContext();
            BeginContext(1357, 11, false);
#line 39 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                                                  Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1368, 116, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
