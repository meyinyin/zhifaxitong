#pragma checksum "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d9ca7ffa6bcfe39ae661b48ed95c6a25341d2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d9ca7ffa6bcfe39ae661b48ed95c6a25341d2e", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6af7b194a8d6b7a56bc4ec8e78572e1b9e4013", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maticsoft.Model.Message>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-area "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Contact/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";
    bool IsSuccess = (bool)ViewBag.IsSuccess;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\Contact.cshtml"
 if (IsSuccess)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"showMsg\">\r\n");
            WriteLiteral(@"    </div>
    <script>
        let showMsg = document.getElementById('showMsg')
        console.log(showMsg)
        if (showMsg) {
            //setTimeout(() => {
            //    showMsg.parentNode.removeChild(showMsg);
            //}, 2000)
            setTimeout(() => {
                alert(""提交成功!"");
            }, 500)
        }

    </script>
");
#nullable restore
#line 30 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\Contact.cshtml"
}

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
                    联系我们
                </h1>
                <p class=""text-white""><a href=""index.html"">首页 </a>  <span class=""lnr lnr-arrow-right""></span>  <a href=""contact.html"">联系我们</a></p>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<!-- Start contact-page Area -->
<section class=""contact-page-area section-gap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""map-wrap"" style=""width:100%; height: 20px;"" id=""map""></div>
            <div class=""col-lg-4 d-flex flex-column"">
                <a class=""contact-btns"" href=""#"">提交简历</a>
                <a class=""contact-btns"" href=""/Manger/Index"">发布工作</a>
             ");
            WriteLiteral("   <a class=\"contact-btns\" href=\"/Home/Index\">再看看</a>\r\n            </div>\r\n            <div class=\"col-lg-8\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88d9ca7ffa6bcfe39ae661b48ed95c6a25341d2e6524", async() => {
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-12 form-group\">\r\n                            <input name=\"MDate\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2113, "\"", 2166, 1);
#nullable restore
#line 60 "F:\李瑞鹏\C#\自贡市城乡执法系统\zhongyiCore\Views\Home\Contact.cshtml"
WriteAttributeValue("", 2121, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), 2121, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <input name=""MName"" placeholder=""输入您的名字*"" class=""common-input mb-20 form-control"" required=""required"" type=""text"">

                            <input name=""avg2"" placeholder=""输入您的手机号码*"" class=""common-input mb-20 form-control"" required=""required"" type=""text"">

                            <input name=""MEmail"" placeholder=""输入您的电子邮箱"" class=""common-input mb-20 form-control"" type=""email"">
                            <textarea class=""common-textarea mt-10 form-control"" name=""MContent"" placeholder=""您的详细求职信息*"" required=""required"" type=""text""></textarea>
                            <button class=""primary-btn mt-20 text-white"" style=""float: right;"" type=""submit"">提交</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- End contact-page Area -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maticsoft.Model.Message> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
