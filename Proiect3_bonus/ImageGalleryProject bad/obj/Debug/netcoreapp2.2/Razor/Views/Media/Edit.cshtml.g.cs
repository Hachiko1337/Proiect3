#pragma checksum "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Media\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f11f6d1ca5dcceb495589b61f1c442fe40a7349c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Media_Edit), @"mvc.1.0.view", @"/Views/Media/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Media/Edit.cshtml", typeof(AspNetCore.Views_Media_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f11f6d1ca5dcceb495589b61f1c442fe40a7349c", @"/Views/Media/Edit.cshtml")]
    public class Views_Media_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageGalleryProject.ViewModels.MediaViewModels.MediaEditViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Media\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(116, 697, true);
            WriteLiteral(@"
<h1>Edit</h1>

<h4>MediaEditViewModel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"" enctype=""multipart/form-data"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""File"" class=""control-label""></label>
                <input asp-for=""File"" class=""form-control""/>
                <span asp-validation-for=""File"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ImagePath"" class=""control-label""></label>
                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 813, "\"", 851, 1);
#line 23 "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Media\Edit.cshtml"
WriteAttributeValue("", 819, "/uploads/" + Model.ImagePath, 819, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(852, 327, true);
            WriteLiteral(@" />
                <span asp-validation-for=""ImagePath"" class=""text-danger""></span>
            </div>
            <div>

            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryId"" class=""control-label""></label>
                <select asp-for=""CategoryId"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("asp-items", " asp-items=\"", 1179, "\"", 1261, 1);
#line 31 "C:\Users\hachi\source\repos\ImageGalleryProject\Views\Media\Edit.cshtml"
WriteAttributeValue("", 1191, new SelectList(ViewBag.Categories, "Id", "Title", Model.CategoryId), 1191, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1262, 286, true);
            WriteLiteral(@"></select>
                <span asp-validation-for=""CategoryId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageGalleryProject.ViewModels.MediaViewModels.MediaEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
