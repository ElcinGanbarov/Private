#pragma checksum "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a967c2a7608e6dbc75dc9230690d9d2b42c565f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a967c2a7608e6dbc75dc9230690d9d2b42c565f7", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e5c561d98afc36755b0a6c471ba393de9054fb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(64, 886, true);
            WriteLiteral(@"
<!-- Breadcrumb Area Start Here -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <ol class=""breadcrumb breadcrumb-list"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Əsas səhifə</a>
            </li>
            <li class=""breadcrumb-item active"">Mənim səhifəm</li>
        </ol>
    </div>
</div>
<!-- Breadcrumb Area End Here -->

<main id=""main-account"">

    <!-- My Account Page Start Here -->
    <div class=""my-account white-bg ptb-80"">
        <div class=""container"">
            <div class=""account-dashboard"">
                <div class=""dashboard-upper-info"">
                    <div class=""row align-items-center no-gutters"">
                        <div class=""col-xl-3 col-lg-3 col-md-6"">
                            <div class=""d-single-info"">
                                <p>Hello <span>");
            EndContext();
            BeginContext(951, 18, false);
#line 29 "C:\Users\Cavid\Desktop\FinalProject_BackEnd\FinalProject\FinalProject\Views\Account\Index.cshtml"
                                          Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(969, 1734, true);
            WriteLiteral(@"</span></p>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-lg-4 col-md-6"">
                            <div class=""d-single-info"">
                                <p>Need Support? Customer service.</p>
                                <p>admin@example.com.</p>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-lg-3 col-md-6"">
                            <div class=""d-single-info"">
                                <p>E-mail them at </p>
                                <p>support@example.com</p>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-lg-2 col-md-6"">
                            <div class=""d-single-info text-lg-center"">
                                <a class=""view-cart"" href=""cart.html"">view cart</a>
                            </div>
                        </div>
                    </d");
            WriteLiteral(@"iv>
                </div>
                <div class=""row"">
                    <div class=""col-lg-2"">
                        <!-- Nav tabs -->
                        <ul class=""nav flex-column dashboard-list"" role=""tablist"">
                            <li><a class=""nav-link active"" data-toggle=""tab"" href=""#dashboard"">Səhifəm</a></li>
                            <li> <a class=""nav-link"" data-toggle=""tab"" href=""#orders"">Sifariş</a></li>
                            <li><a class=""nav-link"" data-toggle=""tab"" href=""#address"">Addresses</a></li>
                            <li><a class=""nav-link"" data-toggle=""tab"" href=""#account-details"">Account details</a></li>
                            <li>");
            EndContext();
            BeginContext(2703, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d344621a1fb341b5bbe1c8488a7bf5da", async() => {
                BeginContext(2768, 5, true);
                WriteLiteral("Çıxış");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2777, 3318, true);
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                    <div class=""col-lg-10"">
                        <!-- Tab panes -->
                        <div class=""tab-content dashboard-content mt-all-40"">
                            <div id=""dashboard"" class=""tab-pane fade show active"">
                                <h3>Dashboard </h3>
                                <p>From your account dashboard. you can easily check & view your <a href=""#"">recent orders</a>, manage your <a href=""#"">shipping and billing addresses</a> and <a href=""#"">edit your password and account details.</a></p>
                            </div>
                            <div id=""orders"" class=""tab-pane fade"">
                                <h3>Orders</h3>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                         ");
            WriteLiteral(@"                       <th>Order</th>
                                                <th>Date</th>
                                                <th>Status</th>
                                                <th>Total</th>
                                                <th>Actions</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>1</td>
                                                <td>sep 10, 2018</td>
                                                <td>Processing</td>
                                                <td>$25.00 for 1 item </td>
                                                <td><a class=""view"" href=""cart.html"">view</a></td>
                                            </tr>
                                            <tr>
                                                <");
            WriteLiteral(@"td>2</td>
                                                <td>sep 10, 2018</td>
                                                <td>Processing</td>
                                                <td>$17.00 for 1 item </td>
                                                <td><a class=""view"" href=""cart.html"">view</a></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div id=""address"" class=""tab-pane"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <h4 class=""billing-address"">Billing address</h4>
                                <a class=""view"" href=""#"">edit</a>
                                <p>Bayazid Hasan</p>
                                <p>Bangladesh</p>
                            </div>
        ");
            WriteLiteral("                    <div id=\"account-details\" class=\"tab-pane fade\">\r\n                                <h3>Account details </h3>\r\n                                <div class=\"register-form login-form clearfix\">\r\n                                    ");
            EndContext();
            BeginContext(6095, 5758, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4def685048124c14b8b97c98c48b04e2", async() => {
                BeginContext(6112, 5734, true);
                WriteLiteral(@"
                                        <div class=""form-group row align-items-center"">
                                            <label class=""col-lg-3 col-md-4 col-form-label"">Social title</label>
                                            <div class=""col-lg-6 col-md-8"">
                                                <span class=""custom-radio""><input name=""id_gender"" value=""1"" type=""radio""> Mr.</span>
                                                <span class=""custom-radio""><input name=""id_gender"" value=""1"" type=""radio""> Mrs.</span>
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""f-name"" class=""col-lg-3 col-md-4 col-form-label"">First Name</label>
                                            <div class=""col-lg-6 col-md-8"">
                                                <input type=""text"" class=""form-control"" id=""f-name""");
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""l-name"" class=""col-lg-3 col-md-4 col-form-label"">Last Name</label>
                                            <div class=""col-lg-6 col-md-8"">
                                                <input type=""text"" class=""form-control"" id=""l-name"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""email"" class=""col-lg-3 col-md-4 col-form-label"">Email address</label>
                                            <div class=""col-lg-6 col-md-8"">
                                                <input type=""text"" class=""form-control"" id=""email"">
                                            </div>
                     ");
                WriteLiteral(@"                   </div>
                                        <div class=""form-group row"">
                                            <label for=""inputpassword"" class=""col-lg-3 col-md-4 col-form-label"">Current password</label>
                                            <div class=""col-lg-6 col-md-8"">
                                                <input type=""password"" class=""form-control"" id=""inputpassword"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""newpassword"" class=""col-lg-3 col-md-4 col-form-label"">New password</label>
                                            <div class=""col-lg-6 col-md-8"">
                                                <input type=""password"" class=""form-control"" id=""newpassword"">
                                                <button class=""btn show-btn"" type=""button"">Show</button>
   ");
                WriteLiteral(@"                                         </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""c-password"" class=""col-lg-3 col-md-4 col-form-label"">Confirm password</label>
                                            <div class=""col-lg-6 col-md-8"">
                                                <input type=""password"" class=""form-control"" id=""c-password"">
                                                <button class=""btn show-btn"" type=""button"">Show</button>
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""birth"" class=""col-lg-3 col-md-4 col-form-label"">Birthdate</label>
                                            <div class=""col-lg-6 col-md-8"">
                                                <input type");
                WriteLiteral(@"=""text"" class=""form-control"" id=""birth"" placeholder=""MM/DD/YYYY"">
                                            </div>
                                        </div>
                                        <div class=""form-check row p-0 mt-20"">
                                            <div class=""col-lg-6 offset-lg-3 col-md-8 offset-md-4"">
                                                <input class=""form-check-input"" value=""#"" id=""offer"" type=""checkbox"">
                                                <label class=""form-check-label"" for=""offer"">Receive offers from our partners</label>
                                            </div>
                                        </div>
                                        <div class=""form-check row p-0 mt-20"">
                                            <div class=""col-lg-6 offset-lg-3 col-md-8 offset-md-4"">
                                                <input class=""form-check-input"" value=""#"" id=""subscribe"" type=""checkbox"">
                   ");
                WriteLiteral(@"                             <label class=""form-check-label"" for=""subscribe"">Sign up for our newsletter<br>Subscribe to our newsletters now and stay up-to-date with new collections, the latest lookbooks and exclusive offers..</label>
                                            </div>
                                        </div>
                                        <div class=""register-box mt-40"">
                                            <button type=""submit"" class=""return-customer-btn float-right"">Save</button>
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11853, 262, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- My Account Page End Here -->

</main>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
