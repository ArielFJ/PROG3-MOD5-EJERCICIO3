#pragma checksum "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab28b8f7a8561bdaa652846d8e577dffa2fb9b15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Universidad_AgregarDocente), @"mvc.1.0.view", @"/Views/Universidad/AgregarDocente.cshtml")]
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
#line 1 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\_ViewImports.cshtml"
using Ejercicio3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\_ViewImports.cshtml"
using Ejercicio3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab28b8f7a8561bdaa652846d8e577dffa2fb9b15", @"/Views/Universidad/AgregarDocente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8d239d5245ce441ef9054c28f2f313eb2c47a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Universidad_AgregarDocente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Universidad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Universidad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarDocente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Docente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Docentes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
  
    ViewData["Title"] = "Añadir Docente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
 if (UniversidadManager.Instance.Docentes.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"display-4 text-center\">Escoja el docente que trabajará en ");
#nullable restore
#line 8 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                                    Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
     if((bool)ViewBag.hasError)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">");
#nullable restore
#line 11 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                    Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center row\">\r\n            <div class=\"form-group\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"card-columns\">\r\n");
#nullable restore
#line 18 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                         foreach (var item in UniversidadManager.Instance.Docentes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab28b8f7a8561bdaa652846d8e577dffa2fb9b158435", async() => {
                WriteLiteral("\r\n                                    <div class=\"card-title\">\r\n                                        <button class=\"btn btn-link ml-lg-4\" type=\"submit\">");
#nullable restore
#line 26 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                                                      Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button><br />\r\n                                    </div>\r\n                                    <div class=\"card-body\">\r\n                                        <p>Teléfono: ");
#nullable restore
#line 29 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                Write(item.Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                         if (item.Universidades.Count > 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <p><b>Universidades:</b></p> <p>\r\n");
#nullable restore
#line 33 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                 for (int i = 0; i < item.Universidades.Count; i++)
                                                {
                                                    if (i >= 3)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <span>entre otras...</span>\r\n");
#nullable restore
#line 38 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                        break;
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <span>");
#nullable restore
#line 40 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                     Write(item.Universidades[i].Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral(",</span>\r\n");
#nullable restore
#line 41 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </p>\r\n");
#nullable restore
#line 43 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idUniversidad", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                   WriteLiteral(Model.IdUniversidad);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUniversidad"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idUniversidad", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUniversidad"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                WriteLiteral(item.IdEmpleado);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idDocente"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDocente", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idDocente"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 47 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                        }   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 52 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"alert alert-info\">Aún no se ha añadido ningun docente.</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab28b8f7a8561bdaa652846d8e577dffa2fb9b1516315", async() => {
                WriteLiteral("Agregar Docente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab28b8f7a8561bdaa652846d8e577dffa2fb9b1517971", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Universidad\AgregarDocente.cshtml"
                                                                                WriteLiteral(Model.IdUniversidad);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Universidad> Html { get; private set; }
    }
}
#pragma warning restore 1591
