#pragma checksum "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e8db090fcb3b4952a6a31923535db109521cda6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e8db090fcb3b4952a6a31923535db109521cda6", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8547e261402b874743aa1285ad7ccbae7f5b9b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
   
        var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
            BeginContext(91, 543, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark fixed-top bg-dark"">
    <a class=""navbar-brand"" href=""/""> LojaVirtual</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">



        <ul class=""navbar-nav mr-auto"">
            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 634, "\"", 791, 2);
            WriteAttributeValue("", 642, "nav-item", 642, 8, true);
#line 17 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 650, (ViewContext.RouteData.Values["controller"].ToString()=="Home" && ViewContext.RouteData.Values["action"].ToString()=="Index")?"active":"", 651, 140, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(792, 144, true);
            WriteLiteral(">\r\n                <a class=\"nav-link\" href=\"/\"><i class=\"fas fa-home\"></i> Home <span class=\"sr-only\">(current)</span></a>\r\n            </li>\r\n");
            EndContext();
#line 20 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
              
                var TodasCategorias = Model.ToList();
            

#line default
#line hidden
#line 23 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
             if (TodasCategorias != null && TodasCategorias.Count > 0)
            {

#line default
#line hidden
            BeginContext(1109, 62, true);
            WriteLiteral("                <div class=\"dropdown\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1171, "\"", 1348, 3);
            WriteAttributeValue("", 1179, "nav-link", 1179, 8, true);
#line 26 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 1187, (ViewContext.RouteData.Values["controller"].ToString()=="Home" && ViewContext.RouteData.Values["action"].ToString()=="Categoria")?"active":"", 1188, 144, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1332, "dropdown-toggle", 1333, 16, true);
            EndWriteAttribute();
            BeginContext(1349, 356, true);
            WriteLiteral(@" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown""
                       aria-haspopup=""true"" aria-expanded=""false"">
                      
                        <i class=""fas fa-list-ul""></i> Categorias
                    </a>
                    <ul class=""dropdown-menu multi-level"" role=""menu"" aria-labelledby=""dropdownMenu"">
");
            EndContext();
#line 32 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                          
                            var CategoriasPrincipais = TodasCategorias.Where(a => a.CategoriaPaiId == null).ToList();
                            ViewData["TodasCategorias"] = TodasCategorias;
                        

#line default
#line hidden
#line 36 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                         foreach (var categoria in CategoriasPrincipais)
                        {
                            

#line default
#line hidden
            BeginContext(2085, 141, false);
#line 38 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                       Write(await Html.PartialAsync("~/Views/Shared/Components/Menu/_Submenu.cshtml", new ViewDataDictionary(ViewData) { { "CategoriaPai", categoria } }));

#line default
#line hidden
            EndContext();
#line 38 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                                                                                          

                        }

#line default
#line hidden
            BeginContext(2257, 51, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n");
            EndContext();
#line 43 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(2323, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2338, "\"", 2497, 2);
            WriteAttributeValue("", 2346, "nav-item", 2346, 8, true);
#line 44 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 2354, (ViewContext.RouteData.Values["controller"].ToString()=="Home" && ViewContext.RouteData.Values["action"].ToString()=="Contato")?"active":"", 2355, 142, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2498, 152, true);
            WriteLiteral(">\r\n                <a class=\"nav-link\" href=\"/Home/Contato\"><i class=\"far fa-address-book\"></i> Contato </a>\r\n            </li>\r\n        </ul>\r\n        ");
            EndContext();
            BeginContext(2650, 557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e8db090fcb3b4952a6a31923535db109521cda612572", async() => {
                BeginContext(2702, 79, true);
                WriteLiteral("\r\n            <input class=\"form-control mr-sm-2\" type=\"search\" name=\"pesquisa\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2781, "\"", 2798, 1);
#line 49 "C:\Developer\Programas em C#\Projetos\LojaVirtualMVC\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 2789, pesquisa, 2789, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2799, 155, true);
                WriteLiteral(" placeholder=\"palavra\" aria-label=\"Search\">\r\n            <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Pesquisa</button>\r\n            ");
                EndContext();
                BeginContext(2954, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e8db090fcb3b4952a6a31923535db109521cda613651", async() => {
                    BeginContext(3015, 37, true);
                    WriteLiteral("<i class=\"fas fa-user-alt\"></i> Login");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                BeginContext(3056, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3070, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e8db090fcb3b4952a6a31923535db109521cda615461", async() => {
                    BeginContext(3141, 45, true);
                    WriteLiteral("<i class=\"fas fa-shopping-cart\"></i> Carrinho");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3190, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3207, 22, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
