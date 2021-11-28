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
    public class loginMigranteModel : PageModel
    {
        private static IRepositorioMigrantes _repositorioMigrantes = new RepositorioMigrantes(new Persistencia.AppContext());
        public void OnGet()
        {
        }


        public IActionResult OnPostLogin(string usuario,string clave)
        {
            //Console.WriteLine("Usuario: "+usuario);
            //Console.WriteLine("Contraseña: "+clave);

            var Migrante=_repositorioMigrantes.GetLogin(usuario,clave);
            if(Migrante != null){
                //Console.WriteLine("Inicio de sesion exitoso");
                //Console.WriteLine("Usuario: "+Migrante.Usuario);
                Response.Cookies.Append("Nombre",Migrante.Usuario);
                Response.Cookies.Append("Tipo","Migrante");
                Response.Cookies.Append("Id",Migrante.Id.ToString());
                return Redirect("MigranteInicio");   
            }else{
                //Console.WriteLine("Inicio de sesion malo");
                return Page();
            }
                         
        }
    }
}
