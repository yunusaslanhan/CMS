#pragma checksum "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "398a5fdbf244d13c038b740f006cb94bab20da5c"
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
#line 1 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\_ViewImports.cshtml"
using CMSProject.Web;

#line default
#line hidden
#line 2 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\_ViewImports.cshtml"
using CMSProject.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"398a5fdbf244d13c038b740f006cb94bab20da5c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7350d03621d210093b31fe6512eec835a72ef9b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Yunus\source\repos\CMSProject\CMSProject.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1478, true);
            WriteLiteral(@"


<div class=""portlet light bordered"">
    <div class=""portlet-title"">
        <div class=""caption font-red-sunglo"">
            <i class=""icon-settings font-red-sunglo""></i>
            <span class=""caption-subject bold uppercase""> Layout </span>
        </div>

        <div class=""actions"">
            <div class=""btn-group"">
                <a class=""btn btn-sm green dropdown-toggle"" href=""javascript:;"" data-toggle=""dropdown"">
                    Actions
                    <i class=""fa fa-angle-down""></i>
                </a>
                <ul class=""dropdown-menu pull-right"">
                    <li>
                        <a href=""javascript:;"">
                            <i class=""fa fa-pencil""></i> Edit
                        </a>
                    </li>
                    <li>
                        <a href=""javascript:;"">
                            <i class=""fa fa-trash-o""></i> Delete
                        </a>
                    </li>
                    <li");
            WriteLiteral(@">
                        <a href=""javascript:;"">
                            <i class=""fa fa-ban""></i> Ban
                        </a>
                    </li>
                    <li class=""divider""> </li>
                    <li>
                        <a href=""javascript:;""> Make admin </a>
                    </li>
                </ul>
            </div>
        </div>


    </div>
    <div class=""portlet-body form"">
        ");
            EndContext();
            BeginContext(1523, 1492, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39748d6d043c4a60a7ca4a1204ad9630", async() => {
                BeginContext(1541, 479, true);
                WriteLiteral(@"
            <div class=""form-body"">

                <label control-label"">Adı :</label>
                <div>
                    <input type=""text"" id=""layoutName"" name=""layoutName"" class=""form-control"" style=""width:783px"">

                </div>
                <br />
                <div class=""row"">
                    <div class=""col-md-6"">
                        <select class=""form-control"" id=""mySelect"" style=""width:100px"">
                            ");
                EndContext();
                BeginContext(2020, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ba3f00dafd4b6b890fb08e82da63da", async() => {
                    BeginContext(2028, 1, true);
                    WriteLiteral("1");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2038, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2068, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57a45103363a405b85d5db69373e59fa", async() => {
                    BeginContext(2076, 1, true);
                    WriteLiteral("2");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2086, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2116, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cafbc196609470c953af95decab48cd", async() => {
                    BeginContext(2124, 1, true);
                    WriteLiteral("3");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2134, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2164, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edc9d86b1ae54612bb06f943c42746e5", async() => {
                    BeginContext(2172, 1, true);
                    WriteLiteral("4");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2182, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2212, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b9d602726674b249327542eeb3e6641", async() => {
                    BeginContext(2220, 1, true);
                    WriteLiteral("5");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2230, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2260, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed88449107304d2ca612d92384273000", async() => {
                    BeginContext(2268, 1, true);
                    WriteLiteral("6");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2278, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2308, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba72a450eff94112b60e828d73ed004b", async() => {
                    BeginContext(2316, 1, true);
                    WriteLiteral("7");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2326, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2356, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61e0b164ea4343b38f1782243e9d4dd1", async() => {
                    BeginContext(2364, 1, true);
                    WriteLiteral("8");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2374, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2404, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9d4823bdbc4707a0e5f50373adfec1", async() => {
                    BeginContext(2412, 1, true);
                    WriteLiteral("9");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2422, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2452, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d6b5cf4e8c48a18d6d1c4f2df8730c", async() => {
                    BeginContext(2460, 2, true);
                    WriteLiteral("10");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2471, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2501, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "715a65b262fd4d0f9c532361d17d1e1a", async() => {
                    BeginContext(2509, 2, true);
                    WriteLiteral("11");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2520, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2550, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ffbaf455a14bdf86c15eaf50ccd528", async() => {
                    BeginContext(2558, 2, true);
                    WriteLiteral("12");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2569, 439, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""col-md-6"">
                        <button type=""button"" class=""btn btn-primary"" onclick=""AddDiv()"">Eleman Ekle</button>
                        <button type=""button"" class=""btn btn-success"" onclick=""SaveAll()"" style=""margin-left:8px"">Layoutu Kaydet</button>
                    </div>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3015, 3528, true);
            WriteLiteral(@"
    </div>
</div>

<div class=""portlet light bordered"">
    <div class=""portlet-title"">
        <div class=""caption"">
            <i class=""icon-settings font-dark""></i>
            <span class=""caption-subject font-dark sbold uppercase"">Önizleme</span>
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

        <div class=""form-body"">
            <div class=""col-md-12"" id=""main"">

                <div class=""row"" id="".row"">");
            WriteLiteral(@"



                </div>


            </div>
            <div>

            </div>
        </div>
    </div>

    <script type=""text/javascript"">

        var id = 0;
        function AddDiv() {

            var value = document.getElementById('mySelect').value;

            var div = document.createElement(""div"");

            div.className = ""col-md-"" + value;


            $(div).css({

                'border': '1px solid green',
                'height': '100px',
                'backgraund': '#fafafa'

            });
            $(div).attr({

                'id': 'divColumn' + '_' + id++,
                'data-colSize': value


            });


            $(div).html('<div class=""portlet light bordered"" style=""border:none!important;margin-bottom:0px;margin-top:10px"" > <div class=""portlet title"">  <input type=""text"" class=""form control input-small"" placeholder=""Adı"" style=""display:inline;width:77px!important;margin-left:-30px"" />  </div ></div > ');


");
            WriteLiteral(@"

            $('#main').children('.row').append(div);

        }

    </script>


    <script type=""text/javascript"">

        var divList = [];

        var obj = { Size: '', ComponentClass: '', Name: '' };


        function SaveAll() {

            $(""#main"").children('.row').find(""div[class^='col-']"").each(function () {

                var Name = $(this).find('input[type=text]').val();
               
                $(this).removeAttr(""style"");
                $(this).empty();

                obj = {

                    'Size': $(this).attr('data-colSize'),
                    'ComponentClass': $(this)[0].outerHTML,
                    'Name': Name
                };
                divList.push(obj);


            });


            var layoutName = $('#layoutName').val();
            var layout = { Name: layoutName, layoutComponentDtos: divList };
            console.log(layout);

            $.ajax({

                contentType: 'application/json',
     ");
            WriteLiteral(@"           datatype: 'json',
                url: '/Home/SaveLayout',
                method: 'post',
                data: JSON.stringify(layout),
                success: function (response) {
                    if (response) {
                        alert(""Şablon başarıyla eklendi!!!"");
                        location.href = response;
                    }

                }


            });




        }



    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591