﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BD_MODELO_COUCHIN_Var : DbContext
    {
        public BD_MODELO_COUCHIN_Var()
            : base("name=BD_MODELO_COUCHIN_Var")
        {
        }

        public BD_MODELO_COUCHIN_Var(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CONTRIBUCIONE> CONTRIBUCIONES { get; set; }
        public virtual DbSet<DIRECCION> DIRECCIONs { get; set; }
        public virtual DbSet<PERSONA> PERSONAs { get; set; }
        public virtual DbSet<PUBLICACION> PUBLICACIONs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TABLA> TABLAs { get; set; }
        public virtual DbSet<TABLA1> TABLAS1 { get; set; }
        public virtual DbSet<TIPO_HOSPEDAJE> TIPO_HOSPEDAJE { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
        public virtual DbSet<FOTO> FOTOS { get; set; }
    
        public virtual int INS_CONTRIBUCIONES_USUARIO(Nullable<int> iD_USUARIO, string mONTO, Nullable<System.DateTime> fECHA)
        {
            var iD_USUARIOParameter = iD_USUARIO.HasValue ?
                new ObjectParameter("ID_USUARIO", iD_USUARIO) :
                new ObjectParameter("ID_USUARIO", typeof(int));
    
            var mONTOParameter = mONTO != null ?
                new ObjectParameter("MONTO", mONTO) :
                new ObjectParameter("MONTO", typeof(string));
    
            var fECHAParameter = fECHA.HasValue ?
                new ObjectParameter("FECHA", fECHA) :
                new ObjectParameter("FECHA", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_CONTRIBUCIONES_USUARIO", iD_USUARIOParameter, mONTOParameter, fECHAParameter);
        }
    }
}
