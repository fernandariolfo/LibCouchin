using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using LibConeccionEntity;
using libCounchinn.Clases;
using libCounchinn.Modelo;

namespace libCounchinn.Modelo
{
    [DbConfigurationType(typeof(SQL_Config))]

    public partial class ModeloLibCouchin : DbContext
    {
        public ModeloLibCouchin(string strEFCnxString) : base (strEFCnxString)
        {

        }

        public USUARIO SelectUsuario(string stUsuario,string stPass)
        {
            var consulta = (
                from USUARIO tu in this.USUARIOs
                where tu.NOMRE_USUARIO == stUsuario && tu.CONTRASEÑA == stPass
                select tu
                ).FirstOrDefault();
            return consulta;
        }

        public string SelectEmailUsuario(string stUsuario)
        {
            var consulta = (
                from USUARIO tu in this.USUARIOs
                where tu.NOMRE_USUARIO == stUsuario
                select tu
                ).FirstOrDefault();
            if (consulta != null && consulta.ESTADO_USUARIO == true)
            {
                var consultaEmail = (
                    from PERSONA per in this.PERSONAs
                    where per.ID_PERSONA == consulta.ID_PERSONA
                    select per.E_MAIL_LARGO
                    ).FirstOrDefault();
                return consultaEmail;
            }
            else
            {
                if (consulta != null)
                {
                    return "Usuario bloqueado";
                }
                else
                {
                    return null;
                }
            }
        }

        public int SelectIdUsuarioxNombreUsuario(string NombreUsuario)
        {
            var consulta = (
                from USUARIO u in this.USUARIOs
                where u.NOMRE_USUARIO == NombreUsuario
                select u.ID_USUARIO
                ).FirstOrDefault();
            return consulta;
            
        }
    }
}
