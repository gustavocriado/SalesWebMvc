#pragma checksum "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "590f61783223d15190328f6e5389efb602c18fdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Details), @"mvc.1.0.view", @"/Views/Sellers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Details.cshtml", typeof(AspNetCore.Views_Sellers_Details))]
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
#line 1 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"590f61783223d15190328f6e5389efb602c18fdb", @"/Views/Sellers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalesWebMvc.Models.Seller>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(86, 17, false);
#line 7 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(103, 107, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>Seller</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(211, 40, false);
#line 14 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(251, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(296, 36, false);
#line 17 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(332, 44, true);
            WriteLiteral(";\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(377, 41, false);
#line 20 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(418, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(463, 37, false);
#line 23 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(500, 44, true);
            WriteLiteral(";\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(545, 40, false);
#line 26 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(585, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(630, 36, false);
#line 29 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(666, 44, true);
            WriteLiteral(";\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(711, 46, false);
#line 32 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(757, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(802, 42, false);
#line 35 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(844, 44, true);
            WriteLiteral(";\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(889, 46, false);
#line 38 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(935, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(980, 47, false);
#line 41 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 48, true);
            WriteLiteral(";\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1075, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "913208bf29d043e9a16f6ed6a26f6973", async() => {
                BeginContext(1141, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\gcriado\Documents\Bureau Veritas\Projetos\SalesWebMvc\Views\Sellers\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1149, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1155, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "405f900878264794978839f1ae12a10f", async() => {
                BeginContext(1177, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1193, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalesWebMvc.Models.Seller> Html { get; private set; }
    }
}
#pragma warning restore 1591
