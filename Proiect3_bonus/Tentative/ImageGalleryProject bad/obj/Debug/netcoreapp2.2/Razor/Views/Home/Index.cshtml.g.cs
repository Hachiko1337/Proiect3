#pragma checksum "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c93ccc65d04d061cde656f7ce2759063612548"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c93ccc65d04d061cde656f7ce2759063612548", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ImageGalleryProject.ViewModels.MediaViewModels.MediaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(126, 50, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 9 "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(225, 54, true);
            WriteLiteral("            <div class=\"col-md-3\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 279, "\"", 317, 1);
#line 12 "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 286, "/uploads/" + item.ImagePath, 286, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(318, 44, true);
            WriteLiteral(" target=\"_parent\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 362, "\"", 399, 1);
#line 13 "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 368, "/uploads/" + item.ImagePath, 368, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(400, 80, true);
            WriteLiteral(" alt=\"Lights\" class=\"img-thumbnail\">\r\n                </a>\r\n            </div>\r\n");
            EndContext();
#line 16 "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(491, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ImageGalleryProject.ViewModels.MediaViewModels.MediaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
