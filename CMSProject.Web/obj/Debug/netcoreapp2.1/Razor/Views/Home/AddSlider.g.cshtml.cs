#pragma checksum "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddSlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505750f8a00183b0f86ac12c11add3f643007c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddSlider), @"mvc.1.0.view", @"/Views/Home/AddSlider.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddSlider.cshtml", typeof(AspNetCore.Views_Home_AddSlider))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505750f8a00183b0f86ac12c11add3f643007c8d", @"/Views/Home/AddSlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7350d03621d210093b31fe6512eec835a72ef9b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddSlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMSProject.Common.Dtos.PostDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddSlider.cshtml"
  
    ViewData["Title"] = "AddSlider";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 978, true);
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""portlet light bordered"">
        <div class=""portlet-title"">
            <div class=""caption"">
                <i class=""icon-settings font-dark""></i>
                <span class=""caption-subject font-dark sbold uppercase"">Slider</span>
            </div>
            <div class=""actions"">
                <div class=""btn-group btn-group-devided"" data-toggle=""buttons"">
                    <label class=""btn btn-transparent dark btn-outline btn-circle btn-sm active"">
                        <input type=""radio"" name=""options"" class=""toggle"" id=""option1"">Actions
                    </label>
                    <label class=""btn btn-transparent dark btn-outline btn-circle btn-sm"">
                        <input type=""radio"" name=""options"" class=""toggle"" id=""option2"">Settings
                    </label>
                </div>
            </div>
        </div>
        <div class=""portlet-body form"">
            ");
            EndContext();
            BeginContext(1109, 932, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac5c5152601c4cd1b495f5d8f5df6ce9", async() => {
                BeginContext(1151, 373, true);
                WriteLiteral(@"
                <div class=""form-body"">
                    <div class=""form-group"">
                        
                        <label style=""margin-left:1%"" class=""col-md-2 control-label"">Post Listesi :</label>
                        <div style=""margin-left:-2%"" class=""col-md-5"">
                            <select id=""selectItem"" class=""form-control"">

");
                EndContext();
#line 34 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddSlider.cshtml"
                                 foreach (var item in Model.postDtos)
                                {


#line default
#line hidden
                BeginContext(1632, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1668, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242b8f54b59b422da8e630b3da926a44", async() => {
                    BeginContext(1698, 14, false);
#line 37 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddSlider.cshtml"
                                                            Write(item.PostTitle);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddSlider.cshtml"
                                       WriteLiteral(item.PostId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1721, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddSlider.cshtml"
                                }

#line default
#line hidden
                BeginContext(1758, 276, true);
                WriteLiteral(@"
                            </select>
                        </div>
                        <button style=""margin-left:5%"" type=""button"" class=""btn green"" onclick=""AddSlider()"">Slider Ekle</button>
                    </div>



                </div>

            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(2041, 57, true);
            WriteLiteral("\r\n            <div id=\"dynamicContent\">\r\n                ");
            EndContext();
            BeginContext(2099, 48, false);
#line 51 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddSlider.cshtml"
           Write(Html.Partial("SliderPartial", @Model.sliderDtos));

#line default
#line hidden
            EndContext();
            BeginContext(2147, 971, true);
            WriteLiteral(@"
            </div>
        </div>

    </div>
</div>

<script type=""text/javascript"">
    function AddSlider() {
        var postId = $('#selectItem').val();
       
        $.ajax({
            url: ""/Home/AddSliderForAjax"",
            data: { 'PostId': postId },
            method: ""POST"",
            success: function (response) {
                alert(""Slider Başarıyla Eklendi!!!"");
                $(""#dynamicContent"").html(response);
            }
        });
    }
</script>


<script type=""text/javascript"">
    function DeleteSlider(postImageId) {

        var deletePostIamageId = postImageId;

        $.ajax({
            url: ""/Home/DeleteSlider"",
            data: { 'PostImageId': deletePostIamageId },
            method: ""POST"",
            success: function (response) {
                alert(""Slider Silindi!!!"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMSProject.Common.Dtos.PostDto> Html { get; private set; }
    }
}
#pragma warning restore 1591