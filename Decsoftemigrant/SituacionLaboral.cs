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
    
    public partial class SituacionLaboral
    {
        public int idSituacionLaboral { get; set; }
        public string temporal { get; set; }
        public string fijo { get; set; }
        public string informal { get; set; }
        public string ama_de_casa { get; set; }
        public string desempleado { get; set; }
        public int AmigosFamiliares_idAmigosFamiliares { get; set; }
        public int Migrantes_idmigrante { get; set; }
    
        public virtual AmigosFamiliares AmigosFamiliares { get; set; }
        public virtual Migrantes Migrantes { get; set; }
    }
}
