#pragma checksum "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6321813d4967fa44e511ad523771f9c0fc23d8ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__searchPartial), @"mvc.1.0.view", @"/Views/Shared/_searchPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_searchPartial.cshtml", typeof(AspNetCore.Views_Shared__searchPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6321813d4967fa44e511ad523771f9c0fc23d8ef", @"/Views/Shared/_searchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e5c561d98afc36755b0a6c471ba393de9054fb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__searchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 102, true);
            WriteLiteral("\r\n<div id=\"grid-view\" class=\"tab-pane fade show active\">\r\n    <div class=\"row border-hover-effect \">\r\n");
            EndContext();
#line 5 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
         foreach (var product1 in Model)
        {

#line default
#line hidden
            BeginContext(184, 261, true);
            WriteLiteral(@"            <div class=""col-lg-4 col-md-4 col-sm-6 col-6"">
                <!-- Single Product Start -->
                <div class=""single-ponno-product"">
                    <div class=""card card-title "">
                        
                        ");
            EndContext();
            BeginContext(445, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b3fb6a72c44f43e69c1f59be27ceca33", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 455, "~/img/", 455, 6, true);
#line 12 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
AddHtmlAttributeValue("", 461, product1.ProductImages.FirstOrDefault()?.ImageUrl, 461, 50, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(583, 100, true);
            WriteLiteral("\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
            EndContext();
            BeginContext(684, 13, false);
#line 15 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                                            Write(product1.Name);

#line default
#line hidden
            EndContext();
            BeginContext(697, 66, true);
            WriteLiteral("</p>\r\n                            <a class=\"add-to-cart\" data-id=\"");
            EndContext();
            BeginContext(764, 11, false);
#line 16 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                                                       Write(product1.Id);

#line default
#line hidden
            EndContext();
            BeginContext(775, 95, true);
            WriteLiteral("\"><i class=\"fas fa-shopping-cart\"></i></a>\r\n                            <p class=\"card-detail\">");
            EndContext();
            BeginContext(871, 35, false);
#line 17 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                                              Write(product1.BrandCategory?.Brand?.Name);

#line default
#line hidden
            EndContext();
            BeginContext(906, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 18 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                             if (product1.Discount == 0)
                            {

#line default
#line hidden
            BeginContext(1001, 70, true);
            WriteLiteral("                                <span class=\"new-price\"><span>₼</span>");
            EndContext();
            BeginContext(1072, 14, false);
#line 20 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                                                                 Write(product1.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 21 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                            }
                            else
                            {


#line default
#line hidden
            BeginContext(1193, 70, true);
            WriteLiteral("                                <span class=\"old-price\"><span>₼</span>");
            EndContext();
            BeginContext(1264, 14, false);
#line 25 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                                                                 Write(product1.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 155, true);
            WriteLiteral("</span>\r\n                                <span class=\"new-price\">\r\n                                    <span>₼</span>\r\n                                    ");
            EndContext();
            BeginContext(1435, 59, false);
#line 28 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                                Write(product1.Price - (product1.Price * product1.Discount) / 100);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 98, true);
            WriteLiteral("\r\n                                </span>\r\n                                <span class=\"discount\">");
            EndContext();
            BeginContext(1594, 17, false);
#line 30 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                                                  Write(product1.Discount);

#line default
#line hidden
            EndContext();
            BeginContext(1611, 23, true);
            WriteLiteral("<span>%</span></span>\r\n");
            EndContext();
#line 31 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(1665, 52, true);
            WriteLiteral("\r\n                            <a class=\"detail-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1717, "\"", 1766, 2);
            WriteAttributeValue("", 1724, "/ProductDetail/index?producid=", 1724, 30, true);
#line 33 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
WriteAttributeValue("", 1754, product1.Id, 1754, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1767, 171, true);
            WriteLiteral(">Ətraflı məlumat</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- Single Product End -->\r\n            </div>\r\n");
            EndContext();
#line 39 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Shared\_searchPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(1949, 734, true);
            WriteLiteral(@"
        <style>
            

            .add-to-cart {
                position: absolute;
                right: 8px;
                bottom: 50px;
                font-size: 20px;
                cursor: pointer;
                color: red !important;
                border: 1px solid green;
                border-radius: 10px;
                padding: 8px;
                padding-right: 12px;
                transition: all 1s;
            }

                .add-to-cart:hover {
                    color: greenyellow !important;
                    background-color: red;
                    transform: rotate(360deg);
                }
        </style>

    </div>
    <!-- Row End -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
