#pragma checksum "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54dd0e9fed04c9fbac291665e84d484638dc3051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54dd0e9fed04c9fbac291665e84d484638dc3051", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f9092b82b6618ba13e3b7436dd7633f8ad01c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetProductAccounterQueryResult>>
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
#line 2 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54dd0e9fed04c9fbac291665e84d484638dc30513986", async() => {
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
    <h2>Accounter Page</h2>
    <br />
    <table class=""table table-bordered"">
        <tr>
            <th>#</th>
            <th>Product Name</th>
            <th>Brand</th>
            <th>Stock</th>
            <th>Details HR</th>
            <th>Details Accounting</th>
            <th>Delete</th>
            <th>Edit</th>

        </tr>
");
#nullable restore
#line 22 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 25 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"
               Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"
               Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"
               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 751, "\"", 805, 2);
            WriteAttributeValue("", 758, "/Product/GetHumanResourcesIndex/", 758, 32, true);
#nullable restore
#line 29 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"
WriteAttributeValue("", 790, item.ProductID, 790, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Details</a></td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 875, "\"", 928, 2);
            WriteAttributeValue("", 882, "/Product/GetAccounterIndexByID/", 882, 31, true);
#nullable restore
#line 30 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"
WriteAttributeValue("", 913, item.ProductID, 913, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Accounting</a></td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1001, "\"", 1008, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1079, "\"", 1086, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Edit</a></td>\n            </tr>\n");
#nullable restore
#line 34 "/Users/ilaydasozyilmaz/Projects/CQRSProject/CQRSProject/Views/Product/Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </table>\n    <br />\n    <a");
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1201, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">New</a>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetProductAccounterQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591
