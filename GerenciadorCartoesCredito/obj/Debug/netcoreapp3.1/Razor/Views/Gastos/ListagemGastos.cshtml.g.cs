#pragma checksum "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "214f93b785f959edef9d454fc3f92b06bbdd0337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gastos_ListagemGastos), @"mvc.1.0.view", @"/Views/Gastos/ListagemGastos.cshtml")]
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
#line 1 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\_ViewImports.cshtml"
using GerenciadorCartoesCredito;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\_ViewImports.cshtml"
using GerenciadorCartoesCredito.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"214f93b785f959edef9d454fc3f92b06bbdd0337", @"/Views/Gastos/ListagemGastos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf1f6929469dc9fffe5ead78e98a007b2bd5078c", @"/Views/_ViewImports.cshtml")]
    public class Views_Gastos_ListagemGastos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GerenciadorCartoesCredito.Models.GastosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoGasto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarGasto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirGasto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
  
    ViewData["Title"] = "Gastos do cartão " + Model.NumeroCartao;
    string classes = "c100 big orange p" + Model.PorcentagemGasta;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-secondary\">\r\n    Cartão número ");
#nullable restore
#line 9 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
             Write(Model.NumeroCartao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-center\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 372, "\"", 388, 1);
#nullable restore
#line 14 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
WriteAttributeValue("", 380, classes, 380, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span>");
#nullable restore
#line 15 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
             Write(Model.PorcentagemGasta);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n            <div class=\"slice\">\r\n                <div class=\"bar\"></div>\r\n                <div class=\"fill\"></div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "214f93b785f959edef9d454fc3f92b06bbdd03377055", async() => {
                WriteLiteral("Novo Gasto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cartaoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
                                      WriteLiteral(Model.CartaoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartaoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cartaoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartaoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table table-hover table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th>
                Descrição
            </th>
            <th>
                Valor do gasto
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 42 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
         foreach (var item in Model.ListaGastos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
               Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    R$ ");
#nullable restore
#line 49 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
                  Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "214f93b785f959edef9d454fc3f92b06bbdd033710769", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gastoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
                                                          WriteLiteral(item.GastoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gastoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gastoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gastoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "214f93b785f959edef9d454fc3f92b06bbdd033713127", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">Excluir</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gastoId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
                                                           WriteLiteral(item.GastoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["gastoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gastoId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["gastoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 11, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1526, "confirm(\'Prosseguir", 1526, 19, true);
            AddHtmlAttributeValue(" ", 1545, "com", 1546, 4, true);
            AddHtmlAttributeValue(" ", 1549, "a", 1550, 2, true);
            AddHtmlAttributeValue(" ", 1551, "exclusão", 1552, 9, true);
            AddHtmlAttributeValue(" ", 1560, "do", 1561, 3, true);
            AddHtmlAttributeValue(" ", 1563, "gasto", 1564, 6, true);
            AddHtmlAttributeValue(" ", 1569, "no", 1570, 3, true);
            AddHtmlAttributeValue(" ", 1572, "valor", 1573, 6, true);
            AddHtmlAttributeValue(" ", 1578, "de", 1579, 3, true);
#nullable restore
#line 53 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
AddHtmlAttributeValue(" ", 1581, item.Valor, 1582, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1593, "?\')", 1594, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\lucas\Desktop\GerenciadorCartoesCredito\GerenciadorCartoesCredito\GerenciadorCartoesCredito\Views\Gastos\ListagemGastos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GerenciadorCartoesCredito.Models.GastosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
