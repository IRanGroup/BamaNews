#pragma checksum "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Areas\Administrator\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937f276bd8d6c32ad35a9aa10481c72c078efc4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Onion.Presentation.Areas.Administrator.Pages.Areas_Administrator_Pages_Index), @"mvc.1.0.razor-page", @"/Areas/Administrator/Pages/Index.cshtml")]
namespace Onion.Presentation.Areas.Administrator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"937f276bd8d6c32ad35a9aa10481c72c078efc4c", @"/Areas/Administrator/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876095a2c6c38372b32de27da760084e90170f72", @"/Areas/Administrator/Pages/_ViewImports.cshtml")]
    public class Areas_Administrator_Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Areas\Administrator\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"container\">\r\n        <!-- start row AllNewsCategory -->\r\n        ");
#nullable restore
#line 10 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Areas\Administrator\Pages\Index.cshtml"
   Write(await Component.InvokeAsync("NewsCategoryAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- end row -->\r\n        <!-- start row News -->\r\n        ");
#nullable restore
#line 13 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Areas\Administrator\Pages\Index.cshtml"
   Write(await Component.InvokeAsync("NewsAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- End row News -->\r\n        <!-- start row User -->\r\n        <div class=\"row\">\r\n\r\n            ");
#nullable restore
#line 18 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Areas\Administrator\Pages\Index.cshtml"
       Write(await Component.InvokeAsync("CommentAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- end col -->\r\n            ");
#nullable restore
#line 20 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Areas\Administrator\Pages\Index.cshtml"
       Write(await Component.InvokeAsync("UserAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- End row User -->\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <!-- container -->\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
