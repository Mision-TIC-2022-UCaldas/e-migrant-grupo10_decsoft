//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Decsoftemigrant
{
    using System;
    using System.Collections.Generic;
    
    public partial class Solicitud
    {
        public Solicitud()
        {
            this.Migrantes = new HashSet<Migrantes>();
            this.AmigosFamiliares = new HashSet<AmigosFamiliares>();
            this.Servicio = new HashSet<Servicio>();
        }
    
        public int idSolicitud { get; set; }
        public string servicio { get; set; }
        public System.DateTime fecha_solicitud { get; set; }
        public int migrante { get; set; }
    
        public virtual ICollection<Migrantes> Migrantes { get; set; }
        public virtual ICollection<AmigosFamiliares> AmigosFamiliares { get; set; }
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
