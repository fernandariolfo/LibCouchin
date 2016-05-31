namespace libCounchinn.Controles
{
    partial class ucAltaTipoHospedaje
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mbtCargarHospedaje = new MetroFramework.Controls.MetroButton();
            this.Mail = new MetroFramework.Controls.MetroLabel();
            this.mTxtHospedaje = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mbtModificar = new MetroFramework.Controls.MetroButton();
            this.mbtEliminar = new MetroFramework.Controls.MetroButton();
            this.mbtCancelarHospedaje = new MetroFramework.Controls.MetroButton();
            this.metroGridAltaHospedaje = new MetroFramework.Controls.MetroGrid();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSelHospedaje = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceINSERT_Hosp = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAltaHospedaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSelHospedaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceINSERT_Hosp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.metroGridAltaHospedaje, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(867, 396);
            this.tableLayoutPanel4.TabIndex = 4;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(263, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(340, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Ingrese el tipo de hospedaje a dar de alta";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.OliveDrab;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(260, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(347, 56);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(43, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(261, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Carga nuevo tipo de hospedaje";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel1.Controls.Add(this.mbtCargarHospedaje, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Mail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mTxtHospedaje, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(260, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 78);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mbtCargarHospedaje
            // 
            this.mbtCargarHospedaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtCargarHospedaje.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtCargarHospedaje.ForeColor = System.Drawing.Color.Black;
            this.mbtCargarHospedaje.Location = new System.Drawing.Point(4, 47);
            this.mbtCargarHospedaje.Name = "mbtCargarHospedaje";
            this.mbtCargarHospedaje.Size = new System.Drawing.Size(75, 23);
            this.mbtCargarHospedaje.TabIndex = 7;
            this.mbtCargarHospedaje.Text = "Cargar";
            this.mbtCargarHospedaje.UseCustomBackColor = true;
            this.mbtCargarHospedaje.UseCustomForeColor = true;
            this.mbtCargarHospedaje.UseSelectable = true;
            this.mbtCargarHospedaje.Click += new System.EventHandler(this.mbtCargarHospedaje_Click);
            // 
            // Mail
            // 
            this.Mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(5, 10);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(74, 19);
            this.Mail.TabIndex = 0;
            this.Mail.Text = "Hospedaje:";
            this.Mail.UseCustomBackColor = true;
            this.Mail.UseCustomForeColor = true;
            // 
            // mTxtHospedaje
            // 
            this.mTxtHospedaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mTxtHospedaje.CustomButton.Image = null;
            this.mTxtHospedaje.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.mTxtHospedaje.CustomButton.Name = "";
            this.mTxtHospedaje.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtHospedaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtHospedaje.CustomButton.TabIndex = 1;
            this.mTxtHospedaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtHospedaje.CustomButton.UseSelectable = true;
            this.mTxtHospedaje.CustomButton.Visible = false;
            this.mTxtHospedaje.Lines = new string[0];
            this.mTxtHospedaje.Location = new System.Drawing.Point(87, 8);
            this.mTxtHospedaje.MaxLength = 32767;
            this.mTxtHospedaje.Name = "mTxtHospedaje";
            this.mTxtHospedaje.PasswordChar = '\0';
            this.mTxtHospedaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtHospedaje.SelectedText = "";
            this.mTxtHospedaje.SelectionLength = 0;
            this.mTxtHospedaje.SelectionStart = 0;
            this.mTxtHospedaje.Size = new System.Drawing.Size(257, 23);
            this.mTxtHospedaje.TabIndex = 3;
            this.mTxtHospedaje.UseSelectable = true;
            this.mTxtHospedaje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtHospedaje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.mbtModificar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mbtEliminar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.mbtCancelarHospedaje, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(87, 42);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 33);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // mbtModificar
            // 
            this.mbtModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtModificar.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtModificar.ForeColor = System.Drawing.Color.Black;
            this.mbtModificar.Location = new System.Drawing.Point(5, 5);
            this.mbtModificar.Name = "mbtModificar";
            this.mbtModificar.Size = new System.Drawing.Size(75, 23);
            this.mbtModificar.TabIndex = 7;
            this.mbtModificar.Text = "Modificar";
            this.mbtModificar.UseCustomBackColor = true;
            this.mbtModificar.UseCustomForeColor = true;
            this.mbtModificar.UseSelectable = true;
            // 
            // mbtEliminar
            // 
            this.mbtEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtEliminar.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtEliminar.ForeColor = System.Drawing.Color.Black;
            this.mbtEliminar.Location = new System.Drawing.Point(90, 5);
            this.mbtEliminar.Name = "mbtEliminar";
            this.mbtEliminar.Size = new System.Drawing.Size(75, 23);
            this.mbtEliminar.TabIndex = 6;
            this.mbtEliminar.Text = "Eliminar";
            this.mbtEliminar.UseCustomBackColor = true;
            this.mbtEliminar.UseCustomForeColor = true;
            this.mbtEliminar.UseSelectable = true;
            // 
            // mbtCancelarHospedaje
            // 
            this.mbtCancelarHospedaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtCancelarHospedaje.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtCancelarHospedaje.ForeColor = System.Drawing.Color.Black;
            this.mbtCancelarHospedaje.Location = new System.Drawing.Point(176, 5);
            this.mbtCancelarHospedaje.Name = "mbtCancelarHospedaje";
            this.mbtCancelarHospedaje.Size = new System.Drawing.Size(75, 23);
            this.mbtCancelarHospedaje.TabIndex = 5;
            this.mbtCancelarHospedaje.Text = "Cancelar";
            this.mbtCancelarHospedaje.UseCustomBackColor = true;
            this.mbtCancelarHospedaje.UseCustomForeColor = true;
            this.mbtCancelarHospedaje.UseSelectable = true;
            // 
            // metroGridAltaHospedaje
            // 
            this.metroGridAltaHospedaje.AllowUserToAddRows = false;
            this.metroGridAltaHospedaje.AllowUserToDeleteRows = false;
            this.metroGridAltaHospedaje.AllowUserToResizeRows = false;
            this.metroGridAltaHospedaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroGridAltaHospedaje.AutoGenerateColumns = false;
            this.metroGridAltaHospedaje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAltaHospedaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAltaHospedaje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridAltaHospedaje.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAltaHospedaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAltaHospedaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.metroGridAltaHospedaje.DataSource = this.bindingSelHospedaje;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAltaHospedaje.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAltaHospedaje.EnableHeadersVisualStyles = false;
            this.metroGridAltaHospedaje.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAltaHospedaje.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAltaHospedaje.Location = new System.Drawing.Point(258, 203);
            this.metroGridAltaHospedaje.Name = "metroGridAltaHospedaje";
            this.metroGridAltaHospedaje.ReadOnly = true;
            this.metroGridAltaHospedaje.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAltaHospedaje.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAltaHospedaje.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAltaHospedaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAltaHospedaje.Size = new System.Drawing.Size(350, 190);
            this.metroGridAltaHospedaje.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGridAltaHospedaje.TabIndex = 2;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSelHospedaje
            // 
            this.bindingSelHospedaje.DataSource = typeof(libCounchinn.Modelo.SEL_TIPOHOSPEDAJE_Result);
            // 
            // ucAltaTipoHospedaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "ucAltaTipoHospedaje";
            this.Size = new System.Drawing.Size(867, 396);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAltaHospedaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSelHospedaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceINSERT_Hosp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel Mail;
        private MetroFramework.Controls.MetroTextBox mTxtHospedaje;
        private MetroFramework.Controls.MetroGrid metroGridAltaHospedaje;
        private System.Windows.Forms.BindingSource bindingSourceINSERT_Hosp;
        private MetroFramework.Controls.MetroButton mbtCancelarHospedaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroButton mbtModificar;
        private MetroFramework.Controls.MetroButton mbtEliminar;
        private System.Windows.Forms.BindingSource bindingSelHospedaje;
        private MetroFramework.Controls.MetroButton mbtCargarHospedaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
    }
}
