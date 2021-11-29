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

    public class RegisterMigranteModel : PageModel
    {
        private static IRepositorioMigrantes _repositorioMigrantes = new RepositorioMigrantes(new Persistencia.AppContext());
        public Migrante migrante { get; set; }
        public List<Migrante> migrantes { get; set; }
        public IActionResult OnGet()
        {
            
        migrantes = _repositorioMigrantes.ListMigrantes().ToList();
        return Page();


        }

        public IActionResult OnPostRegister(string nombres, string apellidos, string tdocumento,
                string documento, string pais, string nacimiento, string email, string telefono, string direccion,
                string ciudad, string slaboral, string usuario, string clave
                )
        {
            migrante = new Migrante
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
            //Console.WriteLine("Nombres A guardar: "+ganadero.Nombres);
            //ganadero.Nombres="nombreG";
            //Console.WriteLine("Nombres A guardar2: "+ganadero.Nombres);
            //Console.WriteLine("A guardar: "+migrante.Nombre);
            _repositorioMigrantes.AddMigrantes(migrante);
            return Page();
        }

    }
}
