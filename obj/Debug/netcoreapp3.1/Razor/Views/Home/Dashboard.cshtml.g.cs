#pragma checksum "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ab8baaa74c80e27ae8d87c5962114129deb9616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 7 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\_ViewImports.cshtml"
using DevTrack.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ab8baaa74c80e27ae8d87c5962114129deb9616", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77bfbfdc5a1e1ced856af1834e3768cfd57a2176", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Workspace", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
Write(await Html.PartialAsync("_NewWorkspace", new NewWorkspaceModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
Write(await Html.PartialAsync("_NewProject", new NewProjectModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
Write(await Html.PartialAsync("_NewTask", new NewTaskModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ab8baaa74c80e27ae8d87c5962114129deb96165740", async() => {
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
            WriteLiteral(@"
    <h3>My Workspaces</h3>
<table class=""table table-striped table-bordered table-hover table-condensed table-light"">
    <thead>
        <th>Workspace Name</th>
        <th>Projects</th>
        <th>CoWorkers</th>
        <th>Created Date</th>
    </thead>
");
#nullable restore
#line 20 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
      
        foreach (var a in @ViewBag.AllWorkspaces)
        {
            if(@a.UserId == @Context.Session.GetInt32("UserId"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ab8baaa74c80e27ae8d87c5962114129deb96167364", async() => {
#nullable restore
#line 26 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
                                                                                                 Write(a.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
                                                                          WriteLiteral(a.WorkspaceId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
                   Write(a.Projects.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
                   Write(a.CoWorkers.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
                   Write(a.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "D:\OneDrive\Momo's Folder\m0m0-d3vProjects\DevTrack\Views\Home\Dashboard.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>
<table class=""table table-striped table-bordered table-hover table-condensed table-light"">
    <thead>
        <th>Favorite Projects</th>
        <th>Upcoming Tasks</th>
        <tr>
            <td>Placeholder for Project Name</td>
            <td>Placeholder for Project Tasks</td>
        </tr>
    </thead>
</table>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
