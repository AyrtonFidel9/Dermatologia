//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppDermatologia.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int ID_Reserva { get; set; }
        public string IDPaciente { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Servicio { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
