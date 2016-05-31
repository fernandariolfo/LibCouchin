namespace ProyectoIngSoft
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucLogin22 = new libCounchinn.Controles.ucLogin2();
            this.ucModificarHospedaje1 = new libCounchinn.Controles.ucModificarHospedaje();
            this.usContribucion1 = new libCounchinn.Controles.usContribucion();
            this.ucAltaTipoHospedaje1 = new libCounchinn.Controles.ucAltaTipoHospedaje();
            this.ucVerDetalleHospedaje1 = new libCounchinn.Controles.ucVerDetalleHospedaje();
            this.SuspendLayout();
            // 
            // ucLogin22
            // 
            this.ucLogin22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLogin22.Location = new System.Drawing.Point(20, 74);
            this.ucLogin22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucLogin22.Name = "ucLogin22";
            this.ucLogin22.Size = new System.Drawing.Size(1415, 676);
            this.ucLogin22.TabIndex = 1;
            this.ucLogin22.UseSelectable = true;
            this.ucLogin22.UsuarioActual = null;
            this.ucLogin22.Visible = false;
            this.ucLogin22.EventoLoginSactifactorio += new libCounchinn.Clases.DelegadoLogin(this.ucLogin22_EventoLoginSactifactorio);
            // 
            // ucModificarHospedaje1
            // 
            this.ucModificarHospedaje1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucModificarHospedaje1.Location = new System.Drawing.Point(20, 74);
            this.ucModificarHospedaje1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucModificarHospedaje1.Name = "ucModificarHospedaje1";
            this.ucModificarHospedaje1.Size = new System.Drawing.Size(1415, 676);
            this.ucModificarHospedaje1.TabIndex = 2;
            this.ucModificarHospedaje1.Visible = false;
            // 
            // usContribucion1
            // 
            this.usContribucion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usContribucion1.Location = new System.Drawing.Point(20, 74);
            this.usContribucion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usContribucion1.Name = "usContribucion1";
            this.usContribucion1.Size = new System.Drawing.Size(1415, 676);
            this.usContribucion1.TabIndex = 3;
            this.usContribucion1.UseSelectable = true;
            this.usContribucion1.Usuario = null;
            this.usContribucion1.Visible = false;
            // 
            // ucAltaTipoHospedaje1
            // 
            this.ucAltaTipoHospedaje1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAltaTipoHospedaje1.Location = new System.Drawing.Point(20, 74);
            this.ucAltaTipoHospedaje1.Margin = new System.Windows.Forms.Padding(5);
            this.ucAltaTipoHospedaje1.Name = "ucAltaTipoHospedaje1";
            this.ucAltaTipoHospedaje1.Size = new System.Drawing.Size(1415, 676);
            this.ucAltaTipoHospedaje1.TabIndex = 4;
            // 
            // ucVerDetalleHospedaje1
            // 
            this.ucVerDetalleHospedaje1.Location = new System.Drawing.Point(6, 74);
            this.ucVerDetalleHospedaje1.Name = "ucVerDetalleHospedaje1";
            this.ucVerDetalleHospedaje1.Size = new System.Drawing.Size(1443, 689);
            this.ucVerDetalleHospedaje1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 770);
            this.Controls.Add(this.ucVerDetalleHospedaje1);
            this.Controls.Add(this.ucLogin22);
            this.Controls.Add(this.ucModificarHospedaje1);
            this.Controls.Add(this.usContribucion1);
            this.Controls.Add(this.ucAltaTipoHospedaje1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Ver detalle hospedaje";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private libCounchinn.Controles.ucLogin2 ucLogin22;
        private libCounchinn.Controles.ucModificarHospedaje ucModificarHospedaje1;
        private libCounchinn.Controles.usContribucion usContribucion1;
        private libCounchinn.Controles.ucAltaTipoHospedaje ucAltaTipoHospedaje1;
        private libCounchinn.Controles.ucVerDetalleHospedaje ucVerDetalleHospedaje1;
    }
}

