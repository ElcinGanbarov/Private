#pragma checksum "C:\Users\Admin\Desktop\Practica\WebAsp\WebAsp\Views\Shared\_ViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a53a4be38b7fa7b9e9a84a974755cda86a002eb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ViewModel), @"mvc.1.0.view", @"/Views/Shared/_ViewModel.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\Practica\WebAsp\WebAsp\Views\_ViewImports.cshtml"
using WebAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Practica\WebAsp\WebAsp\Views\_ViewImports.cshtml"
using WebAsp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a53a4be38b7fa7b9e9a84a974755cda86a002eb6", @"/Views/Shared/_ViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e557ef32ce7cb8ac3cae6740a7d4ac0d323ab37c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PartnerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row mt-5 align-items-center\">\r\n");
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Practica\WebAsp\WebAsp\Views\Shared\_ViewModel.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-3\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 170, "\"", 186, 1);
#nullable restore
#line 7 "C:\Users\Admin\Desktop\Practica\WebAsp\WebAsp\Views\Shared\_ViewModel.cshtml"
WriteAttributeValue("", 177, item.Url, 177, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 226, "\"", 243, 1);
#nullable restore
#line 8 "C:\Users\Admin\Desktop\Practica\WebAsp\WebAsp\Views\Shared\_ViewModel.cshtml"
WriteAttributeValue("", 232, item.Photo, 232, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" />\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 11 "C:\Users\Admin\Desktop\Practica\WebAsp\WebAsp\Views\Shared\_ViewModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PartnerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
