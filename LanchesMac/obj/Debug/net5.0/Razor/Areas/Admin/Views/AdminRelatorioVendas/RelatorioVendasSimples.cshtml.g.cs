#pragma checksum "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7991c14d5a063f9bc7e0d5d97ab4757980a5d254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRelatorioVendas_RelatorioVendasSimples), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRelatorioVendas/RelatorioVendasSimples.cshtml")]
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
#line 1 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7991c14d5a063f9bc7e0d5d97ab4757980a5d254", @"/Areas/Admin/Views/AdminRelatorioVendas/RelatorioVendasSimples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798c89ae1590f3f97cffe7393fc1f92d2ad95e33", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRelatorioVendas_RelatorioVendasSimples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LanchesMac.Models.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
  
    ViewData["Title"] = "Pedidos Por Período";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-dark\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7991c14d5a063f9bc7e0d5d97ab4757980a5d2545547", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Inicial</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                BeginWriteAttribute("value", " value=", 557, "", 584, 1);
#nullable restore
#line 16 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
WriteAttributeValue("", 564, ViewData["minDate"], 564, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data Final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                BeginWriteAttribute("value", " value=", 790, "", 817, 1);
#nullable restore
#line 20 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
WriteAttributeValue("", 797, ViewData["maxDate"], 797, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-success\">Filtrar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total de Pedidos = ");
#nullable restore
#line 29 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3 class=\"panel-title\">Total de Lanches nos Pedidos = ");
#nullable restore
#line 30 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                                                          Write(Model.Sum(obj => obj.TotalItensPedido).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3 class=\"panel-title\">Valor Total dos Pedidos = ");
#nullable restore
#line 31 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                                                     Write(Model.Sum(obj => obj.PedidoTotal).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.PedidoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 41 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 44 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 47 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 50 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.PedidoTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 53 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalItensPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 56 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.PedidoEntregueEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 61 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PedidoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 68 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 77 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PedidoTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 80 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalItensPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 83 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PedidoEntregueEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 86 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LanchesMac.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
