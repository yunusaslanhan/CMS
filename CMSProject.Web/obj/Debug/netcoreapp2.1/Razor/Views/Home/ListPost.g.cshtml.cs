#pragma checksum "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\ListPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "258a708ed05d98929b46be5423025eff9352b151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListPost), @"mvc.1.0.view", @"/Views/Home/ListPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListPost.cshtml", typeof(AspNetCore.Views_Home_ListPost))]
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
#line 1 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\_ViewImports.cshtml"
using CMSProject.Web;

#line default
#line hidden
#line 2 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\_ViewImports.cshtml"
using CMSProject.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"258a708ed05d98929b46be5423025eff9352b151", @"/Views/Home/ListPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7350d03621d210093b31fe6512eec835a72ef9b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMSProject.Common.Dtos.PostDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\ListPost.cshtml"
  
    ViewData["Title"] = "ListPost";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 37, true);
            WriteLiteral("\r\n\r\n<div id=\"dynamicContent\">\r\n\r\n    ");
            EndContext();
            BeginContext(174, 39, false);
#line 10 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\ListPost.cshtml"
Write(Html.Partial("ListPostPartial", @Model));

#line default
#line hidden
            EndContext();
            BeginContext(213, 441, true);
            WriteLiteral(@"

</div>


<script type=""text/javascript"">
    function DeletePage(postId) {

        var deletePostId = postId;

        $.ajax({
            url: ""/Home/DeletePost"",
            data: { 'PostId': deletePostId },
            method: ""POST"",
            success: function (response) {
                alert(""Post Silindi!!!"");
                $(""#dynamicContent"").html(response);
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CMSProject.Common.Dtos.PostDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
