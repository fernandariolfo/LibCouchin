using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using libCounchinn.Modelo;
using libCounchinn.Clases;

namespace libCounchinn.Controles
{
    public partial class ucLogin2 : MetroUserControl
    {
        #region Variables

        private ModeloLibCouchin VarModelo;

        public event DelegadoLogin EventoLoginSactifactorio;

        #endregion

        #region Propiedades del constrol usuario

        private USUARIO _usuario;
        public USUARIO UsuarioActual
        {
            get
            {
                return this._usuario;
            }
            set
            {
                this._usuario = value;
            }
        }

        #endregion

        #region Inicializar

        public ucLogin2()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            this.VarModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.mtxtUsuarioLogin.Focus();
        }


        #endregion

        #region Eventos Privados

        private void mbtEntrar_Click(object sender, EventArgs e)
        {
            this.bindingSourceLogin.DataSource = this.VarModelo.SEL_LOGIN(this.mtxtUsuarioLogin.Text, this.mtxtContraseñaLogin.Text);
            if (Convert.ToBoolean(this.EXISISTECIA_DEL_USUARIO.Text) && Convert.ToBoolean(this.ESTADO_DEL_US.Text))
            {
                this.UsuarioActual = this.VarModelo.SelectUsuario(this.mtxtUsuarioLogin.Text, this.mtxtContraseñaLogin.Text);
                this.SendToBack();
                this.Visible = false;
                if (this.EventoLoginSactifactorio != null)
                {
                    this.EventoLoginSactifactorio();
                }
            }
            else
            {
                if ((Convert.ToBoolean(this.ESTADO_DEL_US.Text).Equals(false)) && (Convert.ToBoolean(this.EXISISTECIA_DEL_USUARIO.Text).Equals(true)))
                {
                    MessageBox.Show("El usuario ingresado se encuentra bolqueado. \n Para mas informacion dirijase a AYUDA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña ingresada son incorrectas. \n Vuelva a intentarlo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.mtxtUsuarioLogin.Focus();
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.ucOlvideContraseña1.Inicilizar();
            this.tableLayoutPanel1.SendToBack();
            this.tableLayoutPanel1.Visible = false;
            this.ucOlvideContraseña1.Visible = true;
            this.ucOlvideContraseña1.BringToFront();
        }

        #endregion

    }
}
