#pragma checksum "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03b410e3664fcaa08ae431a20fd987ad625ec318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FinalArea_Views_Brand_Index), @"mvc.1.0.view", @"/Areas/FinalArea/Views/Brand/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FinalArea/Views/Brand/Index.cshtml", typeof(AspNetCore.Areas_FinalArea_Views_Brand_Index))]
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
#line 1 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\_ViewImports.cshtml"
using FinalProject.Areas.AdminViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03b410e3664fcaa08ae431a20fd987ad625ec318", @"/Areas/FinalArea/Views/Brand/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0c015bf72ce09ac1aa8c5a2e4a4717267f78f1", @"/Areas/FinalArea/Views/_ViewImports.cshtml")]
    public class Areas_FinalArea_Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Brand>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-outline button-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-outline button-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-outline button-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-outline button-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 381, true);
            WriteLiteral(@"
<!-- Content Body Start -->
<div class=""content-body"" style=""overflow-x:hidden;"">

    <!-- Page Headings Start -->
    <div class=""row justify-content-between align-items-center mb-10"">

        <!-- Page Heading Start -->
        <div class=""col-12 col-lg-auto mb-20"">
            <div class=""page-heading"">
                <div class=""box-head"">
                    ");
            EndContext();
            BeginContext(451, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31331e84ff1b4ca6b2df6b6bad6bf16d", async() => {
                BeginContext(519, 19, true);
                WriteLiteral("<span>Create</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(542, 891, true);
            WriteLiteral(@"
                </div>
            </div>
        </div><!-- Page Heading End -->

    </div><!-- Page Headings End -->

    <div class=""row"">

        <!--Default Data Table Start-->
        <div class=""col-12 mb-30"">
            <div class=""box"">
                <div class=""box-head"">
                    <h3 class=""title"">Default Table</h3>
                </div>
                <div class=""box-body"" style=""width:1000px;"">

                    <table class=""table table-bordered data-table data-table-default"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Name</th>
                                <th>Details</th>
                                <th></th>

                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 45 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                              
                                int count = 1;
                            

#line default
#line hidden
            BeginContext(1544, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 48 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                             foreach (var brand in Model)
                            {

#line default
#line hidden
            BeginContext(1634, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <th>");
            EndContext();
            BeginContext(1713, 5, false);
#line 51 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1718, 47, true);
            WriteLiteral("</th>\r\n                                    <td>");
            EndContext();
            BeginContext(1766, 10, false);
#line 52 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                   Write(brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 49, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n");
            EndContext();
#line 54 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                         if (brand.Details.Length > 50)
                                        {
                                            

#line default
#line hidden
            BeginContext(1986, 48, false);
#line 56 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                       Write(Html.Raw(brand.Details.Substring(0, 30) + "..."));

#line default
#line hidden
            EndContext();
#line 56 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                                                                             
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(2213, 23, false);
#line 60 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                       Write(Html.Raw(brand.Details));

#line default
#line hidden
            EndContext();
#line 60 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                                                    
                                        }

#line default
#line hidden
            BeginContext(2281, 125, true);
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2406, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260cea0c50894809b6668dca6d8ae9c2", async() => {
                BeginContext(2499, 32, true);
                WriteLiteral("<span class=\"fa fa-info\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                                                 WriteLiteral(brand.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2535, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2577, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9c02a61be04486e8f3ee4cc3dc4d007", async() => {
                BeginContext(2670, 32, true);
                WriteLiteral("<span class=\"fa fa-edit\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                                                 WriteLiteral(brand.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2706, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2748, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e6f7c1d33aa4c3996b8d32b594fa088", async() => {
                BeginContext(2840, 33, true);
                WriteLiteral("<span class=\"fa fa-trash\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                                                 WriteLiteral(brand.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2877, 86, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 70 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Brand\Index.cshtml"
                                count++;
                            }

#line default
#line hidden
            BeginContext(3036, 224, true);
            WriteLiteral("\r\n\r\n                        </tbody>\r\n\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!--Default Data Table End-->\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div><!-- Content Body End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Brand>> Html { get; private set; }
    }
}
#pragma warning restore 1591
