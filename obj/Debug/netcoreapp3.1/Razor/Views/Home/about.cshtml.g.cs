#pragma checksum "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3d80550fb2c0415b9ff5a1082958e8e3d6d552e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_about), @"mvc.1.0.view", @"/Views/Home/about.cshtml")]
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
#line 1 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\_ViewImports.cshtml"
using zhongyiCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\_ViewImports.cshtml"
using zhongyiCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d80550fb2c0415b9ff5a1082958e8e3d6d552e", @"/Views/Home/about.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6af7b194a8d6b7a56bc4ec8e78572e1b9e4013", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_about : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maticsoft.Model.About>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- start banner Area -->
<section class=""banner-area relative"" id=""home"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"">
            <div class=""about-content col-lg-12"">
                <h1 class=""text-white"">
                    关于我们
                </h1>
                <p class=""text-white link-nav""><a href=""/Home/Index"">首页 </a>  <span class=""lnr lnr-arrow-right""></span>  <a href=""/Home/About""> 关于我们</a></p>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<section class=""service-area section-gap"" id=""service"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""col-md-8 pb-40 header-text"">
                <h1>为什么选择我们</h1>
                <p>
                    Why Choose Us
                </p>
            </div>
        </div>
        <div class=""row"">
           
            <div class=""col");
            WriteLiteral("-lg-4 col-md-6\">\r\n                <div class=\"single-service\">\r\n                    <h4><span class=\"lnr lnr-user\"></span>");
#nullable restore
#line 34 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                                                     Write(Model.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>\r\n                        ");
#nullable restore
#line 36 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                   Write(Model.JDtxt1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-md-6\">\r\n                <div class=\"single-service\">\r\n                    <h4><span class=\"lnr lnr-license\"></span>");
#nullable restore
#line 42 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                                                        Write(Model.Title3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>\r\n                        ");
#nullable restore
#line 44 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                   Write(Model.JDtxt2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-md-6\">\r\n                <div class=\"single-service\">\r\n                    <h4><span class=\"lnr lnr-phone\"></span>");
#nullable restore
#line 50 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                                                      Write(Model.Title4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>\r\n                       ");
#nullable restore
#line 52 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                  Write(Model.JDtxt3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-md-6\">\r\n                <div class=\"single-service\">\r\n                    <h4><span class=\"lnr lnr-rocket\"></span>");
#nullable restore
#line 58 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                                                       Write(Model.Title5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>\r\n                       ");
#nullable restore
#line 60 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                  Write(Model.JDtxt4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-md-6\">\r\n                <div class=\"single-service\">\r\n                    <h4><span class=\"lnr lnr-diamond\"></span>");
#nullable restore
#line 66 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                                                        Write(Model.Title5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>\r\n                        ");
#nullable restore
#line 68 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                   Write(Model.JDtxt5);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-md-6\">\r\n                <div class=\"single-service\">\r\n                    <h4><span class=\"lnr lnr-bubble\"></span>");
#nullable restore
#line 74 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                                                       Write(Model.PicURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>\r\n                       ");
#nullable restore
#line 76 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                  Write(Model.JDtxt6);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End service Area -->
<!-- Start feature Area -->
 -->
<!-- End feature Area -->
<!-- Start callto-action Area -->
<section class=""callto-action-area section-gap"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""menu-content col-lg-9"">
                <div class=""title text-center"">
                    <h1 class=""mb-10 text-white"">立即加入我们</h1>
                    <p class=""text-white""><p>企业安全理念：以人为本，生命至上，事前预防，主动管理。</p>
                    <p>企业文化目标：用先进的理念引导人，用优良的作风鼓舞人</p>
                    <p>服务宗旨：优秀的团队  专业的服务</p>
                    </p>
                    <a class=""primary-btn"" href=""/Home/Contact/"">预约面试</a>
                    <a class=""primary-btn"" href=""/Home/Contact/"">立即申请</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End calto-action Area -->
<!-- Start testimonia");
            WriteLiteral(@"l Area -->
<section class=""testimonial-area section-gap"" id=""review"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""menu-content pb-60 col-lg-8"">
                <div class=""title text-center"">
                    <h1 class=""mb-10"">众益技能培训学校</h1>
                    <p>学校培训及剪影</p>

                </div>

            </div>
        </div>
        <div class=""row"">
            <div class=""active-review-carusel"">
                <div class=""single-review"">

                    <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 4439, "\"", 4459, 1);
#nullable restore
#line 123 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
WriteAttributeValue("", 4445, Model.PicURL1, 4445, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 515px; height: 300px;\">\r\n\r\n                </div>\r\n                <div class=\"single-review\">\r\n                    <div class=\"title d-flex flex-row\">\r\n                        <h4>");
#nullable restore
#line 128 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                       Write(Model.PicURL5);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                        <div class=""star"" id=""star_1"">
                            
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                        </div>
                    </div>
                    <p>
                     ");
#nullable restore
#line 139 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                Write(Model.JDtxt7);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review\">\r\n\r\n                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 5373, "\"", 5393, 1);
#nullable restore
#line 144 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
WriteAttributeValue("", 5379, Model.PicURL2, 5379, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 515px; height: 300px;\">\r\n\r\n                </div>\r\n                <div class=\"single-review\">\r\n");
            WriteLiteral("                    <div class=\"title d-flex flex-row\">\r\n                        <h4>");
#nullable restore
#line 150 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                       Write(Model.PicURL6);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                        <div class=""star"">
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star""></span>
                        </div>
                    </div>
                    <p>
                        ");
#nullable restore
#line 160 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                   Write(Model.JDtxt8);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review\">\r\n\r\n                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 6319, "\"", 6339, 1);
#nullable restore
#line 165 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
WriteAttributeValue("", 6325, Model.PicURL3, 6325, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 515px; height: 300px;\">\r\n\r\n                </div>\r\n                <div class=\"single-review\">\r\n");
            WriteLiteral("                    <div class=\"title d-flex flex-row\">\r\n                        <h4>");
#nullable restore
#line 171 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                       Write(Model.PicURL7);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                        <div class=""star"">
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star""></span>
                        </div>
                    </div>
                    <p>
                        ");
#nullable restore
#line 181 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                   Write(Model.JDtxt9);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review\">\r\n\r\n                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 7265, "\"", 7285, 1);
#nullable restore
#line 186 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
WriteAttributeValue("", 7271, Model.PicURL4, 7271, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 515px; height: 300px;\">\r\n\r\n                </div>\r\n                <div class=\"single-review\">\r\n");
            WriteLiteral("                    <div class=\"title d-flex flex-row\">\r\n                        <h4>");
#nullable restore
#line 192 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                       Write(Model.PicURL8);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                        <div class=""star"">
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star""></span>
                        </div>
                    </div>
                    <p>
                        ");
#nullable restore
#line 202 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\about.cshtml"
                   Write(Model.JDtxt10);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>
<script type=""text/javascript"">
    //window.onload = () => {
    //    var str1 = document.getElementById(""star_1"")

    //    var obj = document.createElement(""span"")
    //    var ooo = str1.appendChild(obj)
    //    var ppp = str1.getElementsByClassName(""span"")[0].classList.add(""fa"", ""fa-star"", ""checked"")
    //    console.log(ppp)
    //    //for (var i = 0; i < 3; i++) {
    //    //    str1.appendChild(document.createElement(""span"").classList.add(""fa"", ""fa-star"", ""checked""))
    //    //}
    //}
</script>
<!-- End testimonial Area -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maticsoft.Model.About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
