//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace muestra.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class personas
    {
        public int id { get; set; }
        public Nullable<int> users_id { get; set; }
        public Nullable<int> imagen_id { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public Nullable<bool> active { get; set; }
    
        public virtual imagenes imagenes { get; set; }
        public virtual users users { get; set; }
    }
}