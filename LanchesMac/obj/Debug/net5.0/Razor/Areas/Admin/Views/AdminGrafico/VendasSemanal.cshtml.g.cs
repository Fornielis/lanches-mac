#pragma checksum "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminGrafico\VendasSemanal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d4ac937ffb8fdab1cf537569d963f0e222222a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminGrafico_VendasSemanal), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminGrafico/VendasSemanal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d4ac937ffb8fdab1cf537569d963f0e222222a1", @"/Areas/Admin/Views/AdminGrafico/VendasSemanal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798c89ae1590f3f97cffe7393fc1f92d2ad95e33", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminGrafico_VendasSemanal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<title>\r\n    ");
#nullable restore
#line 2 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminGrafico\VendasSemanal.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - Grafico de Vendas
</title>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<div id=""chart_div"" style=""width: 900px; height: 500px;""></div>

<script type=""text/javascript"">
    google.charts.load('current', { packages: ['corechart', 'bar'] });
    google.charts.setOnLoadCallback(CarregaDados);

    function CarregaDados() {
        $.ajax({
            url: '");
#nullable restore
#line 15 "C:\Users\Fornielis\Desktop\JOBS\_DEVELOPER\LanchesMac\LanchesMac\Areas\Admin\Views\AdminGrafico\VendasSemanal.cshtml"
             Write(Url.Action("VendasLanches", "AdminGrafico"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {dias: 7},
            dataType: ""json"",
            type: ""GET"",
            error: function(xhr, status, error) {
                var err = eval(""("" + xhr.responseText + "")"");
                toastr.error(err.message);
            },
            success: function(data) {
                GraficoVendasLanches(data);
                return false;
            }
        });
        return false;
    }
    //preparar os dados obtidos
    function GraficoVendasLanches(data) {
        var dataArray = [
            ['Lanche', 'Quantidade', 'Valores(R$)']
        ];

        $.each(data, function (i, item) {
            dataArray.push([item.lancheNome, item.lanchesQuantidade, item.lanchesValorTotal]);
        });

        var data = google.visualization.arrayToDataTable(dataArray);

        var options = {
            title: 'Lanches - Vendas : últimos 7 dias',

            curveType: 'function',
            legend: { position : 'bottom'},

            chartArea: ");
            WriteLiteral(@"{
                width: '70%'
            },
            colors: ['#5202b5', '#d2a828'],
            hAxis: {
                title: 'Lanches',
                minValue: 0
            },
            vAxis: {
                title: 'Valor Total (em Reais)'
            }
        };
        var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
        chart.draw(data, options);
    }

</script>");
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
