#pragma checksum "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67197ff8acac7956b9ffe7f09c24032f8cd11170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manger_NewsSort), @"mvc.1.0.view", @"/Views/Manger/NewsSort.cshtml")]
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
#nullable restore
#line 1 "F:\李瑞鹏\C#\zhongyiCore\Views\_ViewImports.cshtml"
using zhongyiCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\李瑞鹏\C#\zhongyiCore\Views\_ViewImports.cshtml"
using zhongyiCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67197ff8acac7956b9ffe7f09c24032f8cd11170", @"/Views/Manger/NewsSort.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6af7b194a8d6b7a56bc4ec8e78572e1b9e4013", @"/Views/_ViewImports.cshtml")]
    public class Views_Manger_NewsSort : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Maticsoft.Model.SortType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/admin/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/admin/css/admin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.4.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/admin/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/admin/js/common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
  
    Layout = null;
    bool IsSuccess = (bool)ViewBag.IsSuccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
 if (IsSuccess)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-success with-icon"" id=""showMsg"" style=""transition: all 1s; "">
        <i class=""icon-smile""></i>
        <div class=""content"">
            <h4>好消息</h4>
            分类修改成功！
        </div>
    </div>
    <script>
        let showMsg = document.getElementById('showMsg')
        console.log(showMsg)
        if (showMsg) {
            setTimeout(() => {
                showMsg.parentNode.removeChild(showMsg);
            }, 2000)
        }
    </script>
");
#nullable restore
#line 24 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67197ff8acac7956b9ffe7f09c24032f8cd111708598", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no"" />
    <title>官网后台</title>
");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67197ff8acac7956b9ffe7f09c24032f8cd111709198", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67197ff8acac7956b9ffe7f09c24032f8cd1117010376", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67197ff8acac7956b9ffe7f09c24032f8cd1117011555", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67197ff8acac7956b9ffe7f09c24032f8cd1117013447", async() => {
                WriteLiteral("\r\n    <div class=\"page-content-wrap\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67197ff8acac7956b9ffe7f09c24032f8cd1117013755", async() => {
                    WriteLiteral(@"
            <div class=""layui-form-item"">
                <div class=""layui-inline tool-btn"">
                    <button class=""layui-btn layui-btn-small layui-btn-normal addBtn"" data-url=""/Manger/NewsSortAdd""><i class=""layui-icon"">&#xe654;</i></button>
                    <button class=""layui-btn layui-btn-small layui-btn-warm "" data-url=""/Manger/NewsSort""><i class=""layui-icon"">&#x1002;</i></button>
                </div>
                <div class=""layui-inline"">
                    <input type=""text"" name=""title"" placeholder=""请输入标题"" autocomplete=""off"" class=""layui-input"">
                </div>
                <button class=""layui-btn layui-btn-normal"" lay-submit=""search"">搜索</button>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <div class=""layui-form"" id=""table-list"">
            <table class=""layui-table"" lay-even lay-skin=""nob"">
                <colgroup>
                    <col class=""hidden-xs"" width=""50"">
                    <col>
                    <col width=""80"">
                    <col width=""150"">
                </colgroup>
                <thead>
                    <tr>
                        <th class=""hidden-xs"">ID</th>
                        <th>分类名称</th>
                        <th>状态</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 73 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                      
                        int i = 0;
                        foreach (var m in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr");
                BeginWriteAttribute("id", " id=\"", 2997, "\"", 3012, 2);
                WriteAttributeValue("", 3002, "row", 3002, 3, true);
#nullable restore
#line 77 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
WriteAttributeValue("", 3005, m.ID, 3005, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <td class=\"hidden-xs\">");
#nullable restore
#line 78 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                                                  Write(++i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 79 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                               Write(m.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td");
                BeginWriteAttribute("onclick", " onclick=\"", 3168, "\"", 3222, 5);
                WriteAttributeValue("", 3178, "excaction1(\'/Manger/NewsSortSd/", 3178, 31, true);
#nullable restore
#line 80 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
WriteAttributeValue("", 3209, m.ID, 3209, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3214, "\',", 3214, 2, true);
#nullable restore
#line 80 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
WriteAttributeValue("", 3216, m.ID, 3216, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3221, ")", 3221, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 81 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                                     if (m.IsLock)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a");
                BeginWriteAttribute("id", " id=\"", 3359, "\"", 3375, 2);
                WriteAttributeValue("", 3364, "btn1", 3364, 4, true);
#nullable restore
#line 83 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
WriteAttributeValue("", 3368, m.ID, 3368, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\" layui-btn layui-btn-mini layui-btn-normal table-list-status\" data-toggle=\"modal\" data-target=\"#myModal1");
#nullable restore
#line 83 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                                                                                                                                                                       Write(m.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">显示</a>\r\n");
#nullable restore
#line 84 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a");
                BeginWriteAttribute("id", " id=\"", 3667, "\"", 3683, 2);
                WriteAttributeValue("", 3672, "btn1", 3672, 4, true);
#nullable restore
#line 87 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
WriteAttributeValue("", 3676, m.ID, 3676, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\" layui-btn layui-btn-mini layui-btn-warm table-list-status\" data-toggle=\"modal\" data-target=\"#myModal1");
#nullable restore
#line 87 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                                                                                                                                                                     Write(m.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">隐藏</a>\r\n");
#nullable restore
#line 88 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                                <td>
                                    <div class=""layui-inline"">
                                        <button class=""layui-btn layui-btn-mini layui-btn-normal  go-btn"" data-id=""1"" data-url=""/Manger/NewsSortEdit/");
#nullable restore
#line 93 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                                                                                                                                                Write(m.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("/\"><i class=\"layui-icon\">&#xe642;</i></button>\r\n");
                WriteLiteral("                                        <a");
                BeginWriteAttribute("href", " href=\"", 4442, "\"", 4474, 2);
                WriteAttributeValue("", 4449, "/Manger/NewsSortDel/", 4449, 20, true);
#nullable restore
#line 95 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
WriteAttributeValue("", 4469, m.ID, 4469, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"layui-btn layui-btn-mini layui-btn-danger\"><i class=\"layui-icon\">&#xe640;</i></a>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 99 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\NewsSort.cshtml"
                        }

                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
                WriteLiteral("        </div>\r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67197ff8acac7956b9ffe7f09c24032f8cd1117023086", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67197ff8acac7956b9ffe7f09c24032f8cd1117024277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67197ff8acac7956b9ffe7f09c24032f8cd1117025377", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script>
        function excaction1(href, data) {
            $.get(href, null, function (ret) {
                if (ret.IsSuccess) {
                    if ($('#btn1' + data).hasClass('layui-btn-warm'))
                        $('#btn1' + data).removeClass('layui-btn-warm').addClass('layui-btn-normal').text('显示');
                    else
                        $('#btn1' + data).removeClass('layui-btn-normal').addClass('layui-btn-warm').text('隐藏');
                }
            })
        }
                        //layui.use(['form', 'jquery', 'layer', 'dialog'], function () {
                        //    var $ = layui.jquery;

                                    //修改状态
                                    //$('#table-list').on('click', '.table-list-status', function() {
                                    //	var That = $(this);
                                    //	var status = That.attr('data-status');
                                    //	var id = That.parent().attr('data-");
                WriteLiteral(@"id');
                                    //	if(status == 1) {
                                    //		That.removeClass('layui-btn-normal').addClass('layui-btn-warm').html('隐藏').attr('data-status', 2);
                                    //	} else if(status == 2) {
                                    //		That.removeClass('layui-btn-warm').addClass('layui-btn-normal').html('显示').attr('data-status', 1);

                                    //	}
                                    //})

                        //        });

    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Maticsoft.Model.SortType>> Html { get; private set; }
    }
}
#pragma warning restore 1591