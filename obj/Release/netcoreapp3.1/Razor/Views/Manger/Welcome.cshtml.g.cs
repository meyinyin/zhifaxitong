#pragma checksum "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ada7c930d1e94551a3530a434fdce2381d02f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manger_Welcome), @"mvc.1.0.view", @"/Views/Manger/Welcome.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ada7c930d1e94551a3530a434fdce2381d02f8", @"/Views/Manger/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6af7b194a8d6b7a56bc4ec8e78572e1b9e4013", @"/Views/_ViewImports.cshtml")]
    public class Views_Manger_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/admin/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/admin/css/admin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/admin/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/admin/lib/echarts/echarts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\Welcome.cshtml"
  
    Layout = null;
    Maticsoft.BLL.Message mbll = new Maticsoft.BLL.Message();
    var mlist = mbll.GetModelList("").OrderByDescending(c => c.MDate).Take(5);

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09ada7c930d1e94551a3530a434fdce2381d02f86181", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no"" />
    <title>网站后台管理模版</title>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09ada7c930d1e94551a3530a434fdce2381d02f86750", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09ada7c930d1e94551a3530a434fdce2381d02f88015", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style>\r\n        .title-h {\r\n            overflow: hidden;\r\n            text-overflow: ellipsis;\r\n            /*display: -webkit-box;*/\r\n            -webkit-line-clamp: 1;\r\n            /*-webkit-box-orient: vertical;*/\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09ada7c930d1e94551a3530a434fdce2381d02f810251", async() => {
                WriteLiteral(@"
    <div class=""wrap-container welcome-container"">
        <div class=""row"">
            <div class=""welcome-left-container col-lg-9"">
                <div class=""data-show"">
                    <ul class=""clearfix"">
                        <li class=""col-sm-12 col-md-4 col-xs-12"">
                            <a href=""javascript:;"" class=""clearfix"">
                                <div class=""icon-bg bg-org f-l"">
                                    <span class=""iconfont"">&#xe606;</span>
                                </div>
                                <div class=""right-text-con"">
                                    <p class=""name"">会员数</p>
                                    <p><span class=""color-org"">89</span>数据<span class=""iconfont"">&#xe628;</span></p>
                                </div>
                            </a>
                        </li>
                        <li class=""col-sm-12 col-md-4 col-xs-12"">
                            <a href=""javascript:;"" class=""clearfix"">");
                WriteLiteral(@"
                                <div class=""icon-bg bg-blue f-l"">
                                    <span class=""iconfont"">&#xe602;</span>
                                </div>
                                <div class=""right-text-con"">
                                    <p class=""name"">文章数</p>
                                    <p><span class=""color-blue"">189</span>数据<span class=""iconfont"">&#xe628;</span></p>
                                </div>
                            </a>
                        </li>
                        <li class=""col-sm-12 col-md-4 col-xs-12"">
                            <a href=""javascript:;"" class=""clearfix"">
                                <div class=""icon-bg bg-green f-l"">
                                    <span class=""iconfont"">&#xe605;</span>
                                </div>
                                <div class=""right-text-con"">
                                    <p class=""name"">评论数</p>
                                    <p><span cl");
                WriteLiteral(@"ass=""color-green"">221</span>数据<span class=""iconfont"">&#xe60f;</span></p>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
                <!--图表-->
                <div class=""chart-panel panel panel-default"">
                    <div class=""panel-body"" id=""chart"" style=""height: 376px;"">
                    </div>
                </div>
                <!--服务器信息-->
                <div class=""server-panel panel panel-default"">
                    <div class=""panel-header"">服务器信息</div>
                    <div class=""panel-body clearfix"">
                        <div class=""col-md-2"">
                            <p class=""title"">服务器环境</p>
                            <span class=""info"">Apache/2.4.4 (Win32) PHP/5.4.16</span>
                        </div>
                        <div class=""col-md-2"">
                            <p class=""title"">服务器IP地址</p>
                            <span c");
                WriteLiteral(@"lass=""info"">127.0.0.1   </span>
                        </div>
                        <div class=""col-md-2"">
                            <p class=""title"">服务器域名</p>
                            <span class=""info"">localhost </span>
                        </div>
                        <div class=""col-md-2"">
                            <p class=""title""> PHP版本</p>
                            <span class=""info"">5.4.16</span>
                        </div>
                        <div class=""col-md-2"">
                            <p class=""title"">数据库信息</p>
                            <span class=""info"">5.6.12-log </span>
                        </div>
                        <div class=""col-md-2"">
                            <p class=""title"">服务器当前时间</p>
                            <span class=""info"">2016-06-22 11:37:35</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""welcome-edge col-lg-3"">
                <!--最");
                WriteLiteral(@"新留言-->
                <div class=""panel panel-default comment-panel"">
                    <div class=""panel-header"">最新留言</div>
                    <div class=""panel-body"">
                        <div class=""commentbox"">
                            <ul class=""commentList"">
");
#nullable restore
#line 111 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\Welcome.cshtml"
                                  
                                    foreach (var m in mlist)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li class=\"item cl\">\r\n                                            <a href=\"#\"><i class=\"avatar size-L radius\">");
#nullable restore
#line 115 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\Welcome.cshtml"
                                                                                   Write(m.MName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</i></a>
                                            <div class=""comment-main"">
                                                <header class=""comment-header"">
                                                    <div class=""comment-meta"">
                                                        <a class=""comment-author"" href=""#""></a> 评论于
                                                        ");
#nullable restore
#line 120 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\Welcome.cshtml"
                                                   Write(m.MDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    </div>
                                                </header>
                                                <div class=""comment-body"">
                                                    <p class=""title-h"">");
#nullable restore
#line 124 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\Welcome.cshtml"
                                                                  Write(m.MContent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                        </li>\r\n");
#nullable restore
#line 128 "F:\李瑞鹏\C#\zhongyiCore\Views\Manger\Welcome.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                            </ul>
                        </div>
                        <div id=""pagesbox"" style=""text-align: center;padding-top: 5px;"">

                        </div>
                    </div>
                </div>
                <!--联系-->
                <div class=""panel panel-default contact-panel"">
                    <div class=""panel-header"">联系我们</div>
                    <div class=""panel-body"">
                        <p>QQ：123456</p>

                    </div>
                </div>
            </div>
        </div>
    </div>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09ada7c930d1e94551a3530a434fdce2381d02f818101", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09ada7c930d1e94551a3530a434fdce2381d02f819288", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        layui.use(['layer', 'jquery'], function () {
            var layer = layui.layer;
            var $ = layui.jquery;
            //图表
            var myChart;
            require.config({
                paths: {
                    echarts: '/static/admin/lib/echarts'
                }
            });
            require(
                [
                    'echarts',
                    'echarts/chart/bar',
                    'echarts/chart/line',
                    'echarts/chart/map'
                ],
                function (ec) {
                    //--- 折柱 ---
                    myChart = ec.init(document.getElementById('chart'));
                    myChart.setOption(
                        {
                            title: {
                                text: ""数据统计"",
                                textStyle: {
                                    color: ""rgb(85, 85, 85)"",
                                    fontSiz");
                WriteLiteral(@"e: 18,
                                    fontStyle: ""normal"",
                                    fontWeight: ""normal""
                                }
                            },
                            tooltip: {
                                trigger: ""axis""
                            },
                            legend: {
                                data: [""会员"", ""文章"", ""评论""],
                                selectedMode: false,
                            },
                            toolbox: {
                                show: true,
                                feature: {
                                    dataView: {
                                        show: false,
                                        readOnly: true
                                    },
                                    magicType: {
                                        show: false,
                                        type: [""line"", ""bar"", ""stack"", ""tiled""]
               ");
                WriteLiteral(@"                     },
                                    restore: {
                                        show: true
                                    },
                                    saveAsImage: {
                                        show: true
                                    },
                                    mark: {
                                        show: false
                                    }
                                }
                            },
                            calculable: false,
                            xAxis: [
                                {
                                    type: ""category"",
                                    boundaryGap: false,
                                    data: [""周一"", ""周二"", ""周三"", ""周四"", ""周五"", ""周六"", ""周日""]
                                }
                            ],
                            yAxis: [
                                {
                                    type: ""value""
 ");
                WriteLiteral(@"                               }
                            ],
                            grid: {
                                x2: 30,
                                x: 50
                            },
                            series: [
                                {
                                    name: ""会员"",
                                    type: ""line"",
                                    smooth: true,
                                    itemStyle: {
                                        normal: {
                                            areaStyle: {
                                                type: ""default""
                                            }
                                        }
                                    },
                                    data: [10, 12, 21, 54, 260, 830, 710]
                                },
                                {
                                    name: ""文章"",
                                   ");
                WriteLiteral(@" type: ""line"",
                                    smooth: true,
                                    itemStyle: {
                                        normal: {
                                            areaStyle: {
                                                type: ""default""
                                            }
                                        }
                                    },
                                    data: [30, 182, 434, 791, 390, 30, 10]
                                },
                                {
                                    name: ""评论"",
                                    type: ""line"",
                                    smooth: true,
                                    itemStyle: {
                                        normal: {
                                            areaStyle: {
                                                type: ""default""
                                            },
                                 ");
                WriteLiteral(@"           color: ""rgb(110, 211, 199)""
                                        }
                                    },
                                    data: [1320, 1132, 601, 234, 120, 90, 20]
                                }
                            ]
                        }
                    );
                }
            );
            $(window).resize(function () {
                myChart.resize();
            })
        });
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
            WriteLiteral("\r\n</html>");
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