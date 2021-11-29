using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Presentacion.Pages
{
    public class MigranteUpdateModel : PageModel
    {
        private static IRepositorioMigrantes _repositorioMigrantes = new RepositorioMigrantes(new Persistencia.AppContext());
        public Migrante migrante;
        public string fecha;
        public IActionResult OnGet()
        {
            var ide=Request.Cookies["Id"];
            migrante=_repositorioMigrantes.GetMigrante(Int32.Parse(ide));
            Console.WriteLine("esta logeado: "+migrante.Nombre);
            fecha=migrante.Fecha_nacimiento.Date.ToString("yyyy-MM-dd");
            Console.WriteLine("fecha: "+fecha);
            
            return Page();

        }
        
        public IActionResult OnPostActualizar(string nombres, string apellidos, string tdocumento,
                string documento, string pais, string nacimiento, string email, string telefono, string direccion,
                string ciudad, string slaboral, string usuario, string clave
                )
        {
            var nuevo = new Migrante
            {
                Nombre = nombres,
                Apellidos = apellidos,
                Tipo_documento = tdocumento,
                No_Documento = documento,
                Pais_origen = pais,
                Fecha_nacimiento = DateTime.Parse(nacimiento),
                Email = email,
                Telefono = telefono,
                Direccion_actual = direccion,
                Ciudad = ciudad,
                Situacion_laboral = slaboral,
                Usuario = usuario,
                Contrasena = clave
            };
            var ide=Int32.Parse(Request.Cookies["Id"]);
            Console.WriteLine("id de usuario: "+(ide));
            migrante=_repositorioMigrantes.GetMigrante(ide);
            _repositorioMigrantes.ActualizarMigrante(ide, nuevo);
            fecha=migrante.Fecha_nacimiento.Date.ToString("yyyy-MM-dd");
            return Page();
                         
        }


    }
}
