using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioMigrantes : IRepositorioMigrantes
    {
        public List<Migrante> migrantes;
        private readonly AppContext _appContext;

        public RepositorioMigrantes(AppContext appContext)
        {
            _appContext = appContext;
        }

        Migrante IRepositorioMigrantes.GetLogin(string Usuario, string Contrasena)
        {
            return _appContext.Migrantes.FirstOrDefault(g => g.Usuario == Usuario && g.Contrasena == Contrasena);
        }


        void IRepositorioMigrantes.AddMigrantes(Migrante migrante)
        {
            _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
        }

        
        void IRepositorioMigrantes.DeleteMigrante(int idMigrante)
        {
            var migranteEncontrado = _appContext.Migrantes.FirstOrDefault(g => g.Id == idMigrante);

            if (migranteEncontrado != null)
            {
                _appContext.Migrantes.Remove(migranteEncontrado);
                _appContext.SaveChanges();
            }
        }
        Migrante IRepositorioMigrantes.GetMigrante(int idMigrante)
        {
            return _appContext.Migrantes.FirstOrDefault(e => e.Id == idMigrante);
        }

IEnumerable<Migrante> IRepositorioMigrantes.ListMigrantes()
        {
            return _appContext.Migrantes;
        }

void IRepositorioMigrantes.ActualizarMigrante(int idMigrante, Migrante nuevo)
{
            
            var migrante=_appContext.Migrantes.FirstOrDefault(e => e.Id == idMigrante);
            migrante.Nombre=nuevo.Nombre;
            migrante.Apellidos=nuevo.Apellidos;
            migrante.Tipo_documento=nuevo.Tipo_documento;
            migrante.Documento=nuevo.Documento;
            migrante.Pais_origen=nuevo.Pais_origen;
            migrante.Fecha_nacimiento=nuevo.Fecha_nacimiento;
            migrante.Email=nuevo.Email;
            migrante.Telefono=nuevo.Telefono;
            migrante.Direccion_actual=nuevo.Direccion_actual;
            migrante.Ciudad=nuevo.Ciudad;
            migrante.Situacion_laboral=nuevo.Situacion_laboral;
            migrante.Usuario=nuevo.Usuario;
            migrante.Contrasena=nuevo.Contrasena;
            _appContext.SaveChanges();
        }



    }

    
}