#pragma checksum "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d4c5e4a9ec36dad30ca48ec5d99af4585ec6c65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FinalArea_Views_Team_Index), @"mvc.1.0.view", @"/Areas/FinalArea/Views/Team/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FinalArea/Views/Team/Index.cshtml", typeof(AspNetCore.Areas_FinalArea_Views_Team_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d4c5e4a9ec36dad30ca48ec5d99af4585ec6c65", @"/Areas/FinalArea/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0c015bf72ce09ac1aa8c5a2e4a4717267f78f1", @"/Areas/FinalArea/Views/_ViewImports.cshtml")]
    public class Areas_FinalArea_Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TeamEmployee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-outline button-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-outline button-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-outline button-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-outline button-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(77, 211, true);
            WriteLiteral("\r\n<!--Responsive Table Start-->\r\n<div class=\"content-body\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 mb-30\">\r\n            <div class=\"box\">\r\n                <div class=\"box-head\">\r\n                    ");
            EndContext();
            BeginContext(288, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90ccf5d2875543949f53b7e600aad104", async() => {
                BeginContext(356, 19, true);
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
            BeginContext(379, 672, true);
            WriteLiteral(@"
                </div>
                <div class=""box-body"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Image</th>
                                    <th>Name</th>
                                    <th>Surname</th>
                                    <th>Description</th>
                                    <th>Position</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 29 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
            BeginContext(1174, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 32 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                 foreach (var team in Model)
                                {

#line default
#line hidden
            BeginContext(1271, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <th>");
            EndContext();
            BeginContext(1350, 5, false);
#line 35 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1355, 89, true);
            WriteLiteral("</th>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1444, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c090941d36d444cb9b8b3dce1b0473a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1454, "~/img/", 1454, 6, true);
#line 37 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
AddHtmlAttributeValue("", 1460, team.Image, 1460, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1495, 85, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
            EndContext();
            BeginContext(1581, 9, false);
#line 39 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                   Write(team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1590, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1638, 12, false);
#line 40 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                   Write(team.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1650, 49, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n");
            EndContext();
#line 42 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                         if (team.Description.Length > 50)
                                        {
                                            

#line default
#line hidden
            BeginContext(1863, 51, false);
#line 44 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                       Write(Html.Raw(team.Description.Substring(0, 30) + "..."));

#line default
#line hidden
            EndContext();
#line 44 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                                                                                
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(2093, 26, false);
#line 48 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                       Write(Html.Raw(team.Description));

#line default
#line hidden
            EndContext();
#line 48 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                                                       
                                        }

#line default
#line hidden
            BeginContext(2164, 83, true);
            WriteLiteral("                                    </td>\r\n                                    <td>");
            EndContext();
            BeginContext(2248, 13, false);
#line 51 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                   Write(team.Position);

#line default
#line hidden
            EndContext();
            BeginContext(2261, 91, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n\r\n                                        ");
            EndContext();
            BeginContext(2352, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30bff1eb1b284135841771314159dd94", async() => {
                BeginContext(2444, 32, true);
                WriteLiteral("<span class=\"fa fa-info\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                                                 WriteLiteral(team.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2480, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2522, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "322e179033a64154957167221df4aaac", async() => {
                BeginContext(2614, 32, true);
                WriteLiteral("<span class=\"fa fa-edit\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                                                 WriteLiteral(team.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2650, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2692, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3163898f3c6b4fcabb792ea9aee84588", async() => {
                BeginContext(2783, 33, true);
                WriteLiteral("<span class=\"fa fa-trash\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                                                 WriteLiteral(team.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2820, 90, true);
            WriteLiteral("\r\n\r\n\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 62 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Areas\FinalArea\Views\Team\Index.cshtml"
                                    count++;
                                }

#line default
#line hidden
            BeginContext(2991, 215, true);
            WriteLiteral("\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!--Responsive Table End-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TeamEmployee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
