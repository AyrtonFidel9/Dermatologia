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
    
    public partial class HistoriaClinica
    {
        public int ID_HistClinica { get; set; }
        public string IDPaciente { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string Antecedentes_Medicos { get; set; }
        public string Alergias { get; set; }
        public string Enfermedades_Hereditarias { get; set; }
        public string Observaciones { get; set; }
        public byte[] Fotografias { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}