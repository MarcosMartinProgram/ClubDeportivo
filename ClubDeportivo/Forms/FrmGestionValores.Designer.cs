namespace ClubDeportivo
{
    partial class FrmGestionValores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tpActividadesYValores = new TabControl();
            tpActividades = new TabPage();
            btnVolver = new Button();
            lblTitulo = new Label();
            btnGuardar = new Button();
            lblCupo = new Label();
            nudCupo = new NumericUpDown();
            lblHorarios = new Label();
            txtHorarios = new TextBox();
            lblDias = new Label();
            clbDias = new CheckedListBox();
            txtNombreActividad = new TextBox();
            lblNombreActiv = new Label();
            tpValoresActividad = new TabPage();
            btnVolverValor = new Button();
            dtpValorActividad = new DateTimePicker();
            btnGuardadValorActividad = new Button();
            txtMontoActividad = new TextBox();
            cboActividad = new ComboBox();
            tpValorCuota = new TabPage();
            btnVolverCuota = new Button();
            dtpValorCuota = new DateTimePicker();
            txtMontoCuota = new TextBox();
            btnGuardarCuota = new Button();
            tpActividadesYValores.SuspendLayout();
            tpActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            tpValoresActividad.SuspendLayout();
            tpValorCuota.SuspendLayout();
            SuspendLayout();
            // 
            // tpActividadesYValores
            // 
            tpActividadesYValores.Controls.Add(tpActividades);
            tpActividadesYValores.Controls.Add(tpValoresActividad);
            tpActividadesYValores.Controls.Add(tpValorCuota);
            tpActividadesYValores.Location = new Point(12, 25);
            tpActividadesYValores.Name = "tpActividadesYValores";
            tpActividadesYValores.SelectedIndex = 0;
            tpActividadesYValores.Size = new Size(611, 367);
            tpActividadesYValores.TabIndex = 0;
            // 
            // tpActividades
            // 
            tpActividades.Controls.Add(btnVolver);
            tpActividades.Controls.Add(lblTitulo);
            tpActividades.Controls.Add(btnGuardar);
            tpActividades.Controls.Add(lblCupo);
            tpActividades.Controls.Add(nudCupo);
            tpActividades.Controls.Add(lblHorarios);
            tpActividades.Controls.Add(txtHorarios);
            tpActividades.Controls.Add(lblDias);
            tpActividades.Controls.Add(clbDias);
            tpActividades.Controls.Add(txtNombreActividad);
            tpActividades.Controls.Add(lblNombreActiv);
            tpActividades.Location = new Point(4, 24);
            tpActividades.Name = "tpActividades";
            tpActividades.Padding = new Padding(3);
            tpActividades.Size = new Size(603, 339);
            tpActividades.TabIndex = 0;
            tpActividades.Text = "Actividades";
            tpActividades.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(449, 239);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 42);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(177, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 30);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "CARGA DE ACTIVIDADES";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(314, 239);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 42);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(314, 176);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(36, 15);
            lblCupo.TabIndex = 7;
            lblCupo.Text = "Cupo";
            // 
            // nudCupo
            // 
            nudCupo.Location = new Point(389, 174);
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new Size(120, 23);
            nudCupo.TabIndex = 6;
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Location = new Point(314, 134);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(52, 15);
            lblHorarios.TabIndex = 5;
            lblHorarios.Text = "Horarios";
            // 
            // txtHorarios
            // 
            txtHorarios.Location = new Point(389, 131);
            txtHorarios.Name = "txtHorarios";
            txtHorarios.Size = new Size(190, 23);
            txtHorarios.TabIndex = 4;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(43, 184);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(96, 15);
            lblDias.TabIndex = 3;
            lblDias.Text = "Dias que se Dicta";
            // 
            // clbDias
            // 
            clbDias.FormattingEnabled = true;
            clbDias.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            clbDias.Location = new Point(177, 126);
            clbDias.Name = "clbDias";
            clbDias.Size = new Size(92, 130);
            clbDias.TabIndex = 2;
            // 
            // txtNombreActividad
            // 
            txtNombreActividad.Location = new Point(141, 84);
            txtNombreActividad.Name = "txtNombreActividad";
            txtNombreActividad.Size = new Size(189, 23);
            txtNombreActividad.TabIndex = 1;
            // 
            // lblNombreActiv
            // 
            lblNombreActiv.AutoSize = true;
            lblNombreActiv.Location = new Point(43, 87);
            lblNombreActiv.Name = "lblNombreActiv";
            lblNombreActiv.Size = new Size(54, 15);
            lblNombreActiv.TabIndex = 0;
            lblNombreActiv.Text = "Nombre:";
            // 
            // tpValoresActividad
            // 
            tpValoresActividad.Controls.Add(btnVolverValor);
            tpValoresActividad.Controls.Add(dtpValorActividad);
            tpValoresActividad.Controls.Add(btnGuardadValorActividad);
            tpValoresActividad.Controls.Add(txtMontoActividad);
            tpValoresActividad.Controls.Add(cboActividad);
            tpValoresActividad.Location = new Point(4, 24);
            tpValoresActividad.Name = "tpValoresActividad";
            tpValoresActividad.Padding = new Padding(3);
            tpValoresActividad.Size = new Size(603, 339);
            tpValoresActividad.TabIndex = 1;
            tpValoresActividad.Text = "Valores Actividad";
            tpValoresActividad.UseVisualStyleBackColor = true;
            // 
            // btnVolverValor
            // 
            btnVolverValor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverValor.Location = new Point(285, 179);
            btnVolverValor.Name = "btnVolverValor";
            btnVolverValor.Size = new Size(124, 42);
            btnVolverValor.TabIndex = 11;
            btnVolverValor.Text = "VOLVER";
            btnVolverValor.UseVisualStyleBackColor = true;
            btnVolverValor.Click += btnVolver_Click;
            // 
            // dtpValorActividad
            // 
            dtpValorActividad.Location = new Point(319, 56);
            dtpValorActividad.Name = "dtpValorActividad";
            dtpValorActividad.Size = new Size(200, 23);
            dtpValorActividad.TabIndex = 3;
            // 
            // btnGuardadValorActividad
            // 
            btnGuardadValorActividad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardadValorActividad.Location = new Point(70, 179);
            btnGuardadValorActividad.Name = "btnGuardadValorActividad";
            btnGuardadValorActividad.Size = new Size(125, 42);
            btnGuardadValorActividad.TabIndex = 2;
            btnGuardadValorActividad.Text = "GUARDAR";
            btnGuardadValorActividad.UseVisualStyleBackColor = true;
            btnGuardadValorActividad.Click += btnGuardarValorActividad_Click;
            // 
            // txtMontoActividad
            // 
            txtMontoActividad.Location = new Point(52, 114);
            txtMontoActividad.Name = "txtMontoActividad";
            txtMontoActividad.Size = new Size(189, 23);
            txtMontoActividad.TabIndex = 1;
            txtMontoActividad.Text = "Ingrese el Precio";
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.Location = new Point(52, 56);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(189, 23);
            cboActividad.TabIndex = 0;
            cboActividad.Text = "Seleccione una actividad";
            // 
            // tpValorCuota
            // 
            tpValorCuota.Controls.Add(btnVolverCuota);
            tpValorCuota.Controls.Add(dtpValorCuota);
            tpValorCuota.Controls.Add(txtMontoCuota);
            tpValorCuota.Controls.Add(btnGuardarCuota);
            tpValorCuota.Location = new Point(4, 24);
            tpValorCuota.Name = "tpValorCuota";
            tpValorCuota.Padding = new Padding(3);
            tpValorCuota.Size = new Size(603, 339);
            tpValorCuota.TabIndex = 2;
            tpValorCuota.Text = "Valor Cuota";
            tpValorCuota.UseVisualStyleBackColor = true;
            // 
            // btnVolverCuota
            // 
            btnVolverCuota.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverCuota.Location = new Point(298, 110);
            btnVolverCuota.Name = "btnVolverCuota";
            btnVolverCuota.Size = new Size(133, 47);
            btnVolverCuota.TabIndex = 11;
            btnVolverCuota.Text = "VOLVER";
            btnVolverCuota.UseVisualStyleBackColor = true;
            btnVolverCuota.Click += btnVolver_Click;
            // 
            // dtpValorCuota
            // 
            dtpValorCuota.Location = new Point(308, 52);
            dtpValorCuota.Name = "dtpValorCuota";
            dtpValorCuota.Size = new Size(200, 23);
            dtpValorCuota.TabIndex = 2;
            // 
            // txtMontoCuota
            // 
            txtMontoCuota.Location = new Point(57, 52);
            txtMontoCuota.Name = "txtMontoCuota";
            txtMontoCuota.Size = new Size(196, 23);
            txtMontoCuota.TabIndex = 1;
            txtMontoCuota.Text = "Ingrese el Valor de la Cuota";
            // 
            // btnGuardarCuota
            // 
            btnGuardarCuota.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCuota.Location = new Point(81, 110);
            btnGuardarCuota.Name = "btnGuardarCuota";
            btnGuardarCuota.Size = new Size(129, 47);
            btnGuardarCuota.TabIndex = 0;
            btnGuardarCuota.Text = "GUARDAR";
            btnGuardarCuota.UseVisualStyleBackColor = true;
            btnGuardarCuota.Click += btnGuardarValorCuota_Click;
            // 
            // FrmGestionValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 421);
            Controls.Add(tpActividadesYValores);
            Name = "FrmGestionValores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Actividades y Valores";
            Load += FrmGestionValores_Load;
            tpActividadesYValores.ResumeLayout(false);
            tpActividades.ResumeLayout(false);
            tpActividades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupo).EndInit();
            tpValoresActividad.ResumeLayout(false);
            tpValoresActividad.PerformLayout();
            tpValorCuota.ResumeLayout(false);
            tpValorCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpActividadesYValores;
        private TabPage tpActividades;
        private TabPage tpValoresActividad;
        private TextBox txtNombreActividad;
        private Label lblNombreActiv;
        private TabPage tpValorCuota;
        private Label lblDias;
        private CheckedListBox clbDias;
        private Label lblTitulo;
        private Button btnGuardar;
        private Label lblCupo;
        private NumericUpDown nudCupo;
        private Label lblHorarios;
        private TextBox txtHorarios;
        private Button btnGuardadValorActividad;
        private TextBox txtMontoActividad;
        private ComboBox cboActividad;
        private TextBox txtMontoCuota;
        private Button btnGuardarCuota;
        private DateTimePicker dtpValorCuota;
        private DateTimePicker dtpValorActividad;
        private Button btnVolver;
        private Button btnVolverValor;
        private Button btnVolverCuota;
    }
}