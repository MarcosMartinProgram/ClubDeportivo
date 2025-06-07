namespace ClubDeportivo
{
    partial class FrmPagos
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
            Button btnImprimirPagos;
            label1 = new Label();
            lblBuscarSocio = new Label();
            txtDniSocio = new TextBox();
            dtpFechaPago = new DateTimePicker();
            dtpFechaVencimiento = new DateTimePicker();
            cmbFormaPago = new ComboBox();
            cmbCantidadCuotas = new ComboBox();
            lblFechaPago = new Label();
            lblFechaVenc = new Label();
            lblFormaPago = new Label();
            lblNumCuotas = new Label();
            txtImporte = new TextBox();
            lblMontoCuota = new Label();
            btnCobrar = new Button();
            dgvPagosRealizados = new DataGridView();
            txtLeyendaSocio = new TextBox();
            btnVolver = new Button();
            btnImprimirPagos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPagosRealizados).BeginInit();
            SuspendLayout();
            // 
            // btnImprimirPagos
            // 
            btnImprimirPagos.AutoSize = true;
            btnImprimirPagos.BackgroundImageLayout = ImageLayout.Center;
            btnImprimirPagos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimirPagos.Location = new Point(532, 216);
            btnImprimirPagos.Name = "btnImprimirPagos";
            btnImprimirPagos.Size = new Size(123, 36);
            btnImprimirPagos.TabIndex = 16;
            btnImprimirPagos.Text = "IMP. HIST. PAGOS";
            btnImprimirPagos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImprimirPagos.UseVisualStyleBackColor = true;
            btnImprimirPagos.Click += btnImprimirPagos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 28);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 0;
            label1.Text = "PAGOS CUOTAS SOCIOS";
            // 
            // lblBuscarSocio
            // 
            lblBuscarSocio.AutoSize = true;
            lblBuscarSocio.Location = new Point(25, 101);
            lblBuscarSocio.Name = "lblBuscarSocio";
            lblBuscarSocio.Size = new Size(36, 15);
            lblBuscarSocio.TabIndex = 1;
            lblBuscarSocio.Text = "Socio";
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(154, 101);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.Size = new Size(218, 23);
            txtDniSocio.TabIndex = 2;
            txtDniSocio.KeyDown += txtDniSocio_KeyDown;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(154, 149);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(218, 23);
            dtpFechaPago.TabIndex = 3;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(154, 190);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(218, 23);
            dtpFechaVencimiento.TabIndex = 4;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Location = new Point(154, 234);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(218, 23);
            cmbFormaPago.TabIndex = 5;
            cmbFormaPago.SelectedIndexChanged += cmbFormaPago_SelectedIndexChanged;
            // 
            // cmbCantidadCuotas
            // 
            cmbCantidadCuotas.FormattingEnabled = true;
            cmbCantidadCuotas.Location = new Point(547, 152);
            cmbCantidadCuotas.Name = "cmbCantidadCuotas";
            cmbCantidadCuotas.Size = new Size(105, 23);
            cmbCantidadCuotas.TabIndex = 6;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(25, 155);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(84, 15);
            lblFechaPago.TabIndex = 7;
            lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblFechaVenc
            // 
            lblFechaVenc.AutoSize = true;
            lblFechaVenc.Location = new Point(25, 196);
            lblFechaVenc.Name = "lblFechaVenc";
            lblFechaVenc.Size = new Size(123, 15);
            lblFechaVenc.TabIndex = 8;
            lblFechaVenc.Text = "Fecha de Vencimiento";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(25, 237);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(87, 15);
            lblFormaPago.TabIndex = 9;
            lblFormaPago.Text = "Forma de Pago";
            // 
            // lblNumCuotas
            // 
            lblNumCuotas.AutoSize = true;
            lblNumCuotas.Location = new Point(405, 155);
            lblNumCuotas.Name = "lblNumCuotas";
            lblNumCuotas.Size = new Size(109, 15);
            lblNumCuotas.TabIndex = 10;
            lblNumCuotas.Text = "Cantidad de cuotas";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(154, 286);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 11;
            // 
            // lblMontoCuota
            // 
            lblMontoCuota.AutoSize = true;
            lblMontoCuota.Location = new Point(25, 289);
            lblMontoCuota.Name = "lblMontoCuota";
            lblMontoCuota.Size = new Size(49, 15);
            lblMontoCuota.TabIndex = 12;
            lblMontoCuota.Text = "Importe";
            // 
            // btnCobrar
            // 
            btnCobrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobrar.Location = new Point(390, 216);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(124, 37);
            btnCobrar.TabIndex = 13;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // dgvPagosRealizados
            // 
            dgvPagosRealizados.AllowUserToAddRows = false;
            dgvPagosRealizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagosRealizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagosRealizados.Location = new Point(25, 328);
            dgvPagosRealizados.Name = "dgvPagosRealizados";
            dgvPagosRealizados.ReadOnly = true;
            dgvPagosRealizados.Size = new Size(629, 161);
            dgvPagosRealizados.TabIndex = 14;
            // 
            // txtLeyendaSocio
            // 
            txtLeyendaSocio.Location = new Point(450, 101);
            txtLeyendaSocio.Name = "txtLeyendaSocio";
            txtLeyendaSocio.ReadOnly = true;
            txtLeyendaSocio.Size = new Size(204, 23);
            txtLeyendaSocio.TabIndex = 15;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(450, 270);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 37);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 510);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimirPagos);
            Controls.Add(txtLeyendaSocio);
            Controls.Add(dgvPagosRealizados);
            Controls.Add(btnCobrar);
            Controls.Add(lblMontoCuota);
            Controls.Add(txtImporte);
            Controls.Add(lblNumCuotas);
            Controls.Add(lblFormaPago);
            Controls.Add(lblFechaVenc);
            Controls.Add(lblFechaPago);
            Controls.Add(cmbCantidadCuotas);
            Controls.Add(cmbFormaPago);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(dtpFechaPago);
            Controls.Add(txtDniSocio);
            Controls.Add(lblBuscarSocio);
            Controls.Add(label1);
            Name = "FrmPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos ";
            FormClosing += FrmPagos_FormClosing;
            Load += FrmPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagosRealizados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBuscarSocio;
        private TextBox txtDniSocio;
        private DateTimePicker dtpFechaPago;
        private DateTimePicker dtpFechaVencimiento;
        private ComboBox cmbFormaPago;
        private ComboBox cmbCantidadCuotas;
        private Label lblFechaPago;
        private Label lblFechaVenc;
        private Label lblFormaPago;
        private Label lblNumCuotas;
        private TextBox txtImporte;
        private Label lblMontoCuota;
        private Button btnCobrar;
        private DataGridView dgvPagosRealizados;
        private TextBox txtLeyendaSocio;
        private Button btnImprimirPagos;
        private Button btnVolver;
    }
}