#pragma checksum "D:\TesteStand\Views\Cliente\CadastraCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a468cddee488754fe96be404a72576a865223e89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_CadastraCliente), @"mvc.1.0.view", @"/Views/Cliente/CadastraCliente.cshtml")]
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
#line 1 "D:\TesteStand\Views\_ViewImports.cshtml"
using TesteStand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TesteStand\Views\_ViewImports.cshtml"
using TesteStand.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a468cddee488754fe96be404a72576a865223e89", @"/Views/Cliente/CadastraCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5965eeebbe7686f12cee88ee9a53170f39eb695", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_CadastraCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteStand.Models.ClienteModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\TesteStand\Views\Cliente\CadastraCliente.cshtml"
  
    ViewData["Title"] = "CadastraCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>CadastraCliente</h1>

<h4>ClienteModel</h4>
<hr />
<div class=""col-sm-12"">
    <fieldset class=""scheduler-border"">
        <legend class=""scheduler-border""><span>Empresa</span></legend>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-md-5"">
                    <label class=""control-label input-label"" for=""search-razao-social"">Razão Social:</label>
                    ");
#nullable restore
#line 18 "D:\TesteStand\Views\Cliente\CadastraCliente.cshtml"
               Write(Html.TextBox("SearchString", "", new { @id = "search-razao-social", @class = "form-control input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"col-md-3\">\r\n                    <label class=\"control-label input-label\" for=\"search-cnpj\">CNPJ:</label>\r\n                    ");
#nullable restore
#line 23 "D:\TesteStand\Views\Cliente\CadastraCliente.cshtml"
               Write(Html.TextBox("SearchString", "", new { @id = "search-cnpj", @class = "form-control input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"col-md-3\">\r\n                    <label class=\"control-label input-label\" for=\"search-cnpj\">Data de Fundação:</label>\r\n                    ");
#nullable restore
#line 28 "D:\TesteStand\Views\Cliente\CadastraCliente.cshtml"
               Write(Html.TextBox("SearchString", "", new { @id = "search-cnpj", @class = "form-control input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div id=""datepicker"" class=""input-group date"" data-date-format=""mm-dd-yyyy"">
                <input class=""form-control"" type=""text"" readonly />
                <span class=""input-group-addon""><i class=""glyphicon glyphicon-calendar""></i></span>
            </div>
        </div>
    </fieldset>

    <div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a468cddee488754fe96be404a72576a865223e895641", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <style>
        #datepicker {
            width: 180px;
            margin: 0 20px 20px 20px;
        }

            #datepicker > span:hover {
                cursor: pointer;
            }
    </style>

    <script>
        $(function () {
            $(""#datepicker"").datepicker({
                autoclose: true,
                todayHighlight: true
            }).datepicker('update', new Date());
        });

    </script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 64 "D:\TesteStand\Views\Cliente\CadastraCliente.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteStand.Models.ClienteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
