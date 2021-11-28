using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioMigrantes
    {
        void AddMigrantes(Migrante migrante);
        Migrante GetLogin(string Usuario, string Contrasena);
        void DeleteMigrante(int idMigrante);
        Migrante GetMigrante(int idMigrante);
        IEnumerable<Migrante> ListMigrantes();
        void ActualizarMigrante(int idMigrante, Migrante nuevo);

    }
}