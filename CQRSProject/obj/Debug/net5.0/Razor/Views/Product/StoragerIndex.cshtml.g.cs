#pragma checksum "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/StoragerIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eecb65335822fce9c8b3ddb9b324891e47bc230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_StoragerIndex), @"mvc.1.0.view", @"/Views/Product/StoragerIndex.cshtml")]
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
#line 1 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/_ViewImports.cshtml"
using CQRSProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/_ViewImports.cshtml"
using CQRSProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eecb65335822fce9c8b3ddb9b324891e47bc230", @"/Views/Product/StoragerIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f9092b82b6618ba13e3b7436dd7633f8ad01c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_StoragerIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetProductStoragerQueryResult>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/StoragerIndex.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6eecb65335822fce9c8b3ddb9b324891e47bc2304033", async() => {
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
            WriteLiteral(@"
<div class=""container"">
    <h2>Storager Page</h2>
    <br />
    <table class=""table table-bordered"">
        <tr>
            <th>#</th>
            <th>Product Name</th>
            <th>Warehouse</th>

            <th>Details</th>
            <th>Delete</th>
            <th>Edit</th>

        </tr>
");
#nullable restore
#line 21 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/StoragerIndex.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 24 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/StoragerIndex.cshtml"
               Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/StoragerIndex.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/StoragerIndex.cshtml"
               Write(item.Storage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 650, "\"", 657, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Details</a></td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 727, "\"", 734, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 805, "\"", 812, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Edit</a></td>\n\n\n            </tr>\n");
#nullable restore
#line 34 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/StoragerIndex.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </table>\n    <a");
            BeginWriteAttribute("href", " href=\"", 911, "\"", 918, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">New</a>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetProductStoragerQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591