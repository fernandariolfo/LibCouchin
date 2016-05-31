using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using libCounchinn.Clases;
using libCounchinn.Controles;


namespace ProyectoIngSoft
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            string conect = @"data source=PATOTECKPC\SQLEXPRESS;initial catalog=BD_SHAREIT_PROYECTO_COUCHINN;persist security info=True;user id=Usuario;password=123;MultipleActiveResultSets=True;App=EntityFramework";
            libCounchinn.Clases.ClaseDeConfiguracion.SQLConnectionString = conect;
            ucLogin22.Inicializar();
            ucAltaTipoHospedaje1.inicializar();
            ucLogin22.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ucLogin22_EventoLoginSactifactorio()
        {
            usContribucion1.Usuario = ucLogin22.UsuarioActual;
            usContribucion1.Inicializar();
        }
    }
}
