#pragma checksum "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411f9c84b6b54b1a87a985866ffb876dc7785945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Cliente_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Cliente/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Cliente_Index))]
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
#line 2 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 3 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 4 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 6 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 7 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 8 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411f9c84b6b54b1a87a985866ffb876dc7785945", @"/Areas/Colaborador/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ac8f81f3eb01f3adb16d2bf1ac5ebe52f89e41", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<LojaVirtual.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtivarDesativar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
   
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
            BeginContext(156, 38, true);
            WriteLiteral("\r\n\r\n<h1>Cliente</h1>\r\n<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(194, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411f9c84b6b54b1a87a985866ffb876dc77859456164", async() => {
                BeginContext(213, 122, true);
                WriteLiteral("\r\n    <div class=\"mb-3\">\r\n        <label for=\"Nome\">Nome</label>\r\n        <input type=\"text\" name=\"pesquisa\" id=\"pesquisa\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 335, "\"", 353, 1);
#line 14 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 344, pesquisa, 344, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(354, 158, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Digite o nome ou e-mail do cliente\">   \r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Pesquisar</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(519, 18, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
            EndContext();
#line 20 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(573, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(609, 17, false);
#line 22 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(626, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 23 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
}

#line default
#line hidden
            BeginContext(635, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 26 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(665, 161, true);
            WriteLiteral("    <div class=\"table-responsive\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(827, 46, false);
#line 32 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Id));

#line default
#line hidden
            EndContext();
            BeginContext(873, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(917, 48, false);
#line 33 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Nome));

#line default
#line hidden
            EndContext();
            BeginContext(965, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1009, 49, false);
#line 34 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Email));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 121, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 39 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                 foreach (Cliente cliente in Model)
                {

#line default
#line hidden
            BeginContext(1251, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1318, 10, false);
#line 42 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                                   Write(cliente.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1364, 12, false);
#line 43 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                       Write(cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1376, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1412, 13, false);
#line 44 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                       Write(cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1425, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 46 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                             if (cliente.Situacao == "A")
                            {

#line default
#line hidden
            BeginContext(1552, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1584, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411f9c84b6b54b1a87a985866ffb876dc778594513483", async() => {
                BeginContext(1666, 9, true);
                WriteLiteral("Desativar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                                                                  WriteLiteral(cliente.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1679, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1777, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1809, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411f9c84b6b54b1a87a985866ffb876dc778594516340", async() => {
                BeginContext(1894, 6, true);
                WriteLiteral("Ativar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                                                                  WriteLiteral(cliente.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1904, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1937, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 57 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2016, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2075, 111, false);
#line 62 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina =pagina,pesquisa=pesquisa })));

#line default
#line hidden
            EndContext();
#line 62 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                                                                                                                    
}
else
{


#line default
#line hidden
            BeginContext(2202, 45, true);
            WriteLiteral("    <span>Nenhum Registro Cadastrado</span>\r\n");
            EndContext();
#line 68 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2250, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<LojaVirtual.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
