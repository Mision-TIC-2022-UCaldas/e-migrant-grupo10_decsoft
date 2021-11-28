using System;
using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class Migrante
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string Tipo_documento {get; set;}
        public string No_Documento {get; set;}
        public string Pais_origen {get; set;}
        public DateTime Fecha_nacimiento {get; set;}
        public string Email {get; set;}
        public string Telefono {get; set;}
        public string Direccion_actual {get; set;}
        public string Ciudad {get; set;}
        public string Situacion_laboral {get; set;}        
        public string Usuario {get; set;}
        public string Contrasena {get; set;}
        public List<Necesidad> Necesidad { get; set; }
        
    }
}
