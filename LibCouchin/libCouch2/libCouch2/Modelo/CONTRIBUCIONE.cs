//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace libCouch2.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTRIBUCIONE
    {
        public int ID_CONTRIBUCION { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
        public string MONTO_CONTRIBUCION { get; set; }
        public Nullable<System.DateTime> FECHA_CONTRIBUCION { get; set; }
        public Nullable<bool> ESTADO_CONTRIBUCION { get; set; }
        public Nullable<decimal> AUX1 { get; set; }
        public string AUX2 { get; set; }
    }
}
