using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCounchinn.Modelo;
using libCounchinn.Clases;

namespace libCounchinn.Controles
{
    public partial class ucAltaTipoHospedaje : UserControl
    {

        #region variables

        private ModeloLibCouchin varModelo;

        #endregion

        public ucAltaTipoHospedaje()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.bindingSelHospedaje.DataSource = this.varModelo.SEL_TIPOHOSPEDAJE(true);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void mbtCargarHospedaje_Click(object sender, EventArgs e)
        {
            this.bindingSourceINSERT_Hosp.DataSource = this.varModelo.INS_TIPOHOSPEDAJE(this.mTxtHospedaje.Text);
            this.bindingSelHospedaje.DataSource = this.varModelo.SEL_TIPOHOSPEDAJE(true);

        }
    }
}
