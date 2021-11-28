using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioNecesidad : IRepositorioNecesidad
    {
        public List<Necesidad> necesidades;
        private readonly AppContext _appContext;

        public RepositorioNecesidad(AppContext appContext)
        {
            _appContext = appContext;
        }

        void IRepositorioNecesidad.AddNecesidad(Necesidad necesidad)
        {
            _appContext.Necesidades.Add(necesidad);
            _appContext.SaveChanges();
        }

        
        void IRepositorioNecesidad.DeleteNecesidad(int idNecesidad)
        {
            var necesidadEncontrada = _appContext.Necesidades.FirstOrDefault(g => g.Id == idNecesidad);

            if (necesidadEncontrada != null)
            {
                _appContext.Necesidades.Remove(necesidadEncontrada);
                _appContext.SaveChanges();
            }
        }
        Necesidad IRepositorioNecesidad.GetNecesidad(int idNecesidad)
        {
            return _appContext.Necesidades.FirstOrDefault(e => e.Id == idNecesidad);
        }

IEnumerable<Necesidad> IRepositorioNecesidad.ListNecesidades()
        {
            return _appContext.Necesidades;
        }

void IRepositorioNecesidad.ActualizarNecesidad(int idNecesidad, Necesidad nuevo, Migrante migrante)
{
            
            var necesidad=_appContext.Necesidades.FirstOrDefault(e => e.Id == idNecesidad);
            necesidad.salud=nuevo.salud;
            necesidad.alimentacion=nuevo.alimentacion;
            necesidad.empleo=nuevo.empleo;
            necesidad.alojamiento_temporal=nuevo.alojamiento_temporal;
            necesidad.alojamiento_permanente=nuevo.alojamiento_permanente;
            necesidad.educacion=nuevo.educacion;
            necesidad.ayuda_legal=nuevo.ayuda_legal;

            necesidad.Migrante=nuevo.Migrante;
            necesidad.Servicio=nuevo.Servicio;
            
            _appContext.SaveChanges();
        }



    }

    
}