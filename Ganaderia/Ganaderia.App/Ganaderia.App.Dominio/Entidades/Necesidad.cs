using System;
using System.Collections.Generic;
namespace Ganaderia.App.Dominio
{
    public class Necesidad
    {
        public int Id { get; set; }
        public string salud { get; set; }
        public string alimentacion { get; set; }
        public string empleo { get; set; }
        public string alojamiento_temporal { get; set; }
        public string alojamiento_permanente { get; set; }
        public string educacion { get; set; }
        public string ayuda_legal { get; set; }
        public Migrante Migrante { get; set; }
        public List<Servicio> Servicio { get; set; }

    }
}