//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DonJuan_Inventario
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASISTENCIA
    {
        public int ASISTENCIA_ID { get; set; }
        public int EMPLEADO_ID { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<System.DateTime> HORA_ENTRADA { get; set; }
        public Nullable<System.DateTime> HORA_SALIDA { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
    }
}
