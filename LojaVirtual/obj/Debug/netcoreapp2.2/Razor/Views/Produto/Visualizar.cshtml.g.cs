#pragma checksum "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e556425e99a3587021068ab64727262dfbb9c15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
#line 2 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 3 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 4 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e556425e99a3587021068ab64727262dfbb9c15", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8547e261402b874743aa1285ad7ccbae7f5b9b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.ProdutoAgregador.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 416, true);
            WriteLiteral(@"
<br style=""clear:both"" />
<div class=""container"">
    <section id=""product_detail"">

        <div id=""code_prod_detail"">
            <div class=""card"">
                <div class=""row no-gutters"">
                    <aside class=""col-sm-5 border-right"">
                        <article class=""gallery-wrap"">
                            <div class=""img-big-wrap"">
                                <div>
");
            EndContext();
#line 14 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                     if (Model.Imagens != null && Model.Imagens.Count > 0)
                                    {


#line default
#line hidden
            BeginContext(601, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 643, "\"", 685, 1);
#line 17 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 650, Model.Imagens.ElementAt(0).Caminho, 650, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(686, 19, true);
            WriteLiteral(" data-fancybox><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 705, "\"", 746, 1);
#line 17 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 711, Model.Imagens.ElementAt(0).Caminho, 711, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(747, 7, true);
            WriteLiteral("></a>\r\n");
            EndContext();
#line 18 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(874, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 916, "\"", 958, 1);
#line 21 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 923, Model.Imagens.ElementAt(0).Caminho, 923, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(959, 19, true);
            WriteLiteral(" data-fancybox><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 978, "\"", 1019, 1);
#line 21 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 984, Model.Imagens.ElementAt(0).Caminho, 984, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1020, 7, true);
            WriteLiteral("></a>\r\n");
            EndContext();
#line 22 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1066, 161, true);
            WriteLiteral("                                </div>\r\n                            </div> <!-- slider-product.// -->\r\n                            <div class=\"img-small-wrap\">\r\n");
            EndContext();
#line 26 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                 if (Model.Imagens != null && Model.Imagens.Count > 0)
                                {
                                    foreach (Imagem imagem in Model.Imagens)
                                    {

#line default
#line hidden
            BeginContext(1467, 71, true);
            WriteLiteral("                                        <div class=\"item-gallery\"> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1538, "\"", 1559, 1);
#line 30 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 1544, imagem.Caminho, 1544, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1560, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 31 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"

                                    }
                                }

#line default
#line hidden
            BeginContext(1645, 686, true);
            WriteLiteral(@"                                <div class=""item-gallery""> <img src=""images/items/1.jpg""></div>
                                <div class=""item-gallery""> <img src=""images/items/2.jpg""></div>
                                <div class=""item-gallery""> <img src=""images/items/3.jpg""></div>
                                <div class=""item-gallery""> <img src=""images/items/4.jpg""></div>
                            </div> <!-- slider-nav.// -->
                        </article> <!-- gallery-wrap .end// -->
                    </aside>
                    <aside class=""col-sm-7"">
                        <article class=""p-5"">
                            <h3 class=""title mb-3"">");
            EndContext();
            BeginContext(2332, 10, false);
#line 43 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                              Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2342, 180, true);
            WriteLiteral("</h3>\r\n\r\n                            <div class=\"mb-3\">\r\n                                <var class=\"price h3 text-warning\">\r\n                                    <span class=\"num\">");
            EndContext();
            BeginContext(2523, 25, false);
#line 47 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                 Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 373, true);
            WriteLiteral(@"</span>
                                </var>
                                <span>/unid</span>
                            </div> <!-- price-detail-wrap .// -->
                            <dl>
                                <dt>Descrição</dt>
                                <dd>
                                    <p>
                                        ");
            EndContext();
            BeginContext(2922, 15, false);
#line 55 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                   Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2937, 281, true);
            WriteLiteral(@"
                                    </p>
                                </dd>
                            </dl>
                            <dl class=""row"">
                                <dt class=""col-sm-3"">Peso</dt>
                                <dd class=""col-sm-9"">");
            EndContext();
            BeginContext(3219, 10, false);
#line 61 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(3229, 129, true);
            WriteLiteral("</dd>\r\n\r\n                                <dt class=\"col-sm-3\">Largura</dt>\r\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3359, 13, false);
#line 64 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Largura);

#line default
#line hidden
            EndContext();
            BeginContext(3372, 128, true);
            WriteLiteral("</dd>\r\n\r\n                                <dt class=\"col-sm-3\">Altura</dt>\r\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3501, 12, false);
#line 67 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Altura);

#line default
#line hidden
            EndContext();
            BeginContext(3513, 131, true);
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Comprimento</dt>\r\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3645, 17, false);
#line 69 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Comprimento);

#line default
#line hidden
            EndContext();
            BeginContext(3662, 141, true);
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Quantidade em estoque</dt>\r\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3804, 16, false);
#line 71 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(3820, 121, true);
            WriteLiteral("</dd>\r\n                            </dl>\r\n                                                 \r\n                            ");
            EndContext();
            BeginContext(3941, 182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e556425e99a3587021068ab64727262dfbb9c1515133", async() => {
                BeginContext(4061, 58, true);
                WriteLiteral(" <i class=\"fas fa-shopping-cart\"></i>Adicionar ao carrinho");
                EndContext();
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
#line 74 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                                                            WriteLiteral(Model.Id);

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
            BeginContext(4123, 243, true);
            WriteLiteral("\r\n                        </article> <!-- card-body.// -->\r\n                    </aside> <!-- col.// -->\r\n                </div> <!-- row.// -->\r\n            </div> <!-- card.// -->\r\n        </div> <!-- code-wrap.// -->\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.ProdutoAgregador.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
