#pragma checksum "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Project\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a6d49603f499805d7e30fd073fbfcc9febf106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Info), @"mvc.1.0.view", @"/Views/Project/Info.cshtml")]
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
#line 1 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\_ViewImports.cshtml"
using DevTrack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\_ViewImports.cshtml"
using DevTrack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\_ViewImports.cshtml"
using DevTrack.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\_ViewImports.cshtml"
using DevTrack.Models.Workspaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\_ViewImports.cshtml"
using DevTrack.Models.Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a6d49603f499805d7e30fd073fbfcc9febf106", @"/Views/Project/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108c1a6414507edbe2b7be0dacecd51430ffdf48", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/wsinfo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Project\Info.cshtml"
  
    ViewData["Title"] = @Model.Name;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7a6d49603f499805d7e30fd073fbfcc9febf1064865", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7a6d49603f499805d7e30fd073fbfcc9febf1065127", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n<div class=\"row top\">\r\n<h3>Project: ");
#nullable restore
#line 9 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Project\Info.cshtml"
        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("</div>\r\n<div class=\"main\">\r\n<div class=\"row\">\r\n    <div class=\"col-md-3 left\">\r\n        <h4>Description</h4>\r\n");
            WriteLiteral(@"        <h4>CoWorkers</h4>
        <p>placeholder for form selection to find Developers to add to this Project</p>

    </div>
    <div class=""col-md-9"">
        <h4>Stuff inside this project like tasks</h4>
        <div class=""pcards col-md-12"">
            maybe loop for tasks?
");
            WriteLiteral("        </div>\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectModel> Html { get; private set; }
    }
}
#pragma warning restore 1591