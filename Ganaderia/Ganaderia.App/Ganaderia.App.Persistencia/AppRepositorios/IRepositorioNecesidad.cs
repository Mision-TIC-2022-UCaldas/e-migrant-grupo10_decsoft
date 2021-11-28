using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioNecesidad
    {
        void AddNecesidad(Necesidad necesidad);
        void DeleteNecesidad(int idNecesidad);
        Necesidad GetNecesidad(int idNecesidad);
        IEnumerable<Necesidad> ListNecesidades();
        void ActualizarNecesidad(int idNecesidad, Necesidad nuevo, Migrante migrante);

    }
}