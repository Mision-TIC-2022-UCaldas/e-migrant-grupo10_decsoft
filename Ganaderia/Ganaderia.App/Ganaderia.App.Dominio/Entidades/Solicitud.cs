using System;
using System.Collections.Generic;
namespace Ganaderia.App.Dominio
{
    public class Solicitud 
    {
        public int Id { get; set; }
        public DateTime Fecha_solicitud {get; set;} 
        public DateTime Fecha_respuesta {get; set;} 
        public string Entidad {get; set;} 
        public string Estado {get; set;} 
        
    }
}