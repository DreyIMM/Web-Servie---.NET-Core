#pragma checksum "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb268877788e948433745a66e880f3472cf3fb92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Summary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Summary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Summary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Summary_Default))]
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
#line 1 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\_ViewImports.cshtml"
using Dev.IO.App;

#line default
#line hidden
#line 2 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\_ViewImports.cshtml"
using Dev.IO.App.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb268877788e948433745a66e880f3472cf3fb92", @"/Views/Shared/Components/Summary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50544735bace796624ea11ccaac7e23bf868bd91", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Summary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-top: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (ViewData.ModelState.ErrorCount > 0)
{

#line default
#line hidden
            BeginContext(47, 44, true);
            WriteLiteral("    <div style=\"padding-top: 15px;\"></div>\r\n");
            EndContext();
            BeginContext(93, 207, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h3 id=\"msgRetorno\" style=\"padding-top: 20px\">Opa! Algo deu errado :(</h3>\r\n        ");
            EndContext();
            BeginContext(300, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb268877788e948433745a66e880f3472cf3fb924697", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 9 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(392, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 11 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
            BeginContext(409, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Sucesso))
{

#line default
#line hidden
            BeginContext(460, 43, true);
            WriteLiteral("    <div style=\"padding-top: 15px\"></div>\r\n");
            EndContext();
            BeginContext(505, 157, true);
            WriteLiteral("    <div id=\"msg_box\" class=\"alert alert-success\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h3 id=\"msgRetorno\">");
            EndContext();
            BeginContext(663, 15, false);
#line 19 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
                       Write(ViewBag.Sucesso);

#line default
#line hidden
            EndContext();
            BeginContext(678, 19, true);
            WriteLiteral("</h3>\r\n    </div>\r\n");
            EndContext();
#line 21 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
            BeginContext(700, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (TempData["Sucesso"] != null)
{

#line default
#line hidden
            BeginContext(740, 43, true);
            WriteLiteral("    <div style=\"padding-top: 15px\"></div>\r\n");
            EndContext();
            BeginContext(785, 157, true);
            WriteLiteral("    <div id=\"msg_box\" class=\"alert alert-success\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h4 id=\"msgRetorno\">");
            EndContext();
            BeginContext(943, 40, false);
#line 29 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
                       Write(Html.Raw(TempData["Sucesso"].ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(983, 19, true);
            WriteLiteral("</h4>\r\n    </div>\r\n");
            EndContext();
#line 31 "D:\DevIO_CURSO\WebServiceCamadas\src\Dev.IO.App\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
            BeginContext(1005, 2, true);
            WriteLiteral("\r\n");
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
