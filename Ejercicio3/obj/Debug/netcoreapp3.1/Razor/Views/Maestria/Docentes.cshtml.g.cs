#pragma checksum "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d05a6a8400872345eba2c25ef16d009272fd8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maestria_Docentes), @"mvc.1.0.view", @"/Views/Maestria/Docentes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d05a6a8400872345eba2c25ef16d009272fd8f", @"/Views/Maestria/Docentes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8d239d5245ce441ef9054c28f2f313eb2c47a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Maestria_Docentes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maestria>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Maestria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarDocente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h2 class=\"display-4\">Docentes de ");
#nullable restore
#line 3 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
                             Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 5 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
 if (Model.Docentes.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-columns\">\r\n");
#nullable restore
#line 8 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
         foreach (var item in Model.Docentes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5>");
#nullable restore
#line 12 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
                   Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>");
#nullable restore
#line 13 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
                   Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 411, "\"", 471, 5);
            WriteAttributeValue("", 421, "deleteTeacher(", 421, 14, true);
#nullable restore
#line 14 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
WriteAttributeValue("", 435, Model.IdMaestria, 435, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 452, ",", 452, 1, true);
#nullable restore
#line 14 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
WriteAttributeValue(" ", 453, item.IdEmpleado, 454, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 470, ")", 470, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"btnBorrar\">Eliminar</button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 17 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <script>
        // onClick event falta*
        function deleteTeacher(idMaestria, idDocente) {
            $.ajax({
                type: 'POST',
                url: '/Maestria/EliminarDocente/',
                data: { idMaestria, idDocente },
                success: function () {
                    location.reload();
                },
                error: function (data) {
                    console.log(data);
                }
            });
        }
        
    </script>
");
#nullable restore
#line 36 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"alert alert-info\">Esta maestría no está siendo impartida por ningún docente.</h3>\r\n");
#nullable restore
#line 40 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"

}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2d05a6a8400872345eba2c25ef16d009272fd8f7981", async() => {
                WriteLiteral("Agregar Docente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio3\Ejercicio3\Views\Maestria\Docentes.cshtml"
                                                                                   WriteLiteral(Model.IdMaestria);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maestria> Html { get; private set; }
    }
}
#pragma warning restore 1591
