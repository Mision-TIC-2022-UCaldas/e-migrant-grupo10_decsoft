//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace emigrant
{
    using System;
    using System.Collections.Generic;
    
    public partial class Necesidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Necesidad()
        {
            this.Servicio = new HashSet<Servicio>();
        }
    
        public int idnecesidad { get; set; }
        public string salud { get; set; }
        public string alimentacion { get; set; }
        public string empleo { get; set; }
        public string alojamiento_temporal { get; set; }
        public string alojamiento_permanente { get; set; }
        public string educacion { get; set; }
        public string ayuda_legal { get; set; }
        public int Migrantes_idmigrante { get; set; }
    
        public virtual Migrantes Migrantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
