#pragma checksum "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d63410133c7275ae994e4051bf3b54187523ec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GymEnCasa.App.Presentacion.Pages.Usuarios.Pages_Usuarios_ConsultaU), @"mvc.1.0.razor-page", @"/Pages/Usuarios/ConsultaU.cshtml")]
namespace GymEnCasa.App.Presentacion.Pages.Usuarios
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
#line 1 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\_ViewImports.cshtml"
using GymEnCasa.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d63410133c7275ae994e4051bf3b54187523ec5", @"/Pages/Usuarios/ConsultaU.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86bf3f15c00edba4b629826e30229dcd5bfb7ed7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Usuarios_ConsultaU : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
  
 ViewData["Title"] = "Nuevo Usuario";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-info"" style=""text-align:center;"">Lista Usuarios </h2>
<div class=""border"">
    <table class=""table"">
        <tr>
            <td>Correo </td>
            <td>Contraseña</td>
            <td>Nombre</td>
            <td>Apellidos</td>
            <td>Teléfono</td>
            <td>Género</td>
            <td>Dirección</td>
            <td>ObjetivoPersonal</td>
        </tr>
");
#nullable restore
#line 20 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
         foreach (var U in Model.listaUsuario)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Contrasena);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.ObjetivoPersonal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Stefanny\Downloads\ProyectoInnovasoft\ProyectGymApp\proyectinnovasoft\GymEnCasa.App.Presentacion\Pages\Usuarios\ConsultaU.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymEnCasa.App.Presentacion.Pages.ConsultaUModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GymEnCasa.App.Presentacion.Pages.ConsultaUModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GymEnCasa.App.Presentacion.Pages.ConsultaUModel>)PageContext?.ViewData;
        public GymEnCasa.App.Presentacion.Pages.ConsultaUModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
