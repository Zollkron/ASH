//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArkadhiaSoulsHunters.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Peto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Peto()
        {
            this.Equipacion = new HashSet<Equipacion>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float defesa { get; set; }
        public int resistenciaTierra { get; set; }
        public int resistenciaAgua { get; set; }
        public int resistenciaHielo { get; set; }
        public int resistenciaAire { get; set; }
        public int resistenciaFuego { get; set; }
        public int resistenciaOscuridad { get; set; }
        public int resistenciaLuz { get; set; }
        public float durabilidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipacion> Equipacion { get; set; }
    }
}
