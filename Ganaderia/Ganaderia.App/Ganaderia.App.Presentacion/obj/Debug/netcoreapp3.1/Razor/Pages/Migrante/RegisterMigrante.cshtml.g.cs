#pragma checksum "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9241fbbc587974bccf83a67b0704fec56efdd66e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ganaderia.App.Presentacion.Pages.Migrante.Pages_Migrante_RegisterMigrante), @"mvc.1.0.razor-page", @"/Pages/Migrante/RegisterMigrante.cshtml")]
namespace Ganaderia.App.Presentacion.Pages.Migrante
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
#line 1 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\_ViewImports.cshtml"
using Ganaderia.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9241fbbc587974bccf83a67b0704fec56efdd66e", @"/Pages/Migrante/RegisterMigrante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4201666bad1ceba32232fbe6048e6704ce771fc2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrante_RegisterMigrante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("guardar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
  
    Layout = "~/Pages/Shared/_layoutLogin.cshtml";
    ViewData["Title"] = "Entidad";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9241fbbc587974bccf83a67b0704fec56efdd66e5335", async() => {
                WriteLiteral(@"
    <p>Nombres <input type=""text"" name=""nombres"" required> </p>
    <p>Apellidos <input type=""text"" name=""apellidos"" required> </p>
    <p>Tipo de documento <input type=""text"" name=""tdocumento"" required> </p>
    <p>Numero de documento <input type=""text"" name=""documento"" required> </p>
    <p>Pais de origen <input type=""text"" name=""pais"" required> </p>
    <p>Fecha de nacimiento <input type=""date"" name=""nacimiento"" required> </p>
    <p>Email <input type=""email"" name=""text""> </p>
    <p>Telefono <input type=""text"" name=""telefono""> </p>
    <p>Dirección actual <input type=""text"" name=""direccion""> </p>
    <p>Ciudad <input type=""text"" name=""ciudad""> </p>
    <p>Situacion laboral <input type=""text"" name=""slaboral""> </p>
    <p>Usuario <input type=""text"" name=""usuario"" required> </p>
    <p>Contrasena <input type=""password"" name=""clave"" required> </p>
    <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9241fbbc587974bccf83a67b0704fec56efdd66e6524", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h1>Listado de migrantes</h1>

<div class=""table-responsive"">
    

<table class=""table"" style=""na"">
  <tr class=""table-success"">
    <th>Nombres</th>
    <th>Apellidos</th>
    <th>Tipo de documento</th>
    <th>No. Documento</th>
    <th>Pais de origen</th>
    <th>Fecha de nacimiento</th>
    <th>Correo electrónico</th>
    <th>Telefono</th>
    <th>Direccion actual</th>
    <th>Ciudad actual</th>
    <th>Situacion laboral</th>
    <th>Usuario</th>
  </tr>
");
#nullable restore
#line 43 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
   foreach (var migrante in Model.migrantes)
  {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <td>");
#nullable restore
#line 47 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 48 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 49 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Tipo_documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 50 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.No_Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 51 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Pais_origen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 52 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Fecha_nacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 53 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 54 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 55 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Direccion_actual);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 56 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 57 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Situacion_laboral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 58 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
     Write(migrante.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      \r\n\r\n    </tr>\r\n");
#nullable restore
#line 62 "C:\Users\Sebastian\Documents\proyecto-g1-DS-master\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Migrante\RegisterMigrante.cshtml"
    
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ganaderia.App.Presentacion.Pages.RegisterMigranteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Presentacion.Pages.RegisterMigranteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Presentacion.Pages.RegisterMigranteModel>)PageContext?.ViewData;
        public Ganaderia.App.Presentacion.Pages.RegisterMigranteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
