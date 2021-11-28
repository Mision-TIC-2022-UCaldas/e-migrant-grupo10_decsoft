using System;
using System.Collections.Generic;
namespace Ganaderia.App.Dominio
{
    public class Servicio 
    {
        public int Id { get; set; }
        public string salud { get; set; }
        public string juridicos { get; set; }
        public string viveres { get; set; }
        public string comida_preparada { get; set; }
        public string empleo { get; set; }
        public string alojamiento_temporal { get; set; }
        public string alojamiento_permanente { get; set; }
        public string educacion { get; set; }
        public string otros { get; set; }
        public Necesidad Necesidad { get; set; }

    }
}