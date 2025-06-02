namespace ClubDeportivo
{
    partial class FrmPagoActividad
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
            txtDni = new TextBox();
            btnBuscar = new Button();
            lblNombre = new Label();
            cboActividad = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtMonto = new TextBox();
            rdbEfectivo = new RadioButton();
            rdbTarjeta = new RadioButton();
            btnRegistrar = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Location = new Point(44, 76);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 0;
            txtDni.Text = "DNI";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(302, 72);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.Location = new Point(302, 127);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(136, 23);
            cboActividad.TabIndex = 4;
            cboActividad.Text = "Seleccione Actividad";
            cboActividad.SelectedIndexChanged += cboActividad_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(44, 184);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(214, 23);
            dtpFecha.TabIndex = 5;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(302, 187);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 6;
            txtMonto.Text = "Precio";
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(94, 246);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(67, 19);
            rdbEfectivo.TabIndex = 7;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Location = new Point(94, 281);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(60, 19);
            rdbTarjeta.TabIndex = 8;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Tarjeta";
            rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(302, 251);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(138, 49);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "REGISTRAR PAGO";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(142, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(197, 25);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "PAGOS ACTIVIDADES";
            // 
            // FrmPagoActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 381);
            Controls.Add(lblTitulo);
            Controls.Add(btnRegistrar);
            Controls.Add(rdbTarjeta);
            Controls.Add(rdbEfectivo);
            Controls.Add(txtMonto);
            Controls.Add(dtpFecha);
            Controls.Add(cboActividad);
            Controls.Add(lblNombre);
            Controls.Add(btnBuscar);
            Controls.Add(txtDni);
            Name = "FrmPagoActividad";
            Text = "PAGO ACTIVIDAD";
            Load += FrmPagoActividad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private Button btnBuscar;
        private Label lblNombre;
        private ComboBox cboActividad;
        private DateTimePicker dtpFecha;
        private TextBox txtMonto;
        private RadioButton rdbEfectivo;
        private RadioButton rdbTarjeta;
        private Button btnRegistrar;
        private Label lblTitulo;
    }
}