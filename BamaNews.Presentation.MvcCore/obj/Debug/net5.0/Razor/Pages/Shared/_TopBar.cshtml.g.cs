#pragma checksum "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_TopBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0487159ea7276adecb5a8c302cfdfc447815fd6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BamaNews.Presentation.MvcCore.Pages.Shared.Pages_Shared__TopBar), @"mvc.1.0.view", @"/Pages/Shared/_TopBar.cshtml")]
namespace BamaNews.Presentation.MvcCore.Pages.Shared
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
#line 1 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\_ViewImports.cshtml"
using BamaNews.Presentation.MvcCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0487159ea7276adecb5a8c302cfdfc447815fd6c", @"/Pages/Shared/_TopBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5512d021c6336c5d6994a623cf6952ca59cf6915", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__TopBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"top-bar\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"top-bar-wrap top-bar-left\">\r\n                    <ul class=\"top-bar-info text-center-xs\">\r\n");
#nullable restore
#line 8 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_TopBar.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"info-item\">\r\n                                <a href=\"#\" class=\"info-link\">\r\n                                    <i class=\"ion ion-person\"></i>\r\n                                    <span class=\"info-text\">");
#nullable restore
#line 13 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_TopBar.cshtml"
                                                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </a>\r\n                            </li>\r\n");
            WriteLiteral("                            <li class=\"info-item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0487159ea7276adecb5a8c302cfdfc447815fd6c5382", async() => {
                WriteLiteral("\r\n                                    <button style=\"color:white\" type=\"submit\" class=\"nav-link btn btn-link\">خروج</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 22 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_TopBar.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""info-item"">
                                <a href=""/User"" class=""info-link"">
                                    <i class=""ion ion-person""></i>
                                    <span class=""info-text"">
                                        ورود
                                    </span>
                                </a>
                            </li>
                            <li class=""info-item"">
                                <a href=""/Register"" class=""info-link"">
                                    <i class=""ion ion-person""></i>
                                    <span class=""info-text"">
                                        ثبت نام
                                    </span>
                                </a>
                            </li>
");
#nullable restore
#line 42 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_TopBar.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""info-item"">
                            <a href=""#"" class=""info-link"">
                                <i class=""info-icon ion-flame red""></i>
                                <span class=""info-text"">داغ</span>
                            </a>
                        </li>
                        <li class=""info-item"">
                            <a href=""#"" class=""info-link"">
                                <i class=""info-icon ion-android-star yellow""></i>
                                <span class=""info-text"">محبوب</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""top-bar-wrap top-bar-right"">
                    <div class=""top-bar-social-networks text-right text-center-xs"">
                        <div class=""inner"">
                            <a class=""hint--bounce hint--bottom"" aria-label=""Facebook"" hr");
            WriteLiteral(@"ef=""https://facebook.com/"" target=""_blank"">
                                <i class=""fa fa-facebook""></i>
                            </a>
                            <a class=""hint--bounce hint--bottom"" aria-label=""Twitter"" href=""https://twitter.com/"" target=""_blank"">
                                <i class=""fa fa-twitter""></i>
                            </a>
                            <a class=""hint--bounce hint--bottom"" aria-label=""Instagram"" href=""https://www.instagram.com/"" target=""_blank"">
                                <i class=""fa fa-instagram""></i>
                            </a>
                            <a class=""hint--bounce hint--bottom"" aria-label=""Dribbble"" href=""https://www.dribbble.com/"" target=""_blank"">
                                <i class=""fa fa-dribbble""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
