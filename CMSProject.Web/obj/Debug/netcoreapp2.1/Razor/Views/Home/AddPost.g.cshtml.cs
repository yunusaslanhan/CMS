#pragma checksum "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5a34a29724659f0286651b8fb43e22579bf0d2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddPost), @"mvc.1.0.view", @"/Views/Home/AddPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddPost.cshtml", typeof(AspNetCore.Views_Home_AddPost))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a34a29724659f0286651b8fb43e22579bf0d2f", @"/Views/Home/AddPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7350d03621d210093b31fe6512eec835a72ef9b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMSProject.Common.Dtos.LayoutDto>
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
#line 2 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
  
    ViewData["Title"] = "AddPost";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 976, true);
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""portlet light bordered"">
        <div class=""portlet-title"">
            <div class=""caption"">
                <i class=""icon-settings font-dark""></i>
                <span class=""caption-subject font-dark sbold uppercase"">Post</span>
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
            BeginContext(1107, 3395, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6435fa459a8c4d65a52c558fc3125141", async() => {
                BeginContext(1149, 314, true);
                WriteLiteral(@"
                <div class=""form-body"">


                    <div class=""form-group"">
                        <label class=""col-md-2 control-label"">MainPage Listesi :</label>
                        <div class=""col-md-9"">
                            <select id=""selectItemMainPage"" class=""form-control"">
");
                EndContext();
#line 34 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
                                 foreach (var item in Model.mainPageDtos)
                                {

#line default
#line hidden
                BeginContext(1573, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1609, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f74d21144e40c6b40b5f51cb2d12da", async() => {
                    BeginContext(1635, 9, false);
#line 36 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
                                       WriteLiteral(item.Id);

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
                BeginContext(1653, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
                                }

#line default
#line hidden
                BeginContext(1690, 2429, true);
                WriteLiteral(@"

                            </select>
                        </div>

                    </div>
                    <div class=""form-group"">
                        <label class=""col-md-2 control-label"">Post Başlık :</label>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""postTitle"" class=""form-control"">

                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-md-2 control-label"">Açıklama :</label>
                        <div class=""col-md-9"">
                            <textarea class=""form-control"" id=""postDescription"" rows=""3""></textarea>
                        </div>

                    </div>

                   
                        <div class=""form-group"" style=""margin-left:172px;"">
                            <div class=""fileinput fileinput-new"" data-provides=""fileinput"">
                                <div class=""fileinput-new th");
                WriteLiteral(@"umbnail"" style=""width: 200px; height: 150px;"">
                                    <img src=""http://www.placehold.it/200x150/EFEFEF/AAAAAA&amp;text=no+image"" alt="""">
                                </div>
                                <div class=""fileinput-preview fileinput-exists thumbnail"" style=""max-width: 200px; max-height: 150px; line-height: 10px;""></div>
                                <div>
                                    <span class=""btn default btn-file"">
                                        <span class=""fileinput-new""> Resim Yükle </span>
                                        <span class=""fileinput-exists""> Değiştir </span>
                                        <input type=""hidden"" value="""" name=""...""><input type=""file"" id=""pic"" name=""pic"">
                                    </span>
                                    <a href=""javascript:;"" class=""btn default fileinput-exists"" data-dismiss=""fileinput""> Sil </a>
                                </div>
                       ");
                WriteLiteral(@"     </div>
                           
                        </div>
                       
                 



                    <div class=""form-group"">
                        <label class=""col-md-2 control-label"">Layout Listesi :</label>
                        <div class=""col-md-9"">
                            <select id=""selectItem"" class=""form-control"">
");
                EndContext();
#line 86 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
                                 foreach (var item in Model.layoutDtos)
                                {

#line default
#line hidden
                BeginContext(4227, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(4263, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70467562aa244703aee9538744b4b918", async() => {
                    BeginContext(4289, 9, false);
#line 88 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 88 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
                                       WriteLiteral(item.Id);

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
                BeginContext(4307, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 89 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\AddPost.cshtml"
                                }

#line default
#line hidden
                BeginContext(4344, 151, true);
                WriteLiteral("\r\n\r\n                            </select>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n                </div>\r\n\r\n            ");
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
            BeginContext(4502, 611, true);
            WriteLiteral(@"

            <button style=""margin-left:81.75%"" type=""submit"" class=""btn green"" onclick=""GetLayout()"">Layout Seç</button>

           
        </div>

    </div>
</div>

<div id=""dynamicContent"">

</div>





<script type=""text/javascript"">
    function GetLayout() {
        var layoutId = $('#selectItem').val();
        $.ajax({
            url: ""/Home/LayoutDesign"",
            data: { 'LayoutId': layoutId },
            method: ""POST"",
            success: function (response) {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMSProject.Common.Dtos.LayoutDto> Html { get; private set; }
    }
}
#pragma warning restore 1591