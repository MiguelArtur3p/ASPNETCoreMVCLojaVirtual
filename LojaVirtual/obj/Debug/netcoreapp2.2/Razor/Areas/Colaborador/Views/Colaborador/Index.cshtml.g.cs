#pragma checksum "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa0960b8e4143b1ffdc193e0f5715d46d0fb433e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Colaborador_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Colaborador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Colaborador/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Colaborador_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0960b8e4143b1ffdc193e0f5715d46d0fb433e", @"/Areas/Colaborador/Views/Colaborador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ac8f81f3eb01f3adb16d2bf1ac5ebe52f89e41", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Colaborador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<LojaVirtual.Models.Colaborador>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GerarSenha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 30, true);
            WriteLiteral("\r\n\r\n\r\n<h1>Colaborador</h1>\r\n\r\n");
            EndContext();
            BeginContext(93, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa0960b8e4143b1ffdc193e0f5715d46d0fb433e6623", async() => {
                BeginContext(143, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(156, 16, true);
            WriteLiteral("\r\n<br/>\r\n<br/>\r\n");
            EndContext();
#line 10 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(208, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(244, 17, false);
#line 12 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(261, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
}

#line default
#line hidden
            BeginContext(270, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(300, 161, true);
            WriteLiteral("    <div class=\"table-responsive\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(462, 46, false);
#line 22 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Id));

#line default
#line hidden
            EndContext();
            BeginContext(508, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(552, 48, false);
#line 23 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Nome));

#line default
#line hidden
            EndContext();
            BeginContext(600, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(644, 49, false);
#line 24 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Email));

#line default
#line hidden
            EndContext();
            BeginContext(693, 121, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 29 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                 foreach (Colaborador colaborador in Model)
                {

#line default
#line hidden
            BeginContext(894, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(961, 14, false);
#line 32 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                                   Write(colaborador.Id);

#line default
#line hidden
            EndContext();
            BeginContext(975, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1011, 16, false);
#line 33 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                       Write(colaborador.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1063, 17, false);
#line 34 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                       Write(colaborador.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1145, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa0960b8e4143b1ffdc193e0f5715d46d0fb433e12713", async() => {
                BeginContext(1229, 10, true);
                WriteLiteral("GerarSenha");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                                                         WriteLiteral(colaborador.Id);

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
            BeginContext(1243, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1273, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa0960b8e4143b1ffdc193e0f5715d46d0fb433e15218", async() => {
                BeginContext(1356, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                                                        WriteLiteral(colaborador.Id);

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
            BeginContext(1369, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1399, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa0960b8e4143b1ffdc193e0f5715d46d0fb433e17720", async() => {
                BeginContext(1477, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                                                      WriteLiteral(colaborador.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1488, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 41 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1567, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1626, 85, false);
#line 46 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina })));

#line default
#line hidden
            EndContext();
#line 46 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
                                                                                          
}
else
{
    

#line default
#line hidden
            BeginContext(1731, 45, true);
            WriteLiteral("    <span>Nenhum Registro Cadastrado</span>\r\n");
            EndContext();
#line 52 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Areas\Colaborador\Views\Colaborador\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1779, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<LojaVirtual.Models.Colaborador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
